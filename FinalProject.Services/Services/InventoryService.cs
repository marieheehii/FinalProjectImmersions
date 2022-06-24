using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class InventoryService : IInventoryService
{
    private readonly ApplicationDbContext _context;


    public async Task<bool> CreateInventoryItemAsyc(KitchenInventoryModel model)
    {
        var item = new KitchenInventory
        {
            ItemsName = model.ItemsName,
            Amount = model.Amount,
            Category = model.Category,
            ExpirationDate = model.ExpirationDate

        };
        //_context.Items.Add(item);
        var numberOfChanges = await _context.SaveChangesAsync();
        return numberOfChanges == 1;
    }


}
