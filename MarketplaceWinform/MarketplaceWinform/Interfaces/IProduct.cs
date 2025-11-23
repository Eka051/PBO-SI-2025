using MarketplaceWinform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceWinform.Interfaces
{
    public interface IProduct
    {
        void CreateProduct(Product product);

        List<Product> GetByUserId(int userId);
        List<Product> GetAllProduct();
    }
}
