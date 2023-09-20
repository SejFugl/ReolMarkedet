using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet
{
    public class SaleRepository
    {
        private List<Sale> sales = new List<Sale>();

        public Sale GetSale(int saleId)
        {
            foreach (var sale in sales)
            {
                return sale;
            }
            return null;
        }
    }
}
