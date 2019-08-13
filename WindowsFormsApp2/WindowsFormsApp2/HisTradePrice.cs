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
    public partial class HisTradePrice : Form
    {
        PmanagementContainer cl = new PmanagementContainer();
        public HisTradePrice()
        {
            InitializeComponent();
            foreach (Instrument item in cl.Instruments)
            {
                comboBox1.Items.Add(item.Ticker);
            }
            
    }
        private void RefreashTrade()
        {
            if (comboBox1.Text==string.Empty)
            {
                errorProvider1.SetError(comboBox1, "please choose a instrument");
            }
            listView1.Items.Clear();

            ListViewItem i;
            //Trade m = from p in cl.Trades
                    //  where p.Instruments.Ticker == comboBox1.Text
                     // select p;
            foreach (Trade n in cl.Trades )
            {
                if (n.Instruments.Ticker==comboBox1.Text)
                {
                    i = new ListViewItem();
                    i.SubItems.Add(n.Timestamp.ToLongDateString());
                    i.SubItems.Add(n.Price.ToString());
                    listView1.Items.Add(i);
                }
                
               
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreashTrade();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
