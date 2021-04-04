using JwelleryApp.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwelleryApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors("AllowOrigin")]
    public class HomeController : ControllerBase
    {
        private readonly ICustomerRepo _customerRepo;

        public HomeController(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetCustomerdetails()
        {
            return _customerRepo.GetAllcustomers().ToList();
        }

        [HttpPost("Login")]
        public ActionResult<Customer> Login(CustomerDTO customerDTO)
        {
            var customer = _customerRepo.GetCustomer(customerDTO);
            if (customer != null && customer.Password == customerDTO.Password)
                return customer;
            else
                return Unauthorized("Invalid user");
        }
    }
}
