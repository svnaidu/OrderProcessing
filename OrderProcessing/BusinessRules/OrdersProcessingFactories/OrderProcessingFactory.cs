using BusinessRules.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRules.OrdersProcessingFactories
{
    public abstract class OrderProcessingFactory
    {
        public abstract Iorder getOrderDetails(string orderType);
    }
}
