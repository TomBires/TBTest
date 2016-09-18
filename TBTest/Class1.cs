using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBTest
{
    public interface IValuationResult
    {
        double _CurrentValue { get; set; }
        double _InceptionToDatePnL { get; set; }
        double _CurrentDayPnL { get; set; }
    }

    public class ValuationResult : IValuationResult
    {
        protected double currentValue;
        protected double inceptionToDatePnL;
        protected double currentDayPnL;

        public double _CurrentValue { get; set; }
        public double _InceptionToDatePnL { get; set; }
        public double _CurrentDayPnL { get; set; }
    }
}
