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
            //^ will now hold all the data coming the ioc container because we made it equal.
        }
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
            if(model is null)
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
            return true;
        }

        public async Task<bool> DeleteCustomerDetailsAsync(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if(customer is null)
            {
                return false;
            }
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return true;
        }
    }