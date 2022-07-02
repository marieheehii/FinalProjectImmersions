using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class GroceryListService : IGroceryListService
    {
     private readonly ApplicationDbContext _context;
     public GroceryListService(ApplicationDbContext context)
     {
         _context = context;
     }   

     public async Task<IEnumerable<CustomerListItem>> UpdateListAsync()
     {
         var list = _context.GroceryLists
         .Select(entity => new CustomerListItem
         {
             Id = entity.ID,
             FirstName = entity.FirstName
         });
         return list;
     }

    public async Task<bool> CreateListAsync(CustomerModel model)
    {
        if (model is null)
        {
            return false;
        }
        var list = new GroceryList
        {
            ItemName = model.ItemName,
            FirstName = model.FirstName,
            LastName = model.LastName
        };
        _context.GroceryLists.Add(list);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteListDetailsAsync(int id)
    {
        var list = await _context.GroceryLists.FindAsync(id);
        if(list is null)
        {
            return false;
        }
        _context.GroceryLists.Remove(list);
        await _context.SaveChangesAsync();
        return true;
    }

    }