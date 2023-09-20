using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet
{
    public class ShelfOwner
    {
        public int OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public ShelfOwner(int ownerId, string firstName, string lastName, string phoneNumber, string email)
        {
            OwnerId = ownerId;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        //public void ShowPersonalShelfs()
        //{

        //}

        //public ShelfProduct AddNewSalesItem(string productDescription, double price)
        //{
        //    return;
        //}

        //public void ShowShelfProducts()
        //{

        //}

        //public void PrintBarcodeLabels()
        //{

        //}

        //public void ChangePrice(int productId, double price)
        //{

        //}
    }
}
