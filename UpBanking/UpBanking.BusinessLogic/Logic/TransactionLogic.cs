using System;
using System.Collections.Generic;
using System.Text;
using UpBanking.BusinessLogic.DomainModel;

namespace UpBanking.BusinessLogic.Logic
{
    public class TransactionLogic
    {
        public Transaction GetNewTransaction()
        {
            var transaction2 = new Transaction("Butcher", 50);


            return transaction2;
        }
    }
}
