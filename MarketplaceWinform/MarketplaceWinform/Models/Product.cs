using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceWinform.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public byte[] Image { get; set; }
        public string ProductName { get; set; }
        public int Price {  get; set; }
        public int Stock {  get; set; }
        public int UserId { get; set; }
    }
}
