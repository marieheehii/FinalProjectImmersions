using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class CustomerServices : ICustomerService
    {
        private readonly ApplicationDbContext _context;
        public CustomerServices(ApplicationDbContext context)
        {
            _context = context;
        }
        private readonly int _customerID;

        public async Task<IEnumerable<CustomerListItem>> GetCustomerListItemsAsync()
        {
            var customers = await _context.Customers
            .Select(entity => new CustomerListItem
            {
                Id = entity.Id,
                FirstName = entity.FirstName
            })
            .ToListAsync();
            return customers;
        }

        public async Task<bool> CreateCustomerAsync(CustomerModel model)
        {
            // What if the user passes in empty data?
            if (model is null)
            {
                return false;
            }
            var customer = new Customer
            {
                FirstName = model.FirstName,
                LastName = model.LastName, 
            };

            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            //This is ^ required for the database
            return true;
        }

        public async Task<bool> DeleteCustomerDetailsAsync(int id)
       // Returning a bool, in simplicity 
        {
            Customer customer = await _context.Customers.FindAsync(id);
            //An '=' is the declaration, therefore treat it as 'law'
            //Everything on the right is passed in its entirety to the variable on the left
             if (customer is null)
             {
                 return false;
             }
             else
             {
                 _context.Customers.Remove(customer);
                 return true;
             }
        }
    }