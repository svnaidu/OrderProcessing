using BusinessRules.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRules
{
    public class InvalidOrder : Iorder
    {
        public string ProcessOrder()
        {
            return "Invalid Order";
        }
    }
}
