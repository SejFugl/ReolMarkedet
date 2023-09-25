using ReolMarkedetNet.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedetNet
{
    public class ShelfOwnerRepository
    {
        private readonly DB_F23_TEAM_11Entities2 context;

        public ShelfOwnerRepository()
        {
            context = new DB_F23_TEAM_11Entities2();
        }

        public ShelfOwner GetShelfOwner(int ownerId)
        {
            return context.ShelfOwner.FirstOrDefault(o => o.ownerId == ownerId);
        }
    }
}
