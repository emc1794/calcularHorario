namespace Sqlite
{
    partial class FrmReportePersona
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
            this.PruebaDataSet5 = new Sqlite.PruebaDataSet5();
            this.PersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersonaTableAdapter = new Sqlite.PruebaDataSet5TableAdapters.PersonaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PruebaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PersonaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sqlite.rpPersona.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(698, 350);
            this.reportViewer1.TabIndex = 0;
            // 
            // PruebaDataSet5
            // 
            this.PruebaDataSet5.DataSetName = "PruebaDataSet5";
            this.PruebaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PersonaBindingSource
            // 
            this.PersonaBindingSource.DataMember = "Persona";
            this.PersonaBindingSource.DataSource = this.PruebaDataSet5;
            // 
            // PersonaTableAdapter
            // 
            this.PersonaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportePersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 371);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportePersona";
            this.Text = "FrmReportePersona";
            this.Load += new System.EventHandler(this.FrmReportePersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PruebaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PersonaBindingSource;
        private PruebaDataSet5 PruebaDataSet5;
        private PruebaDataSet5TableAdapters.PersonaTableAdapter PersonaTableAdapter;
    }
}