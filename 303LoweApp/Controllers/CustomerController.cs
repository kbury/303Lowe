using _303LoweApp.Data;
using _303LoweApp.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace _303LoweApp.Controllers
{
    public class CustomerController : ApiController
    {
        [Route("getCustomers")]
        public IEnumerable<Customer> GetCustomers()
        {
            return TestData.Customers;
        }
    }
}
