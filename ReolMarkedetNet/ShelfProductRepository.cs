using ReolMarkedetNet.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedetNet
{
    public class ShelfProductRepository
    {
        private readonly DB_F23_TEAM_11Entities2 context;

        public ShelfProductRepository()
        {
            context = new DB_F23_TEAM_11Entities2();
        }

        public ShelfProduct GetShelfProduct(int productId)
        {
           return context.ShelfProduct.FirstOrDefault(p => p.productId == productId);
        }
    }
}
