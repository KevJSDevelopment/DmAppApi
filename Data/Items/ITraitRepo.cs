using System.Collections.Generic;
using DMApp.Models;

namespace DMApp.Data
{
    public interface IItemRepo
    {
        bool SaveChanges();
        Item CreateItem(Item item);
        void DeleteItem(int itemId);
    }
}