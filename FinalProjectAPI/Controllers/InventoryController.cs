using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;


    [Route("[controller]")]
    [ApiController]

    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _service;

        public InventoryController(IInventoryService service)
        {
            _service = service;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterInventory([FromBody] KitchenInventoryModel model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var registerResult = await _service.CreateInventoryItemAsyc(model);
            if (registerResult)
            {
                return Ok("Inventory was registered");
            }
            return BadRequest("Inventory could not be registered");
        }
        

        [HttpGet]
        public async Task<IActionResult> GetAllInventoryItems()
        {
            var customers = _service.GetInventoryListItemsAsync();
            return Ok(customers);
        }

        public async Task<IActionResult> UpdateInventory([FromBody] InventoryUpdate request)
    {
        if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return await _service.UpdateInventoryAsync(request)
            ? Ok($"Inventory was successfully updated.")
            : BadRequest($"Item could not be updated.");
    }
    [HttpDelete]
    [Route("{inventoryId:int}")]
    public async Task<IActionResult> DeleteInventory([FromRoute] int id)
    {
        return await _service.DeleteInventoryItemAsync(id)
        ? Ok($"Item {id} was deleted from your inventory successfully.")
        : BadRequest($"Item {id} could not be deleted.");
    }
    }
