using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace TBTest
{
    public interface IMarketDataManager
    {
        int ImportMarketData(string[] pTickerVector);
        double GetQuote(string pTicker);
    }  

    class YahooMarketDataManager : IMarketDataManager
    {
        public Dictionary<string, double> _SecurityQuotes = new Dictionary<string, double>();

        int IMarketDataManager.ImportMarketData(string [] pTickerVector)
        {
            int count = 0;
            double testPrice = 0.0;

            // Here we go out and get the market data and load it into the Dictoinary object: _SecurityQuotes
            for (int i = 0; i < pTickerVector.Length; i++ )
            {
                // Only pull quotes for tickers that you don't have, yet
                if (!_SecurityQuotes.TryGetValue(pTickerVector[i], out testPrice))
                {
                    PullQuotes(pTickerVector[i]);
                }
            }
            return count;
        }

        double IMarketDataManager.GetQuote (string pTicker)
        {
            double theQuote = 0.0;
            _SecurityQuotes.TryGetValue(pTicker, out theQuote);            

            return theQuote;
        }

        protected void PullQuotes (string pTicker)
        {
            // Build the URL.
            string url = pTicker; 
            if (url != "")
            {
                // Prepend the base URL.
                const string base_url =
                    "http://download.finance.yahoo.com/d/quotes.csv?s=@&f=sl1d1t1c1";
                url = base_url.Replace("@", url);

                // Get the response.
                try
                {
                    // Get the web response.
                    string result = GetWebResponse(url);

                    // Pull out the current prices.
                    string[] lines = result.Split(
                        new char[] { '\r', '\n' },
                        StringSplitOptions.RemoveEmptyEntries);
                    string theText = decimal.Parse(lines[0].Split(',')[1]).ToString();
                    _SecurityQuotes.Add(pTicker, Convert.ToDouble (theText));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private string GetWebResponse(string url)
        {
            // Make a WebClient.
            WebClient web_client = new WebClient();

            // Get the indicated URL.
            Stream response = web_client.OpenRead(url);

            // Read the result.
            using (StreamReader stream_reader = new StreamReader(response))
            {
                // Get the results.
                string result = stream_reader.ReadToEnd();

                // Close the stream reader and its underlying stream.
                stream_reader.Close();

                // Return the result.
                return result;
            }
        }

    }  // end class XMLMarketDataManager : IMarketDAtaManager
}
