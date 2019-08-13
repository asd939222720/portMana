namespace WindowsFormsApp2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VolMain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.instTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interestRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyPRiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreashTradeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceWithSimulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interstRateAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicalPriceAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changlinfinalDataSet = new WindowsFormsApp2.ChanglinfinalDataSet();
            this.interestRatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.interestRatesTableAdapter = new WindowsFormsApp2.ChanglinfinalDataSetTableAdapters.InterestRatesTableAdapter();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changlinfinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interestRatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(49, 352);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(990, 158);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Direction";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Instment";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Inst Type";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Trade Price";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mark Price";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "P&L";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Delta";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Gamma";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Theta";
            this.columnHeader11.Width = 80;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Rho";
            this.columnHeader12.Width = 80;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Vega";
            this.columnHeader13.Width = 80;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.deleteToolStripMenuItem.Text = "delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.listView2.Location = new System.Drawing.Point(49, 164);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(990, 126);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Total P&L";
            this.columnHeader14.Width = 120;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Total Delta";
            this.columnHeader15.Width = 120;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Total Gamma";
            this.columnHeader16.Width = 120;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Total Theta";
            this.columnHeader17.Width = 120;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Total Vega";
            this.columnHeader18.Width = 120;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Total Rho";
            this.columnHeader19.Width = 120;
            // 
            // VolMain
            // 
            this.VolMain.Location = new System.Drawing.Point(142, 92);
            this.VolMain.Name = "VolMain";
            this.VolMain.Size = new System.Drawing.Size(153, 25);
            this.VolMain.TabIndex = 2;
            this.VolMain.Text = "0.5";
            this.VolMain.TextChanged += new System.EventHandler(this.VolMain_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Volatility%";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.analysisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1096, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.refreashTradeTableToolStripMenuItem,
            this.priceWithSimulationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instTypeToolStripMenuItem,
            this.instmentToolStripMenuItem,
            this.tradeToolStripMenuItem,
            this.interestRateToolStripMenuItem,
            this.historyPRiceToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(223, 26);
            this.toolStripMenuItem1.Text = "New Something";
            // 
            // instTypeToolStripMenuItem
            // 
            this.instTypeToolStripMenuItem.Name = "instTypeToolStripMenuItem";
            this.instTypeToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.instTypeToolStripMenuItem.Text = "InstType";
            this.instTypeToolStripMenuItem.Click += new System.EventHandler(this.instTypeToolStripMenuItem_Click);
            // 
            // instmentToolStripMenuItem
            // 
            this.instmentToolStripMenuItem.Name = "instmentToolStripMenuItem";
            this.instmentToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.instmentToolStripMenuItem.Text = "Instment";
            this.instmentToolStripMenuItem.Click += new System.EventHandler(this.instmentToolStripMenuItem_Click);
            // 
            // tradeToolStripMenuItem
            // 
            this.tradeToolStripMenuItem.Name = "tradeToolStripMenuItem";
            this.tradeToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.tradeToolStripMenuItem.Text = "Trade";
            this.tradeToolStripMenuItem.Click += new System.EventHandler(this.tradeToolStripMenuItem_Click);
            // 
            // interestRateToolStripMenuItem
            // 
            this.interestRateToolStripMenuItem.Name = "interestRateToolStripMenuItem";
            this.interestRateToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.interestRateToolStripMenuItem.Text = "Interest Rate";
            this.interestRateToolStripMenuItem.Click += new System.EventHandler(this.interestRateToolStripMenuItem_Click);
            // 
            // historyPRiceToolStripMenuItem
            // 
            this.historyPRiceToolStripMenuItem.Name = "historyPRiceToolStripMenuItem";
            this.historyPRiceToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.historyPRiceToolStripMenuItem.Text = "History Price";
            this.historyPRiceToolStripMenuItem.Click += new System.EventHandler(this.historyPRiceToolStripMenuItem_Click);
            // 
            // refreashTradeTableToolStripMenuItem
            // 
            this.refreashTradeTableToolStripMenuItem.Name = "refreashTradeTableToolStripMenuItem";
            this.refreashTradeTableToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.refreashTradeTableToolStripMenuItem.Text = "Refreash Trade Table";
            this.refreashTradeTableToolStripMenuItem.Click += new System.EventHandler(this.refreashTradeTableToolStripMenuItem_Click);
            // 
            // priceWithSimulationToolStripMenuItem
            // 
            this.priceWithSimulationToolStripMenuItem.Name = "priceWithSimulationToolStripMenuItem";
            this.priceWithSimulationToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.priceWithSimulationToolStripMenuItem.Text = "Price with Simulation";
            this.priceWithSimulationToolStripMenuItem.Click += new System.EventHandler(this.priceWithSimulationToolStripMenuItem_Click);
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interstRateAnalysisToolStripMenuItem,
            this.historicalPriceAnalysisToolStripMenuItem});
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.analysisToolStripMenuItem.Text = "Analysis";
            // 
            // interstRateAnalysisToolStripMenuItem
            // 
            this.interstRateAnalysisToolStripMenuItem.Name = "interstRateAnalysisToolStripMenuItem";
            this.interstRateAnalysisToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.interstRateAnalysisToolStripMenuItem.Text = "InterstRate Analysis ";
            this.interstRateAnalysisToolStripMenuItem.Click += new System.EventHandler(this.interstRateAnalysisToolStripMenuItem_Click);
            // 
            // historicalPriceAnalysisToolStripMenuItem
            // 
            this.historicalPriceAnalysisToolStripMenuItem.Name = "historicalPriceAnalysisToolStripMenuItem";
            this.historicalPriceAnalysisToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.historicalPriceAnalysisToolStripMenuItem.Text = "HistoricalPrice Analysis";
            this.historicalPriceAnalysisToolStripMenuItem.Click += new System.EventHandler(this.historicalPriceAnalysisToolStripMenuItem_Click);
            // 
            // changlinfinalDataSet
            // 
            this.changlinfinalDataSet.DataSetName = "ChanglinfinalDataSet";
            this.changlinfinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // interestRatesBindingSource
            // 
            this.interestRatesBindingSource.DataMember = "InterestRates";
            this.interestRatesBindingSource.DataSource = this.changlinfinalDataSet;
            // 
            // interestRatesTableAdapter
            // 
            this.interestRatesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VolMain);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changlinfinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interestRatesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.TextBox VolMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem instTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interestRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyPRiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreashTradeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceWithSimulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interstRateAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicalPriceAnalysisToolStripMenuItem;
        private ChanglinfinalDataSet changlinfinalDataSet;
        private System.Windows.Forms.BindingSource interestRatesBindingSource;
        private ChanglinfinalDataSetTableAdapters.InterestRatesTableAdapter interestRatesTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

