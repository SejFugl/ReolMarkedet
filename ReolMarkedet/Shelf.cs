using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedet
{
    public class Shelf
    {
        public int ShelfId { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }

        public Shelf(int shelfId, string location, string category)
        {
            ShelfId = shelfId;
            Location = location;
            Category = category;
        }
    }
}
