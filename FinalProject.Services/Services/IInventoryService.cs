using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public interface IInventoryService
    {
        Task<bool> CreateInventoryItemAsyc(KitchenInventoryModel model);
        Task<IEnumerable<InventoryListItem>> GetInventoryListItemsAsync();
        Task<bool> UpdateInventoryAsync(InventoryUpdate request);
        Task<bool> DeleteInventoryItemAsync(int itemId);
        Task<KitchenInventoryModel> GetInventoryByIdAsync(int id);
    }
