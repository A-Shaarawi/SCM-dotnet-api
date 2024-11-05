using System.Collections.Generic;
using System.Linq;
using MyApi.Models;

namespace MyApi.Data
{
    public class ItemRepository
    {
        private static List<Item> _items = new List<Item>
        {
            new Item { Id = 1, Name = "Item1", Description = "Description1", Price = 10.00M },
            new Item { Id = 2, Name = "Item2", Description = "Description2", Price = 20.00M }
        };

        public List<Item> GetAll() => _items;

        public Item? GetById(int id) => _items.FirstOrDefault(i => i.Id == id);

        public void Add(Item item)
        {
            item.Id = _items.Count > 0 ? _items.Max(i => i.Id) + 1 : 1;
            _items.Add(item);
        }

        public void Update(Item item)
        {
            var index = _items.FindIndex(i => i.Id == item.Id);
            if (index != -1) _items[index] = item;
        }

        public void Delete(int id) => _items.RemoveAll(i => i.Id == id);
    }
}
