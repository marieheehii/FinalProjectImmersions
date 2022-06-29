using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    //Make your contracts/rule first, like an outline.
    public interface ICustomerService
    {
        Task<bool> CreateCustomerAsync(CustomerModel model);
        Task<IEnumerable<CustomerListItem>> GetCustomerListItemsAsync();
        Task<bool> DeleteCustomerDetailsAsync(int id);
    }
