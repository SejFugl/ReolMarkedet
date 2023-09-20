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
        public DateTime Date { get; set; }

        public Sale(double totalPrice, DateTime date)
        {
            TotalPrice = totalPrice;
            Date = date;
        }

        //public void MakeSale(string Barcode)
        //{

        //}
    }
}
