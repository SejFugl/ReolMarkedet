using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet
{
    public class ShelfOwnerRepository
    {
        private List<ShelfOwner> owners = new List<ShelfOwner>();

        public ShelfOwner GetShelfOwner(int ownerId)
        {
            foreach (var shelfOwner in owners)
            {
                return shelfOwner;
            }
            return null;
        }
    }
}
