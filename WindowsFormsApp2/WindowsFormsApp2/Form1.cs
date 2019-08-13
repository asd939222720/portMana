using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _homework5;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        PmanagementContainer cl = new PmanagementContainer();
        public Form1()
        {
            InitializeComponent();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            ListViewItem i = new ListViewItem();
            int t = listView1.SelectedItems.Count;
            int[] looping = new int[t];
            for (int k = 0; k < t; k++)
            {
                looping[k] = listView1.SelectedIndices[k];
            }
            double a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, a6 = 0;
            foreach (int k in looping)
            {
                a1 = a1 + Convert.ToDouble(listView1.Items[k].SubItems[7].Text);
                a2 = a2 + Convert.ToDouble(listView1.Items[k].SubItems[8].Text);
                a3 = a3 + Convert.ToDouble(listView1.Items[k].SubItems[9].Text);
                a4 = a4 + Convert.ToDouble(listView1.Items[k].SubItems[10].Text);
                a5 = a5 + Convert.ToDouble(listView1.Items[k].SubItems[11].Text);
                a6 = a6 + Convert.ToDouble(listView1.Items[k].SubItems[12].Text);
            }
            i.Text = a1.ToString();
            i.SubItems.Add(a2.ToString());
            i.SubItems.Add(a3.ToString());
            i.SubItems.Add(a4.ToString());
            i.SubItems.Add(a5.ToString());
            i.SubItems.Add(a6.ToString());

            listView2.Items.Add(i);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'changlinfinalDataSet.InterestRates' table. You can move, or remove it, as needed.
            this.interestRatesTableAdapter.Fill(this.changlinfinalDataSet.InterestRates);

        }

        private void historyPRiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewHistoryPrice formHisPrice = new NewHistoryPrice();
            formHisPrice.ShowDialog();
        }

        private void instTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewInstType formtyoe = new NewInstType();
            formtyoe.ShowDialog();
        }

        private void instmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewInstment formInstment = new NewInstment();
            formInstment.ShowDialog();
        }

        private void tradeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTrade formTrade = new NewTrade();
            formTrade.ShowDialog();
        }

        private void interestRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewInterestRate formNewRate = new NewInterestRate();
            formNewRate.ShowDialog();
        }

        private void interstRateAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterestRateAnalysis formInterestAnalysis = new InterestRateAnalysis();
            formInterestAnalysis.ShowDialog();
        }

        private void historicalPriceAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HisTradePrice formHisprice = new HisTradePrice();
            formHisprice.ShowDialog();

        }

        private void refreashTradeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshTrades();
        }
        private void RefreshTrades()
        {
            listView1.Items.Clear();
            ListViewItem i;
            foreach (Trade t in cl.Trades)
            {
                i = new ListViewItem();
                i.Text = t.Id.ToString();
                i.SubItems.Add(t.IsBuy ? "BUY" : "SELL");
                i.SubItems.Add(t.Quantity.ToString());
                i.SubItems.Add(t.Instruments.Ticker);
                i.SubItems.Add(t.Instruments.InstType.TypeName);
                i.SubItems.Add(t.Price.ToString());
                i.SubItems.Add("0");
                i.SubItems.Add("0");
                i.SubItems.Add("0");
                i.SubItems.Add("0");
                i.SubItems.Add("0");
                i.SubItems.Add("0");
                i.SubItems.Add("0");
                listView1.Items.Add(i);
            }
        }

        private void priceWithSimulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _homework5.Form1 a = new _homework5.Form1();
            double[] result1;
            listView1.Items.Clear();
            ListViewItem i;
            // For each trade do the following things.
            foreach (Trade t in cl.Trades)
            {
                i = new ListViewItem();
                i.Text = t.Id.ToString();
                i.SubItems.Add(t.IsBuy ? "BUY" : "SELL");
                i.SubItems.Add(t.Quantity.ToString());
                i.SubItems.Add(t.Instruments.Ticker);
                i.SubItems.Add(t.Instruments.InstType.TypeName);
                i.SubItems.Add(t.Price.ToString());

                // Check the Instrument type and do different things according to the inst type.
                if (t.Instruments.InstType.TypeName.ToUpper() == "STOCK")
                {
                    var qq = (from p in cl.Instruments
                              where p.Ticker == t.Instruments.Ticker
                              select p).First();
                    // Find out the Underlying price.
                    double S0 = qq.Prices.Last().ClosingPrice;
                    // Assign the values to other fields such as Market Price, P&L and Greeks and etc.
                    i.SubItems.Add(S0.ToString());
                    i.SubItems.Add(t.IsBuy ? ((S0 - t.Price) * t.Quantity).ToString() : ((t.Price - S0) * t.Quantity).ToString());
                    i.SubItems.Add(t.IsBuy ? (1.0 * t.Quantity).ToString() : (-1.0 * t.Quantity).ToString());
                    i.SubItems.Add("0");
                    i.SubItems.Add("0");
                    i.SubItems.Add("0");
                    i.SubItems.Add("0");
                    listView1.Items.Add(i);
                }
                else if (t.Instruments.InstType.TypeName == "EourpeanOption")
               
                {
                    var qq = (from p in cl.Instruments
                              where p.Ticker == t.Instruments.Underlying
                              select p).First();
                    double S0 = qq.Prices.Last().ClosingPrice;

                    // For options, use the MC_Simulator to get back the market price and all the greeks, then assign them accordingly.
                    result1 = a.Geteou( S0, Convert.ToDouble(t.Instruments.Strick), 0.05 , Convert.ToDouble(t.Instruments.Tenor), Convert.ToDouble(VolMain.Text));
                    if (t.Instruments.Iscall==true)
                    {


                        i.SubItems.Add(result1[0].ToString());
                        i.SubItems.Add(t.IsBuy ? ((result1[0] - t.Price) * t.Quantity).ToString() : ((t.Price - result1[0]) * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[1] * t.Quantity).ToString() : (-1 * result1[1] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[2] * t.Quantity).ToString() : (-1 * result1[2] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[3] * t.Quantity).ToString() : (-1 * result1[3] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[4] * t.Quantity).ToString() : (-1 * result1[4] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[5] * t.Quantity).ToString() : (-1 * result1[5] * t.Quantity).ToString());
                    }
                    else
                    {
                        i.SubItems.Add(result1[6].ToString());
                        i.SubItems.Add(t.IsBuy ? ((result1[6] - t.Price) * t.Quantity).ToString() : ((t.Price - result1[6]) * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[7] * t.Quantity).ToString() : (-1 * result1[7] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[8] * t.Quantity).ToString() : (-1 * result1[8] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[9] * t.Quantity).ToString() : (-1 * result1[9] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[10] * t.Quantity).ToString() : (-1 * result1[10] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[11] * t.Quantity).ToString() : (-1 * result1[11] * t.Quantity).ToString());
                    }
                    listView1.Items.Add(i);
                }
                else if (t.Instruments.InstType.TypeName == "AsianOption")
                {
                    var qq = (from p in cl.Instruments
                              where p.Ticker == t.Instruments.Underlying
                              select p).First();
                    double S0 = qq.Prices.Last().ClosingPrice;

                    // For options, use the MC_Simulator to get back the market price and all the greeks, then assign them accordingly.
                    result1 = a.GetAsian(S0, Convert.ToDouble(t.Instruments.Strick), 0.05, Convert.ToDouble(t.Instruments.Tenor), Convert.ToDouble(VolMain.Text));
                    if (t.Instruments.Iscall == true)
                    {


                        i.SubItems.Add(result1[0].ToString());
                        i.SubItems.Add(t.IsBuy ? ((result1[0] - t.Price) * t.Quantity).ToString() : ((t.Price - result1[0]) * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[1] * t.Quantity).ToString() : (-1 * result1[1] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[2] * t.Quantity).ToString() : (-1 * result1[2] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[3] * t.Quantity).ToString() : (-1 * result1[3] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[4] * t.Quantity).ToString() : (-1 * result1[4] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[5] * t.Quantity).ToString() : (-1 * result1[5] * t.Quantity).ToString());
                    }
                    else
                    {
                        i.SubItems.Add(result1[6].ToString());
                        i.SubItems.Add(t.IsBuy ? ((result1[6] - t.Price) * t.Quantity).ToString() : ((t.Price - result1[6]) * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[7] * t.Quantity).ToString() : (-1 * result1[7] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[8] * t.Quantity).ToString() : (-1 * result1[8] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[9] * t.Quantity).ToString() : (-1 * result1[9] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[10] * t.Quantity).ToString() : (-1 * result1[10] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[11] * t.Quantity).ToString() : (-1 * result1[11] * t.Quantity).ToString());
                    }
                    listView1.Items.Add(i);
                }
                else if (t.Instruments.InstType.TypeName == "DigitalOption")
                {
                    var qq = (from p in cl.Instruments
                              where p.Ticker == t.Instruments.Underlying
                              select p).First();
                    double S0 = qq.Prices.Last().ClosingPrice;

                    // For options, use the MC_Simulator to get back the market price and all the greeks, then assign them accordingly.
                    result1 = a.GetDigital(S0, Convert.ToDouble(t.Instruments.Strick), 0.05, Convert.ToDouble(t.Instruments.Tenor), Convert.ToDouble(VolMain.Text),Convert.ToDouble(t.Instruments.Rebate));
                    if (t.Instruments.Iscall == true)
                    {


                        i.SubItems.Add(result1[0].ToString());
                        i.SubItems.Add(t.IsBuy ? ((result1[0] - t.Price) * t.Quantity).ToString() : ((t.Price - result1[0]) * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[1] * t.Quantity).ToString() : (-1 * result1[1] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[2] * t.Quantity).ToString() : (-1 * result1[2] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[3] * t.Quantity).ToString() : (-1 * result1[3] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[4] * t.Quantity).ToString() : (-1 * result1[4] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[5] * t.Quantity).ToString() : (-1 * result1[5] * t.Quantity).ToString());
                    }
                    else
                    {
                        i.SubItems.Add(result1[6].ToString());
                        i.SubItems.Add(t.IsBuy ? ((result1[6] - t.Price) * t.Quantity).ToString() : ((t.Price - result1[6]) * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[7] * t.Quantity).ToString() : (-1 * result1[7] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[8] * t.Quantity).ToString() : (-1 * result1[8] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[9] * t.Quantity).ToString() : (-1 * result1[9] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[10] * t.Quantity).ToString() : (-1 * result1[10] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[11] * t.Quantity).ToString() : (-1 * result1[11] * t.Quantity).ToString());
                    }
                    listView1.Items.Add(i);
                }
                else if (t.Instruments.InstType.TypeName == "BarrierOption")
                {
                    var qq = (from p in cl.Instruments
                              where p.Ticker == t.Instruments.Underlying
                              select p).First();
                    double S0 = qq.Prices.Last().ClosingPrice;

                    // For options, use the MC_Simulator to get back the market price and all the greeks, then assign them accordingly.
                    result1 = a.GetBarrier(S0, Convert.ToDouble(t.Instruments.Strick), 0.05, Convert.ToDouble(t.Instruments.Tenor), Convert.ToDouble(VolMain.Text), Convert.ToDouble(t.Instruments.Barrier),Convert.ToString(t.Instruments.BarrierType));
                    if (t.Instruments.Iscall == true)
                    {


                        i.SubItems.Add(result1[0].ToString());
                        i.SubItems.Add(t.IsBuy ? ((result1[0] - t.Price) * t.Quantity).ToString() : ((t.Price - result1[0]) * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[1] * t.Quantity).ToString() : (-1 * result1[1] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[2] * t.Quantity).ToString() : (-1 * result1[2] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[3] * t.Quantity).ToString() : (-1 * result1[3] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[4] * t.Quantity).ToString() : (-1 * result1[4] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[5] * t.Quantity).ToString() : (-1 * result1[5] * t.Quantity).ToString());
                    }
                    else
                    {
                        i.SubItems.Add(result1[6].ToString());
                        i.SubItems.Add(t.IsBuy ? ((result1[6] - t.Price) * t.Quantity).ToString() : ((t.Price - result1[6]) * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[7] * t.Quantity).ToString() : (-1 * result1[7] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[8] * t.Quantity).ToString() : (-1 * result1[8] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[9] * t.Quantity).ToString() : (-1 * result1[9] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[10] * t.Quantity).ToString() : (-1 * result1[10] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[11] * t.Quantity).ToString() : (-1 * result1[11] * t.Quantity).ToString());
                    }
                    listView1.Items.Add(i);
                }
                else if (t.Instruments.InstType.TypeName == "LookbackOption")
                {
                    var qq = (from p in cl.Instruments
                              where p.Ticker == t.Instruments.Underlying
                              select p).First();
                    double S0 = qq.Prices.Last().ClosingPrice;

                  
                    result1 = a.GetLookback(S0, Convert.ToDouble(t.Instruments.Strick), 0.05, Convert.ToDouble(t.Instruments.Tenor), Convert.ToDouble(VolMain.Text));
                    if (t.Instruments.Iscall == true)
                    {


                        i.SubItems.Add(result1[0].ToString());
                        i.SubItems.Add(t.IsBuy ? ((result1[0] - t.Price) * t.Quantity).ToString() : ((t.Price - result1[0]) * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[1] * t.Quantity).ToString() : (-1 * result1[1] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[2] * t.Quantity).ToString() : (-1 * result1[2] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[3] * t.Quantity).ToString() : (-1 * result1[3] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[4] * t.Quantity).ToString() : (-1 * result1[4] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[5] * t.Quantity).ToString() : (-1 * result1[5] * t.Quantity).ToString());
                    }
                    else
                    {
                        i.SubItems.Add(result1[6].ToString());
                        i.SubItems.Add(t.IsBuy ? ((result1[6] - t.Price) * t.Quantity).ToString() : ((t.Price - result1[6]) * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[7] * t.Quantity).ToString() : (-1 * result1[7] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[8] * t.Quantity).ToString() : (-1 * result1[8] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[9] * t.Quantity).ToString() : (-1 * result1[9] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[10] * t.Quantity).ToString() : (-1 * result1[10] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[11] * t.Quantity).ToString() : (-1 * result1[11] * t.Quantity).ToString());
                    }
                    listView1.Items.Add(i);
                }
                else if (t.Instruments.InstType.TypeName == "RangeOption")
               
                {
                    var qq = (from p in cl.Instruments
                              where p.Ticker == t.Instruments.Underlying
                              select p).First();
                    double S0 = qq.Prices.Last().ClosingPrice;

                   
                    result1 = a.GetRange(S0, Convert.ToDouble(t.Instruments.Strick), 0.05, Convert.ToDouble(t.Instruments.Tenor), Convert.ToDouble(VolMain.Text));
                   
                        i.SubItems.Add(result1[0].ToString());
                        i.SubItems.Add(t.IsBuy ? ((result1[0] - t.Price) * t.Quantity).ToString() : ((t.Price - result1[0]) * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[1] * t.Quantity).ToString() : (-1 * result1[1] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[2] * t.Quantity).ToString() : (-1 * result1[2] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[3] * t.Quantity).ToString() : (-1 * result1[3] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[4] * t.Quantity).ToString() : (-1 * result1[4] * t.Quantity).ToString());
                        i.SubItems.Add(t.IsBuy ? (result1[5] * t.Quantity).ToString() : (-1 * result1[5] * t.Quantity).ToString());
                    listView1.Items.Add(i);
                }
                
            }
            MessageBox.Show("Pricing is finished");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int t = listView1.SelectedIndices[0];

            listView1.Items[t].Remove();
        }

        private void VolMain_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

