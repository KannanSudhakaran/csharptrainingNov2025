using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpBankCoreLib.Domain
{
    public class FixedDeposit
    {
        private int _accno;
        private string _name;
        private double _principal;
        private int _duration;
        private IRateCalculationPolicy _ratePolicy;//hasA

        public FixedDeposit(int accno, string name, double principal, 
            int duration, IRateCalculationPolicy ratePolicy)
        { 
        
            _accno = accno;
            _name = name;
            _principal = principal;
            _duration = duration;
            _ratePolicy = ratePolicy;
        }

    

        public double SimpleInterest {

            get
            {
                return _principal * _duration * _ratePolicy.CalculateRate();
            }
        }
        

    }
}
