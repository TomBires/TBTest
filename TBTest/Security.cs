using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBTest
{
    /// <summary>
    /// This interface represents the basic structure of a security from which securities classes will be derived
    /// </summary>
    public interface ISecurity
    {
        string _SecurityName { get; set; }
        string _Ticker { get; set; }
        int _SecurityID { get; set; }

        double CalculateValue(IMarketDataManager pIMarketDataManager);
        double CalculateValueFromPrice(double pPrice);
    }


    /// <summary>
    /// The EquitySecurity class represents an equity security which pays a dividend at the "dividendRate".
    /// </summary>
    public class EquitySecurity : ISecurity
    {
        /// <summary>
        /// The name of the security e.g. IBM
        /// </summary>
        protected string securityName;
        /// <summary>
        /// The security's ticker symbol
        /// </summary>
        protected string ticker;
        /// <summary>
        /// The internal unique (database) id for this security
        /// </summary>
        protected int securityID;


        /// <summary>
        /// The beta correlation of this security's return relative to the market return
        /// </summary>
        protected double beta;
        /// <summary>
        /// The dividend rate paid by this equity security
        /// </summary>
        protected double dividendRate;

        public string _SecurityName { get; set; }
        public string _Ticker { get; set; }
        public int _SecurityID { get; set; }


        /// <summary>
        /// Constructor
        /// </summary>
        public EquitySecurity()
        {
            _SecurityName = "";
            _Ticker = "";
            _SecurityID = 0;
            beta = 0.0;
            dividendRate = 0.0;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pTicker"></param>
        /// <param name="pId"></param>
        /// <param name="pBeta"></param>
        public EquitySecurity(string pSecurityName, string pTicker, int pId, double pBeta, double pDividendRate)
        {
            _SecurityName = pSecurityName;
            _Ticker = pTicker;
            _SecurityID = pId;
            beta = pBeta;
            dividendRate = pDividendRate;
        }

        /// <summary>
        /// This method calculates the value of this security
        /// </summary>
        /// <returns></returns>
        double ISecurity.CalculateValue(IMarketDataManager pIMarketDataManager)
        {
            // Calculate the value of this security
            double theValue = pIMarketDataManager.GetQuote(_Ticker);

            return theValue;
        }  // end     public class EquitySecurity : ISecurity

        double ISecurity.CalculateValueFromPrice(double pPrice)
        {
            return pPrice;
        }

    }
}
