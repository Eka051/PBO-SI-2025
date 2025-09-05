<# 
Cleanup-Git-Refs-DesktopIni.ps1
Fixes "bad object refs/desktop.ini" errors on Windows by removing stray desktop.ini files
from .git\refs and .git\logs\refs, sanitizing packed-refs, and running git integrity commands.

Usage:
  1) Open PowerShell in the ROOT of your repo (the folder that contains the .git folder).
  2) Run:
       .\Cleanup-Git-Refs-DesktopIni.ps1
#>

param(
  [switch]$Silent
)

function Write-Info($msg) {
  if (-not $Silent) {
    Write-Host $msg
  }
}

# 0) Sanity checks
$repoRoot = Get-Location
$gitDir   = Join-Path $repoRoot ".git"
if (-not (Test-Path $gitDir)) {
  Write-Error "This folder does not look like a Git repository ('.git' not found): $repoRoot"
  exit 1
}

Write-Info "Repo: $repoRoot"
Write-Info "Step 1/5: Removing 'desktop.ini' under .git\refs and .git\logs\refs ..."

# 1) Remove desktop.ini inside .git\refs and .git\logs\refs
$targets = @(
  Join-Path $gitDir "refs"
  ,(Join-Path $gitDir "logs\refs")
)

foreach ($t in $targets) {
  if (Test-Path $t) {
    Get-ChildItem $t -Filter "desktop.ini" -Recurse -Force -ErrorAction SilentlyContinue | ForEach-Object {
      try {
        attrib -h -s $_.FullName | Out-Null
      } catch {}
      try {
        Remove-Item $_.FullName -Force -ErrorAction Stop
        Write-Info ("  Removed: {0}" -f $_.FullName)
      } catch {
        Write-Warning ("  Failed to remove: {0} => {1}" -f $_.FullName, $_.Exception.Message)
      }
    }
  }
}

# 2) Clean packed-refs (remove any line that mentions desktop.ini)
Write-Info "Step 2/5: Sanitizing .git\packed-refs ..."
$packedRefs = Join-Path $gitDir "packed-refs"
if (Test-Path $packedRefs) {
  try {
    $content = Get-Content $packedRefs -ErrorAction Stop
    $filtered = $content | Where-Object { $_ -notmatch 'desktop\.ini' }
    if ($filtered.Count -ne $content.Count) {
      $filtered | Set-Content $packedRefs -NoNewline
      Write-Info "  Removed invalid lines from packed-refs."
    } else {
      Write-Info "  No invalid lines found in packed-refs."
    }
  } catch {
    Write-Warning ("  Could not read/write packed-refs: {0}" -f $_.Exception.Message)
  }
} else {
  Write-Info "  No packed-refs file found (that's fine)."
}

# 3) List refs (diagnostic)
Write-Info "Step 3/5: Checking refs (git for-each-ref) ..."
try {
  git for-each-ref | Out-Null
  Write-Info "  Refs look ok."
} catch {
  Write-Warning "  git for-each-ref reported an issue. Continuing with repair steps..."
}

# 4) Integrity check
Write-Info "Step 4/5: Running git fsck --full (integrity check) ..."
try {
  git fsck --full
} catch {
  Write-Warning "  git fsck found issues. Some may be auto-fixed by garbage collection."
}

# 5) Garbage collection
Write-Info "Step 5/5: Running git gc --prune=now ..."
try {
  git gc --prune=now
} catch {
  Write-Warning "  git gc failed: $($_.Exception.Message)"
}

Write-Info "`nDone."
Write-Info "Next steps you can try:"
Write-Info "  git fetch --prune --tags"
Write-Info "  git pull"
