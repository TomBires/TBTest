namespace TBTest
{
    partial class PortfolioTracking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortfolioTracking));
            this.txtPortfolioValue = new System.Windows.Forms.TextBox();
            this.btnValuePortfolio = new System.Windows.Forms.Button();
            this.txtCurrentDayPnL = new System.Windows.Forms.TextBox();
            this.txtInceptionToDatePnl = new System.Windows.Forms.TextBox();
            this.InceptionToDatePnLLabel = new System.Windows.Forms.Label();
            this.CurrentDatPnLLabel = new System.Windows.Forms.Label();
            this.CurrentPortfolioValueLabel = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtPortfolioValue
            // 
            this.txtPortfolioValue.Location = new System.Drawing.Point(477, 301);
            this.txtPortfolioValue.Name = "txtPortfolioValue";
            this.txtPortfolioValue.Size = new System.Drawing.Size(126, 20);
            this.txtPortfolioValue.TabIndex = 0;
            // 
            // btnValuePortfolio
            // 
            this.btnValuePortfolio.Location = new System.Drawing.Point(54, 301);
            this.btnValuePortfolio.Name = "btnValuePortfolio";
            this.btnValuePortfolio.Size = new System.Drawing.Size(116, 23);
            this.btnValuePortfolio.TabIndex = 1;
            this.btnValuePortfolio.Text = "Value Portfolio";
            this.btnValuePortfolio.UseVisualStyleBackColor = true;
            this.btnValuePortfolio.Click += new System.EventHandler(this.btnValuePortfolio_Click);
            // 
            // txtCurrentDayPnL
            // 
            this.txtCurrentDayPnL.Location = new System.Drawing.Point(334, 301);
            this.txtCurrentDayPnL.Name = "txtCurrentDayPnL";
            this.txtCurrentDayPnL.Size = new System.Drawing.Size(117, 20);
            this.txtCurrentDayPnL.TabIndex = 2;
            // 
            // txtInceptionToDatePnl
            // 
            this.txtInceptionToDatePnl.Location = new System.Drawing.Point(191, 301);
            this.txtInceptionToDatePnl.Name = "txtInceptionToDatePnl";
            this.txtInceptionToDatePnl.Size = new System.Drawing.Size(121, 20);
            this.txtInceptionToDatePnl.TabIndex = 3;
            // 
            // InceptionToDatePnLLabel
            // 
            this.InceptionToDatePnLLabel.AutoSize = true;
            this.InceptionToDatePnLLabel.Location = new System.Drawing.Point(188, 254);
            this.InceptionToDatePnLLabel.Name = "InceptionToDatePnLLabel";
            this.InceptionToDatePnLLabel.Size = new System.Drawing.Size(114, 13);
            this.InceptionToDatePnLLabel.TabIndex = 4;
            this.InceptionToDatePnLLabel.Text = "Inception To Date P/L";
            // 
            // CurrentDatPnLLabel
            // 
            this.CurrentDatPnLLabel.AutoSize = true;
            this.CurrentDatPnLLabel.Location = new System.Drawing.Point(331, 254);
            this.CurrentDatPnLLabel.Name = "CurrentDatPnLLabel";
            this.CurrentDatPnLLabel.Size = new System.Drawing.Size(84, 13);
            this.CurrentDatPnLLabel.TabIndex = 5;
            this.CurrentDatPnLLabel.Text = "Current Day P/L";
            // 
            // CurrentPortfolioValueLabel
            // 
            this.CurrentPortfolioValueLabel.AutoSize = true;
            this.CurrentPortfolioValueLabel.Location = new System.Drawing.Point(474, 254);
            this.CurrentPortfolioValueLabel.Name = "CurrentPortfolioValueLabel";
            this.CurrentPortfolioValueLabel.Size = new System.Drawing.Size(112, 13);
            this.CurrentPortfolioValueLabel.TabIndex = 6;
            this.CurrentPortfolioValueLabel.Text = "Current Portfolio Value";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(528, 357);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(54, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(549, 195);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // PortfolioTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 411);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.CurrentPortfolioValueLabel);
            this.Controls.Add(this.CurrentDatPnLLabel);
            this.Controls.Add(this.InceptionToDatePnLLabel);
            this.Controls.Add(this.txtInceptionToDatePnl);
            this.Controls.Add(this.txtCurrentDayPnL);
            this.Controls.Add(this.btnValuePortfolio);
            this.Controls.Add(this.txtPortfolioValue);
            this.Name = "PortfolioTracking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portfolio Valuation and Tracking";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPortfolioValue;
        private System.Windows.Forms.Button btnValuePortfolio;
        private System.Windows.Forms.TextBox txtCurrentDayPnL;
        private System.Windows.Forms.TextBox txtInceptionToDatePnl;
        private System.Windows.Forms.Label InceptionToDatePnLLabel;
        private System.Windows.Forms.Label CurrentDatPnLLabel;
        private System.Windows.Forms.Label CurrentPortfolioValueLabel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox richTextBox1;

    }
}

