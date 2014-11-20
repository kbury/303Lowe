using _303LoweApp.Data;
using _303LoweApp.Models;
using System.Collections.Generic;
using System.Web.Http;
using System.Linq;

namespace _303LoweApp.Controllers
{
    public class TransactionController : ApiController
    {
        [Route("getTransactions/{customerId}")]
        public IEnumerable<Transaction> GetTransactions(int customerId)
        {
            return TestData.Transactions.Where(t => t.customerId == customerId);
        }
    }
}
