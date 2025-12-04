using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolationApp.Domain
{
    internal class FixedDeposit
    {
        private int _accno;
        private string _name;
        private double _principal;
        private int _duration;
        private FestivalOptions _festivalOptions;

        public FixedDeposit(int accno, string name, double principal, 
            int duration,FestivalOptions festivalOptions)
        { 
        
            _accno = accno;
            _name = name;
            _principal = principal;
            _duration = duration;
            _festivalOptions = festivalOptions;
        }

        private double CalculateRate() {

            
            if (_festivalOptions == FestivalOptions.NewYear)
                return 0.08;//complex policy calculation

            if (_festivalOptions == FestivalOptions.Christmas)
                return 0.09;

           return .07; //Normal account  opening
        }

        public double SimpleInterest {

            get
            {
                return _principal * _duration * CalculateRate();
            }
        }
        

    }
}
