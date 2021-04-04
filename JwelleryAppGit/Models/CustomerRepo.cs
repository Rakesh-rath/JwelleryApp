using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JwelleryApp.Models
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly DataContext _Context;

        public CustomerRepo(DataContext Context)
        {
            this._Context = Context;
        }

        public IEnumerable<Customer> GetAllcustomers()
        {
            return this._Context.Customers.ToList();
        }

        public Customer GetCustomer(CustomerDTO customerDTO)
        {
            Customer customer = this._Context.Customers
                .FirstOrDefault(x => x.UserName == customerDTO.Username);
                return customer;
        }
    }
}
