using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvertoryServices.Models;

namespace InvertoryServices.Services
{
    public class InventoryService : IInventoryServices
    {

        private readonly Dictionary<string, InventoryItems> _inventoryItems;

        public InventoryService()
        {
            _inventoryItems = new Dictionary<string, InventoryItems>();
        }

        public InventoryItems AddInventoryItems(InventoryItems items)
        {
            _inventoryItems.Add(items.ItemName, items);
            return items;
        }

        public Dictionary<string, InventoryItems> GetInvertoryItems()
        {
            return _inventoryItems;
        }
    }
}
