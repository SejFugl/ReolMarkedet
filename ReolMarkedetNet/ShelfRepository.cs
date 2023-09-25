using ReolMarkedetNet.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReolMarkedetNet
{
    public class ShelfRepository
    {
        private readonly DB_F23_TEAM_11Entities2 context;

        public ShelfRepository()
        {
            context = new DB_F23_TEAM_11Entities2();
        }

        public Shelf GetShelf(int shelfId)
        {
            return context.Shelf.FirstOrDefault(s => s.shelfId == shelfId);
        }

        public void CreateShelf(Shelf newShelf)
        {
            context.Shelf.Add(newShelf);
            context.SaveChanges();
        }

        public void UpdateShelf(Shelf updatedShelf)
        {
            context.Entry(updatedShelf).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteShelf(int shelfId)
        {
            Shelf shelfToDelete = context.Shelf.Find(shelfId);

            if (shelfToDelete != null)
            {
                context.Entry(shelfToDelete).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
