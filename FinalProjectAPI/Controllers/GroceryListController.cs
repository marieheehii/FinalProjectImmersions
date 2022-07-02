 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Threading.Tasks;


    [Route("[controller]")]
     public class GroceryListController : ControllerBase
     {
         private readonly GListService listService;

         public ListController(GListService listService)
         {
             this.listService = listService;
         }

          [HttpPost("Register")]
          public async Task<IActionResult> RegisterList([FromBody] int id)
          {
              if (model is valid)
              {
                  return BadRequest(Errand);
              }
              var registerResult = await _service.CreateListItemAsync(errand);
              if (registerResult)
              {
                  return OK("List was Created");
              }
              return BadRequest("List could not be registered");
        } 

         [HttpGet]
         public async Task<IActionResult> GetAllListItems()
         {
             var list = await List.GetAllListItemsAsync(id);
             return Ok(list);
         }

         public async Task<IActionResult> UpdateList([FromForm] ListUpdate model, [FromRoute] int id)
         {
             var oldList = await _service.List.FindAsync(id);
             if (oldList == null)
             {
                 return NotFound();
             }
             if (model is valid)
             {
                 return BadRequest();
             }
            
         }



     }

