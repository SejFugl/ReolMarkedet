using ReolMarkedetNet.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public void CreateShelfOwner(ShelfOwner newShelfOwner)
        {
            context.ShelfOwner.Add(newShelfOwner);
            context.SaveChanges();
        }

        public void UpdateShelfOwner(ShelfOwner updatedShelfOwner)
        {
            context.Entry(updatedShelfOwner).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteShelfOwner(int ownerId)
        {
            ShelfOwner ownerToDelete = context.ShelfOwner.Find(ownerId);

            if (ownerToDelete != null)
            {
                context.Entry(ownerToDelete).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
