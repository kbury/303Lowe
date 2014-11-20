using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _303LoweApp.Models
{
    public class Transaction
    {
        public int id;
        public int customerId;
        public int statusId;
        public DateTime createDate;
        public DateTime modifiedDate;

        public Transaction(int id, int customerId, int statusId, DateTime createDate, DateTime modifiedDate)
        {
            // TODO: Complete member initialization
            this.id = id;
            this.customerId = customerId;
            this.statusId = statusId;
            this.createDate = createDate;
            this.modifiedDate = modifiedDate;
        }
    }
}
