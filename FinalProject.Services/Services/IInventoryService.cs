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
<<<<<<< HEAD
        Task<KitchenInventoryModel> GetInventoryByIdAsync(int id);
=======

        
>>>>>>> c87e0be6093190fd3fc9200baf51efbf98320eae
    }
