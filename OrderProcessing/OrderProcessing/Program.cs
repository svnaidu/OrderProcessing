using BusinessRules.Interfaces;
using BusinessRules.OrdersProcessingFactories;
using System;

namespace OrderProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"physicalProduct : {Program.ProcessOrder("physicalProduct")}");
            Console.WriteLine($"Book : {Program.ProcessOrder("Book")}");
            Console.WriteLine($"membership : {Program.ProcessOrder("membership")}");
            Console.WriteLine($"upgradeToMembership : {Program.ProcessOrder("upgradeToMembership")}");
            Console.WriteLine($"Learning to Ski : {Program.ProcessOrder("Learning to Ski")}");
        }
        private static string ProcessOrder(string orderType)
        {
            OrderProcessingFactory orderProcessingFactory = new ConcreteOrderProcessingFactory();
            Iorder order = orderProcessingFactory.getOrderDetails(orderType);
            return order.ProcessOrder();
        }
    }
}
