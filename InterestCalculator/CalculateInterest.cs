using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterestCalculator
{
    class CalculateInterest
    {
        private double _principal;
        private double _time;
        private double _rate;       

        public CalculateInterest(double principal, double time, double rate)
        {
            this._principal = principal;
            this._time = time;
            this._rate = rate;
        }


        public double principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        public double time
        {
            get { return this._time; }
            set { this._time = value; }
        }

        public double rate
        {
            get { return this._rate; }
            set { this._rate = value; }
        }

        public double getInterest()
        {

            return (this._principal * this._time * this._rate) / 100.00;
        }

    }
}
