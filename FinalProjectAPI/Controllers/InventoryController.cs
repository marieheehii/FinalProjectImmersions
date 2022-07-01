// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;

// [Route("[controller]")]
// public class InventoryController : ControllerBase
// {
//     private readonly IInventoryService inventoryService;

//     public InventoryController(IInventoryService inventoryService)
//     {
//         this.inventoryService = inventoryService;
//     }

//     // [HttpPost("Register")]
//     // public async Task<IActionResutlt> RegisterInventory([FromBody] InventoryRegister model)
//     // {
//     //     if (!ModelState.IsValid)
//     //     {
//     //         return BadRequest(ModelState);
//     //     }
//     //     var registerResult = await _service.CreateInventoryItemAsyc(model);
//     //     if (registerResult)
//     //     {
//     //         return OK("Inventory was registered");
//     //     }
//     //     return BadRequest("Inventory could not be registered");
//     // }


//     [HttpGet]
//     public async Task<IActionResult> GetAllInventoryItems()
//     {
//         var customers = inventoryService.GetInventoryListItemsAsync();
//         return Ok(customers);
//     }

//     public async Task<IActionResult> UpdateInventory([FromForm] InventoryUpdate model, [FromRoute] int id)
//     {
//         var oldInventory = await inventoryService.FindAsync(id);
//         if (oldInventory == null)
//         {
//             return NotFound();
//         }
//         if (!ModelState.IsValid)
//         {
//             return BadRequest();
//         }
//         oldInventory.ItemsName = model.ItemsName;
//         oldInventory.Amount = model.Amount;
//         oldInventory.Category = model.Category;
//         oldInventory.ExpirationDate = model.ExpirationDate;

//         await _context.SaveChangesAsync();
//         return Ok("Your inventory has been updated");
//     }
//     [HttpDelete]
//     [Route("{id}")]
//     public async Task<IActionResult> DeleteInventory([FromRoute] int id)
//     {
//         var items = await _context.Inventory.FindAsync(id);
//         if (items == null)
//         {
//             return NotFound();
//         }
//         _context.items.Remove(items);
//         await _context.SaveChangesAsync();
//         return Ok("items was Deleted");
//     }
// }
