using System;
using System.Collections.Generic;
using System.Text;

namespace UpBanking.BusinessLogic.DomainModel
{
    public class Transaction
    {
        public Transaction()
        {

        }

        public Transaction(string description, decimal value)
        {
            if (value < 0)
                throw new Exception("transaction cant be less than 0");
            Description = description;
            Value = value;
        }
        public string Description { get; set; }
        public decimal Value { get; set; }
    }
}
