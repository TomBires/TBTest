using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBTest
{
    public partial class PortfolioTracking : Form
    {
        PortfolioManager _thePortfolioManager = new PortfolioManager(TESTCOUNT);
        IMarketDataManager _theYahooMarketDataManager = new YahooMarketDataManager();
        private const int TESTCOUNT = 10;
        public PortfolioTracking()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Pre-load portfolio and market data
            string [] theTickerVector =_thePortfolioManager.ImportPortfolio();
            _theYahooMarketDataManager.ImportMarketData(theTickerVector);
        }

        private void btnValuePortfolio_Click(object sender, EventArgs e)
        {
            IValuationResult theValuationResult = new ValuationResult();

            // Value the portfolio with the pre-loaded market data.
            theValuationResult = (ValuationResult)_thePortfolioManager.ValuePortfolio(_theYahooMarketDataManager);

            txtPortfolioValue.Text = theValuationResult._CurrentValue.ToString();

            txtCurrentDayPnL.Text = theValuationResult._CurrentDayPnL.ToString();

            txtInceptionToDatePnl.Text = theValuationResult._InceptionToDatePnL.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
