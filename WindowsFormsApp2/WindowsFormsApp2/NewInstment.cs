using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;



namespace WindowsFormsApp2
{
    public partial class NewInstment : Form
    {
        PmanagementContainer cl = new PmanagementContainer();

        public NewInstment()
        {
            InitializeComponent();
            var m = from p in cl.InstTypes
                    select p;
            foreach (InstType x in m)
            {
                int a = 1, b = 1;
                foreach (string item in comboBox1.Items)
                {
                    if (item==x.TypeName)
                    {
                        a = 0;
                    }
                    b = b * a;

                }
                if (b==1)
                {
                    comboBox1.Items.Add(x.TypeName);
                }

                    
            }
            var t = from p in cl.Instruments
                    where p.InstType.TypeName.ToUpper() == "STOCK"
                    select p;
            foreach (Instrument kik in t)
            {
                comboBox4.Items.Add(kik.Ticker);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text==string.Empty)
            {
                errorProvider1.SetError(comboBox1, "please choose the type of the instrument");
            }
            if (comboBox1.Text== "Stock")
            {
                comboBox2.Enabled = false;
                StrikePrice.Enabled = false;
                Tenor.Enabled = false;
                comboBox4.Enabled = false;
            }
            else
            {
                comboBox2.Enabled = true;
                StrikePrice.Enabled = true;
                Tenor.Enabled = true;
                comboBox4.Enabled = true;
            }
            if (comboBox1.Text=="RangeOption")
            {
                comboBox2.Enabled = false;
            }
            
            if (comboBox1.Text=="BarrierOption")
            {
                BarrierLevel.Enabled = true;
                comboBox3.Enabled = true;
            }
            else
            {
                BarrierLevel.Enabled = false;
                comboBox3.Enabled = false;
            }
            if (comboBox1.Text=="DigitalOption")
            {
                Rebatelevel.Enabled = true;
            }
            else
            {
                Rebatelevel.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InstType t = (from p in cl.InstTypes
                          where p.TypeName == comboBox1.Text
                          select p).First();
            if (comboBox1.Text == string.Empty)
            {
                errorProvider1.SetError(comboBox1, "please choose the type of the instrument");
                return;
            }
            if (Ticker.Text == string.Empty)
            {
                errorProvider1.SetError(Ticker, "please input a ticker for this instrument");
                return;
            }
            if (comboBox4.Text == string.Empty&&comboBox1.Text!="Stock")
            {
                errorProvider1.SetError(comboBox4, "please choose a underlying for this instrument");
                return;
            }
            if (comboBox1.Text != "Stock" && comboBox1.Text != "RangeOption")
            {
                double num;
                if (!double.TryParse(StrikePrice.Text, out num))
                {
                    errorProvider1.SetError(StrikePrice, "please enter a positive  number");
                    return;
                }
                else if (Convert.ToDouble(StrikePrice.Text) <= 0)
                {
                    errorProvider1.SetError(StrikePrice, "please enter a positive  number");
                    return;
                }
                else
                {
                    errorProvider1.SetError(StrikePrice, string.Empty);
                }
            }
             if (comboBox1.Text != "Stock")
            {
                double num;
                if (!double.TryParse(Tenor.Text, out num))
                {
                    errorProvider1.SetError(Tenor, "please enter a positive  number");
                    return;
                }
                else if (Convert.ToDouble(Tenor.Text) <= 0)
                {
                    errorProvider1.SetError(Tenor, "please enter a positive  number");
                    return;
                }
                else
                {
                    errorProvider1.SetError(Tenor, string.Empty);
                }
            }
            
           
            if (comboBox1.Text != "Stock" && comboBox1.Text != "RangeOption")
            {
                if (comboBox2.Text==string.Empty)
                {
                    
                    errorProvider1.SetError(comboBox2, "please choose a optiontype for this instrument");
                     return;
                }
                
            }
           

            if (comboBox1.Text == "BarrierOption")
            {
                if (comboBox3.Text == string.Empty)
                {
                    errorProvider1.SetError(comboBox3, "please choose a barriertype for this instrument");
                    return;
                }
                double num;
                if (!double.TryParse(BarrierLevel.Text, out num))
                {
                    errorProvider1.SetError(BarrierLevel, "please enter a positive  number");
                    return;
                }
                else if (Convert.ToDouble(BarrierLevel.Text) <= 0)
                {
                    errorProvider1.SetError(BarrierLevel, "please enter a positive  number");
                    return;
                }
                else
                {
                    errorProvider1.SetError(BarrierLevel, string.Empty);
                }
            }
            if (comboBox1.Text=="DigitalOption")
            {
                double num;
                if (!double.TryParse(Rebatelevel.Text, out num))
                {
                    errorProvider1.SetError(Rebatelevel, "please enter a positive  number");
                    return;
                }
                else if (Convert.ToDouble(Rebatelevel.Text) <= 0)
                {
                    errorProvider1.SetError(Rebatelevel, "please enter a positive  number");
                    return;
                }
                else
                {
                    errorProvider1.SetError(Rebatelevel, string.Empty);
                }
            }

            cl.Instruments.Add(new Instrument()
            {

                Companyname =CompanyName.Text == string.Empty ? null : Convert.ToString(CompanyName.Text),
                Ticker = Ticker.Text == string.Empty ? null : Convert.ToString(Ticker.Text),
                Exchange = Exchange.Text == string.Empty ? null : Convert.ToString(Exchange.Text),
                Underlying = comboBox4.Text == string.Empty ? null : t.TypeName.ToUpper() == "STOCK" ? null : Convert.ToString(comboBox4.Text),
                Strick = t.TypeName.ToUpper() == "STOCK" ? 0 : StrikePrice.Text == string.Empty ? 0 : Convert.ToDouble(StrikePrice.Text),
                Tenor = t.TypeName.ToUpper() == "STOCK" ? 0 : Tenor.Text == string.Empty ? 0 : Convert.ToDouble(Tenor.Text),
                Iscall =  comboBox2.Text=="call"?true:comboBox2.Text=="Put"? false: true,
                InstTypeId = t.Id,
                InstType = t,
                Barrier = BarrierLevel.Text == string.Empty ? 0 : t.TypeName.ToUpper() == "BARRIEROPTION" ? Convert.ToDouble(BarrierLevel.Text) : 0,
                BarrierType = t.TypeName.ToUpper() == "BARRIEROPTION" ? comboBox3.Text== string.Empty? null:Convert.ToString(comboBox3.Text):null, 
                Rebate = Rebatelevel.Text == string.Empty ? 0 : t.TypeName.ToUpper() == "DIGITAL" ? Convert.ToDouble(Rebatelevel.Text) : 0

            });
            cl.SaveChanges();
            MessageBox.Show("New instrument added successfully!");
            this.Dispose();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Ticker_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void CompanyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewInstment_Load(object sender, EventArgs e)
        {

        }

        private void StrikePrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Tenor_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void BarrierLevel_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "BarrierOption")
            {
                double num;
                if (!double.TryParse(BarrierLevel.Text, out num))
                {
                    errorProvider1.SetError(BarrierLevel, "please enter a positive  number");
                    return;
                }
                else if (Convert.ToDouble(BarrierLevel.Text) <= 0)
                {
                    errorProvider1.SetError(BarrierLevel, "please enter a positive  number");
                    return;
                }
                else
                {
                    errorProvider1.SetError(BarrierLevel, string.Empty);
                }
            }
        }
    }
}
