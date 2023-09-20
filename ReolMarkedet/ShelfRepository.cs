using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet
{
    public class ShelfRepository
    {
        private List<Shelf> shelves = new List<Shelf>();

        public Shelf GetShelf(int shelfId)
        {
            foreach (var shelf in shelves)
            {
                return shelf;
            }
            return null;
        }
    }
}
