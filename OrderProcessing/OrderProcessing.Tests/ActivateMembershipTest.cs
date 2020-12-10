using BusinessRules;
using BusinessRules.Interfaces;
using BusinessRules.OrdersProcessingFactories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace OrderProcessing.Tests
{
    public class ActivateMembershipTest
    {
        private ConcreteOrderProcessingFactory _orderProcessingFactory;

        public ActivateMembershipTest()
        {
            _orderProcessingFactory = new ConcreteOrderProcessingFactory();
        }

        [Theory(DisplayName = "activates Membership")]
        [InlineData("membership")]
        public void ActivatesMembershipTest(string orderType)
        {
            // Arrange

            // Act
            Iorder order = _orderProcessingFactory.getOrderDetails(orderType);

            // Assert
            Assert.True(order.GetType() == typeof(ActivateMemvership));
            Assert.Equal("activate the membership", order.ProcessOrder());
        }
    }
}
