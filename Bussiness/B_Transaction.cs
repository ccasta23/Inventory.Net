using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DataAccess;

namespace Bussiness
{
    public class B_Transaction
    {
        public static void CreateTransaction(TransactionEntity oTransaction)
        {
            using (var db = new InventoryContext())
            {
                db.Transactions.Add(oTransaction);
                db.SaveChanges();
            }
        }
    }
}
