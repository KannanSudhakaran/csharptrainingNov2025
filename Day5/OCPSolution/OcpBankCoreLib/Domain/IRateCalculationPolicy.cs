using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpBankCoreLib.Domain
{
    public interface IRateCalculationPolicy
    {
        double CalculateRate();
    }
}
