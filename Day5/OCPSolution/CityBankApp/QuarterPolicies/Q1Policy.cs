using OcpBankCoreLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBankApp.QuarterPolicies
{
    internal class Q1Policy : IRateCalculationPolicy
    {
        public double CalculateRate()
        {
            return 0.09;
        }
    }
}
