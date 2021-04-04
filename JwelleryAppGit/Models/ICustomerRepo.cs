using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwelleryApp.Models
{
    public interface ICustomerRepo
    {
       IEnumerable<Customer> GetAllcustomers();
        Customer GetCustomer(CustomerDTO customerDTO);
    }
}
