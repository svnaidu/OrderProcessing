using BusinessRules.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRules
{
   public class LearningToSki : Iorder
    {
        public string ProcessOrder()
        {
            PackingSlip packingSlip = new PackingSlip();
            return packingSlip.GeneratePackingSlip(true);
        }
    }
}
