﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvertoryServices.Models;

namespace InvertoryServices.Services
{
   public interface IInventoryServices
    {
        InventoryItems AddInventoryItems(InventoryItems items);
        Dictionary<string, InventoryItems> GetInvertoryItems();
    }
}
