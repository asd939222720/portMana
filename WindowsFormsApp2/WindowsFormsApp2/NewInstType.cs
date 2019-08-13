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
    public partial class NewInstType : Form
    {

        PmanagementContainer cl = new PmanagementContainer();
        public NewInstType()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*cl.InstTypes.Add(new InstType() {
                TypeName = Convert.ToString(comboBox1.Text)
            });
            cl.SaveChanges();
            
            MessageBox.Show("you have add a new instrument type ! Congratulations!");                      
            return;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text==string.Empty)
            {
                errorProvider1.SetError(comboBox1, "please choose a instrument type");
                return;
            }
            cl.InstTypes.Add(new InstType()
            {
                TypeName = Convert.ToString(comboBox1.Text)
            });
            cl.SaveChanges();

            MessageBox.Show("you have add a new instrument type ! Congratulations!");
            return;

        }
    }
}
