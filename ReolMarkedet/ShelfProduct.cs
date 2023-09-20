using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet
{
    public class ShelfProduct
    {
        public int ProductId { get; set; }
        public string Barcode { get; set; }
        public string ProductDescription { get; set; }
        public double Price { get; set; }
        public bool Sold { get; set; }

        public ShelfProduct(int productId, string barcode, string productDescription, double price, bool sold)
        {
            ProductId = productId;
            Barcode = barcode;
            ProductDescription = productDescription;
            Price = price;
            Sold = sold;
        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}
    }
}
