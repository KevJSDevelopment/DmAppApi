using System;
using System.Collections.Generic;
using System.Linq;
using DMApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace DMApp.Data
{
    public class SqlItemRepo : IItemRepo
    {
        private readonly DMAppContext _context;

        public SqlItemRepo(DMAppContext context)
        {
            _context = context;
        }

        public Item CreateItem(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            _context.Items.Add(item);
            _context.SaveChanges();

            return item;
        }

        public void DeleteItem(int itemId)
        {
            Item item = _context.Items.FirstOrDefault(c => c.Id == itemId);

            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            _context.Items.Remove(item);
        }

        public Item GetItemById(long itemId)
        {
            return _context.Items.FirstOrDefault(c => c.Id == itemId);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}