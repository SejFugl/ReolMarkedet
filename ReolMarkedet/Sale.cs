using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet
{
    public class Sale
    {
        public double TotalPrice { get; set; }
        public DateTime SaleDate { get; set; }

        public Sale(double totalPrice, DateTime saleDate)
        {
            TotalPrice = totalPrice;
            SaleDate = saleDate;
        }

        //public void MakeSale(string Barcode)
        //{

        //}
    }
}
