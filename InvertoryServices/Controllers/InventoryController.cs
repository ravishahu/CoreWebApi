using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InvertoryServices.Models;
using InvertoryServices.Services;
namespace InvertoryServices.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class InventoryController : ControllerBase
    {

        private readonly IInventoryServices _services;

        public InventoryController(IInventoryServices services)
        {
            _services = services;

        }

        [HttpPost]
        [Route("AddInventoryItems")]
        public ActionResult<InventoryItems> AddInventoryItems(InventoryItems items)
        {
            var intventoryItem = _services.AddInventoryItems(items);
            if (intventoryItem == null)
            {
                return NotFound();
            }
            return Ok(intventoryItem);
        }

        [HttpGet]
        [Route("GetInvertoryItems")]
        public ActionResult<Dictionary<string, InventoryItems>> GetInvertoryItems()
        {
            var invetoryItems = _services.GetInvertoryItems();
            if (invetoryItems == null)
            {
                return NotFound();
            }
            return Ok(invetoryItems);

        }
    }
}