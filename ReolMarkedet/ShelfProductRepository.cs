using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet
{
    public class ShelfProductRepository
    {
        private List<ShelfProduct> shelfProducts = new List<ShelfProduct>();

        public ShelfProduct GetShelfProduct(int productId)
        {
            foreach (var shelfProduct in shelfProducts)
            {
                return shelfProduct;
            }
            return null;
        }
    }
}
