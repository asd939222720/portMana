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
    public partial class NewHistoryPrice : Form
    {
        PmanagementContainer cl = new PmanagementContainer();
        public NewHistoryPrice()
        {
            InitializeComponent();
            foreach (Instrument item in cl.Instruments)
            {
                comboBox1.Items.Add(item.Ticker);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text==string.Empty)
            {
                errorProvider1.SetError(comboBox1, "please choose a kind of instrument");
                return;

            }
            double num;
            if (!double.TryParse(HisPrice.Text, out num))
            {
                errorProvider1.SetError(HisPrice, "please enter a positive  number");
                return;
            }
            else if (Convert.ToDouble(HisPrice.Text) <= 0)
            {
                errorProvider1.SetError(HisPrice, "please enter a positive  number");
                return;
            }
            else
            {
                errorProvider1.SetError(HisPrice, string.Empty);
            }

            var m = (from p in cl.Instruments
                     where p.Ticker == comboBox1.Text
                     select p).First();
            cl.prices.Add(new price()
            {
                Instrument = m,
                ClosingPrice = Convert.ToDouble(HisPrice.Text),
                Date = dateTimePicker1.Value
            });
            cl.SaveChanges();
            MessageBox.Show("Saving the added historical prices to database successfully!");
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
