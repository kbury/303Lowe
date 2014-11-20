using _303LoweApp.Models;
using System;
using System.Collections.Generic;

namespace _303LoweApp.Data
{
    public class TestData
    {
        public static IEnumerable<Customer> Customers = new List<Customer>() {
            new Customer(1, "John Doe"),
            new Customer(2, "Mary Poppins"),
            new Customer(3, "Andrew Johnson")
        };

        public static IEnumerable<Transaction> Transactions = new List<Transaction>() {
            new Transaction(1, 1, 1, new DateTime(2014, 11, 1), new DateTime(2014, 11, 10)),
            new Transaction(2, 1, 2, new DateTime(2014, 11, 3), new DateTime(2014, 11, 15)),
            new Transaction(3, 2, 1, new DateTime(2014, 11, 2), new DateTime(2014, 11, 11)),
            new Transaction(4, 2, 2, new DateTime(2014, 11, 3), new DateTime(2014, 11, 14)),
            new Transaction(5, 3, 2, new DateTime(2014, 11, 1), new DateTime(2014, 11, 1))
        };
    }
}