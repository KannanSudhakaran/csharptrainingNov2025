using OcpBankCoreLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldBankApp.FestivalPolicies
{
    internal class NewYearFestivalPolicy : IRateCalculationPolicy
    {
        public double CalculateRate()
        {
            return 0.08;
        }
    }
}
