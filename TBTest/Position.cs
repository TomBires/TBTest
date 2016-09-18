using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBTest
{
    // The Position Interface represents a trader's position in a security
    public interface IPosition
    {
        ISecurity _SecurityHeld { get; set; } 
        double _PurchasePrice { get; set; }
        DateTime _PurchaseDate { get; set; }
        double _Quantity { get; set; }
        int _TraderID { get; set; }
        double _PositionValue { get; set; }

    }

    public class TradingPosition : IPosition
    {
        protected ISecurity securityHeld;
        protected string securityName;
        protected int securityID;
        protected double purchasePrice;
        protected DateTime purchaseDate;
        protected double quantity;
        protected int traderID;
        protected double positionValue;

        protected double priorClosePrice;
        protected double inceptionToDatePnL;
        protected double currentDayPnL;

        public ISecurity _SecurityHeld { get; set; }
        public double _PurchasePrice { get; set; }
        public DateTime _PurchaseDate { get; set; }
        public double _Quantity { get; set; }
        public int _TraderID { get; set; }
        public double _PositionValue { get; set; }
        public double _PriorClosePrice { get; set; }        
        public double _InceptionToDatePnL { get; set; }
        public double _CurrentDayPnL { get; set; }

        public TradingPosition()
        {
            _SecurityHeld = new EquitySecurity();
            _PurchasePrice = 0.0;
            _PurchaseDate = new DateTime (2016, 1, 1);
            _Quantity = 0.0;
            _TraderID = 0;
            _PositionValue = 0.0;
            _PriorClosePrice = 0.0;
        }

        public TradingPosition(ISecurity pSecurityHeld, double pPurchasePrice, DateTime pPurchaseDate, 
            double pQuantity, int pTraderID, double pPriorClosePrice)
        {
            _SecurityHeld = pSecurityHeld;
            _PurchasePrice = pPurchasePrice;
            _PurchaseDate = pPurchaseDate;
            _Quantity = pQuantity;
            _TraderID = pTraderID;
            _PositionValue = 0.0;
            _PriorClosePrice = pPriorClosePrice;
        }

        public void ValuePosition(IMarketDataManager pIMarketDataManager)
        {
            _PositionValue = _SecurityHeld.CalculateValue(pIMarketDataManager) * _Quantity;
            _InceptionToDatePnL = _PositionValue - (_SecurityHeld.CalculateValueFromPrice(_PurchasePrice) * _Quantity);
            _CurrentDayPnL = _PositionValue - (_SecurityHeld.CalculateValueFromPrice(_PriorClosePrice) * _Quantity);
        }

    }  //end public class TradingPosition : IPosition

}
