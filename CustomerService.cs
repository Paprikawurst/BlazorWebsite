using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebsite.Pages
{
    public class CustomerService : ICustomerService
    {
        private List<Customer> customers;

        public string Uid { get; set; }
        public CustomerService()
        {
            Uid = Guid.NewGuid().ToString();

            customers = new List<Customer>()
            {
                new Customer {Id = 1, Name = "John" },
                new Customer {Id = 2, Name = "Peter" },
                new Customer {Id = 3, Name = "Sarah" }
            };
        }

        public Customer GetCustomerById(int id)
        {
            return customers.FirstOrDefault(c => c.Id == id);
        }

    }
}
