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
    public partial class InterestRateAnalysis : Form
    {
        PmanagementContainer cl = new PmanagementContainer();
        public InterestRateAnalysis()
        {
            InitializeComponent();
         
            //this.dataGridView1.DataSource = changlinfinalDataSet.Tables;
            //this.dataGridView1.DataMember = "InterestRates";

        }
        private void NewInterestRate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'finalHAOLI_DATABASEDataSet3.InterestRateSet' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter1.Fill(this.dataSet1.DataTable1);

        }
        private void RefreshRate()
        {
           
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void changlinfinalDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void InterestRateAnalysis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'changlinfinalDataSet1.InterestRates' table. You can move, or remove it, as needed.
            this.interestRatesTableAdapter.Fill(this.changlinfinalDataSet1.InterestRates);

        }
    }
}
