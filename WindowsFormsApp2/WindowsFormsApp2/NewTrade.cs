using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class NewTrade : Form
       
    {
        PmanagementContainer cl = new PmanagementContainer();
        public NewTrade()
        {
            InitializeComponent();
            foreach (Instrument item in cl.Instruments)
            {
                comboBox1.Items.Add(item.Ticker);
            }
        }

        private void Tradequnt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (! checkBox1.Checked && ! checkBox2.Checked)
            {
                errorProvider1.SetError(checkBox1, "please choose you want to buy or sell");
                return;
            }
            if (checkBox1.Checked && checkBox2.Checked)
            {
                errorProvider1.SetError(checkBox1, "you can only choose buy or sell, not both");
                return;
            }
            
                double num;
                if (!double.TryParse(Tradequnt.Text, out num))
                {
                    errorProvider1.SetError(Tradequnt, "please enter a positive  number");
                    return;
                }
                else if (Convert.ToDouble(Tradequnt.Text) <= 0)
                {
                    errorProvider1.SetError(Tradequnt, "please enter a positive  number");
                    return;
                }
                else
                {
                    errorProvider1.SetError(Tradequnt, string.Empty);
                }
            
            if (comboBox1.Text==string.Empty)
            {
                errorProvider1.SetError(comboBox1, "please choose a instrument");
                return;
            }

            if (!double.TryParse(TradePrice.Text, out num))
            {
                errorProvider1.SetError(TradePrice, "please enter a positive  number");
                return;
            }
            else if (Convert.ToDouble(TradePrice.Text) <= 0)
            {
                errorProvider1.SetError(TradePrice, "please enter a positive  number");
                return;
            }
            else
            {
                errorProvider1.SetError(TradePrice, string.Empty);
            }
            Instrument m = (from p in cl.Instruments
                            where p.Ticker == comboBox1.Text
                            select p).First();
            cl.Trades.Add(new Trade()
            {
                Instruments = m,
                IsBuy = (checkBox1.Checked ? true : false),
                Price = Convert.ToDouble(TradePrice.Text),
                Quantity = Convert.ToInt32(Tradequnt.Text),
                Timestamp = dateTimePicker1.Value
            });
            if (m.InstType.TypeName == "Stock")
            {
                cl.prices.Add(new price()
                {
                    Instrument = m,
                    Date = dateTimePicker1.Value,
                    ClosingPrice = Convert.ToDouble(TradePrice.Text),
                    InstrumentId = m.Id

                });
            }
            cl.SaveChanges();
            MessageBox.Show("you have create a trade !");
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

