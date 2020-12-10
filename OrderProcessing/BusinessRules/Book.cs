using BusinessRules.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRules
{
    public class Book : Iorder
    {
        public string ProcessOrder()
        {
            IcommissionOrders commissionOrders = new CommissionOrders();
            commissionOrders.GenerateCommissionPayment();
            return "duplicate packing slip for the royalty department";
        }
    }
}
