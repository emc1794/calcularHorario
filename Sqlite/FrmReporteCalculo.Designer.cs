namespace Sqlite
{
    partial class FrmReporteCalculo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PruebaDataSet8 = new Sqlite.PruebaDataSet8();
            this.calculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculoTableAdapter = new Sqlite.PruebaDataSet8TableAdapters.calculoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PruebaDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportePrueba";
            reportDataSource1.Value = this.calculoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sqlite.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(783, 328);
            this.reportViewer1.TabIndex = 0;
            // 
            // PruebaDataSet8
            // 
            this.PruebaDataSet8.DataSetName = "PruebaDataSet8";
            this.PruebaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calculoBindingSource
            // 
            this.calculoBindingSource.DataMember = "calculo";
            this.calculoBindingSource.DataSource = this.PruebaDataSet8;
            // 
            // calculoTableAdapter
            // 
            this.calculoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 328);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReporteCalculo";
            this.Text = "FrmReporteCalculo";
            this.Load += new System.EventHandler(this.FrmReporteCalculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PruebaDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource calculoBindingSource;
        private PruebaDataSet8 PruebaDataSet8;
        private PruebaDataSet8TableAdapters.calculoTableAdapter calculoTableAdapter;

    }
}