using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using Microsoft.EntityFrameworkCore;

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
            _context.Items.Add(item);
            var numberOfChanges = await _context.SaveChangesAsync();
            return numberOfChanges == 1;
        }

        public async Task<IEnumerable<InventoryListItem>> GetInventoryListItemsAsync()
        {
            var items = await _context.Items
            .Select(entity => new InventoryListItem
            {
                ID = entity.ID,
                ItemsName = entity.ItemsName,
                ExpirationDate = entity.ExpirationDate
            })
            .ToListAsync();
        return items;
        }
        public async Task<bool> UpdateInventoryAsync(InventoryUpdate request)
        {
            var inventoryEntity = await _context.Items.FindAsync(request.ID);
            if(inventoryEntity != null)
            {
                inventoryEntity.ItemsName = request.ItemsName;
                inventoryEntity.Amount = request.Amount;
                inventoryEntity.Category = request.Category;
                inventoryEntity.ExpirationDate = request.ExpirationDate;

                var numberOfChanges = await _context.SaveChangesAsync();
                return numberOfChanges == 1;
            }
            return false;
        }
        public async Task<bool> DeleteInventoryItemAsync(int itemId)
        {
            var inventoryEntity = await _context.Items.FindAsync(itemId);
            if(itemId != null)
            {
                _context.Items.Remove(inventoryEntity);
                return await _context.SaveChangesAsync() ==1;
            }
            return false;
        }




    }
