using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TBTest
{
    /// <summary>
    /// This class imports and holds the positions
    /// 
    /// </summary>
    class PortfolioManager
    {
        Array _thePositionArray;
        int _positionCount = 0;

        public PortfolioManager (int pCount)
        {
            _thePositionArray = Array.CreateInstance(typeof(TradingPosition), pCount);
        }

        /// <summary>
        /// Here we import the positions from the .xml file and return a vector of tickers
        /// </summary>
        /// <returns></returns>
        public string [] ImportPortfolio ()
        {
            _positionCount = 0;

            // Here we import the portfolio data from storage
            XmlDocument doc = new XmlDocument();
            doc.Load(@"TestPositions.xml");
            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/PositionCollection/Position");

            foreach (XmlNode node in nodes)
            {
                TradingPosition theXMLTradingPosition = new TradingPosition();
                ISecurity theEquitySecurity = new EquitySecurity();

                theEquitySecurity._SecurityName = node.SelectSingleNode("securityName").InnerText;
                theEquitySecurity._SecurityID = Convert.ToInt32(node.SelectSingleNode("securityID").InnerText);
                theEquitySecurity._Ticker = node.SelectSingleNode("ticker").InnerText;

                theXMLTradingPosition._PurchasePrice = Convert.ToDouble (node.SelectSingleNode("purchasePrice").InnerText);
                theXMLTradingPosition._TraderID = Convert.ToInt32(node.SelectSingleNode("traderID").InnerText);
                theXMLTradingPosition._PriorClosePrice = Convert.ToDouble (node.SelectSingleNode("priorClosePrice").InnerText);
                theXMLTradingPosition._Quantity = Convert.ToDouble(node.SelectSingleNode("quantity").InnerText);

                theXMLTradingPosition._SecurityHeld = theEquitySecurity;

                _thePositionArray.SetValue(theXMLTradingPosition, _positionCount);
                _positionCount++;
            }

            string[] theTickerVector = new string[_positionCount];
            for (int i = 0; i < _positionCount; i++)
            {
                theTickerVector[i] = ((TradingPosition)(_thePositionArray.GetValue(i)))._SecurityHeld._Ticker;
            }

            return theTickerVector;
        }

        public IValuationResult ValuePortfolio(IMarketDataManager pIMarketDataManager)
        {
            double thePortfolioValue = 0;
            double theInceptionToDatePnL = 0;
            double theCurrentDayPnL = 0;

            foreach (TradingPosition aTradingPosition in _thePositionArray)
            {
                if (aTradingPosition != null)
                {
                    aTradingPosition.ValuePosition(pIMarketDataManager);
                    thePortfolioValue = thePortfolioValue + aTradingPosition._PositionValue;
                    theInceptionToDatePnL = theInceptionToDatePnL + aTradingPosition._InceptionToDatePnL;
                    theCurrentDayPnL = theCurrentDayPnL + aTradingPosition._CurrentDayPnL;
                }
            }

            ValuationResult theValuationResult = new ValuationResult();
            theValuationResult._CurrentValue = thePortfolioValue;
            theValuationResult._InceptionToDatePnL = theInceptionToDatePnL;
            theValuationResult._CurrentDayPnL = theCurrentDayPnL;

            return theValuationResult;
        }

    }
}
