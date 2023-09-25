using ReolMarkedetNet.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedetNet
{
    public class SaleRepository
    {
        private readonly DB_F23_TEAM_11Entities2 context;

        public SaleRepository()
        {
            context = new DB_F23_TEAM_11Entities2();
        }

        public Sale GetSale(int saleId)
        {
            return context.Sale.FirstOrDefault(s => s.saleId == saleId);
        }
    }
}
