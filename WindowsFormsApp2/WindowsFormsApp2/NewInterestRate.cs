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
    public partial class NewInterestRate : Form
    {


        PmanagementContainer cl = new PmanagementContainer();
        public NewInterestRate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num;
            if (!double.TryParse(NewTenor.Text, out num))
            {
                errorProvider1.SetError(NewTenor, "please enter a positive  number");
                return;
            }
            else if (Convert.ToDouble(NewTenor.Text) <= 0)
            {
                errorProvider1.SetError(NewTenor, "please enter a positive  number");
                return;
            }
            else
            {
                errorProvider1.SetError(NewTenor, string.Empty);
            }
            if (!double.TryParse(NewRate.Text, out num))
            {
                errorProvider1.SetError(NewRate, "please enter a positive  number");
                return;
            }
            else if (Convert.ToDouble(NewRate.Text) <= 0)
            {
                errorProvider1.SetError(NewRate, "please enter a positive  number");
                return;
            }
            else
            {
                errorProvider1.SetError(NewRate, string.Empty);
            }
            cl.InterestRates.Add(new InterestRate()
            {
                Tenor = Convert.ToDouble(NewTenor.Text),
                Rate = Convert.ToDouble(NewRate.Text)

            });
            cl.SaveChanges();
            MessageBox.Show("you have renew or add the interest rate! ");
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NewTenor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
