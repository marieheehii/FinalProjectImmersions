using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class CustomerService : ICustomerService
    {
        private readonly ApplicationDbContext _context;
        public CustomerServices(ApplicationDbContext context)
        {
            _context = context;
        }
        private readonly int _customerID;

        public async Task<IEnumerable<CustomerListItem>> GetCustomerListItemsAsync()
        {
            var customers = await _context.Characters
            .Select(entity => new CharacterListItem
            {
                Id = entity.ID,
                FirstName = entity.FirstName,
                LastName = entity.LastName
            })
            .ToListAsync();
            return customers;
        }

        public async Task<bool> CreateCustomerAsync(CustomerModel model)
        {
            var customer = new Character
            {
                FirstName = model.FirstName,
                LastName = model.LastName, 
            };

            _context.Customers.Add(customer);
        }

        public async Task<CustomerDelete> DeleteCustomerDetailsAsync(int id)
        {
            Console.Clear();
            Console.WriteLine("Please Enter the Customer's ID");
            int Input = int.Parse(Console.ReadLine());
            if (_context.DeleteCustomerDetailsAsync(userInput))
            {
                System.Console.WriteLine("Customer was Successfully Deleted");
            }
            else
            {
                System.Console.WriteLine("Sorry, Customer was not Deleted.");
            }
            PressAnyKeyToContinue();
        }
    }