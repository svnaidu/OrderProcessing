using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRules.Interfaces
{
    public interface IPackingSlip
    {
        string GeneratePackingSlip(bool isLearningToSki);
    }
}
