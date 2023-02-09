namespace HaloTek
{
    partial class Form_LPPenjualan
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
            this.LaporanPendapatanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetLaporanPenjualan = new HaloTek.DataSetLaporanPenjualan();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnCari = new FontAwesome.Sharp.IconButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LaporanPendapatanTableAdapter = new HaloTek.DataSetLaporanPenjualanTableAdapters.LaporanPendapatanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LaporanPendapatanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetLaporanPenjualan)).BeginInit();
            this.SuspendLayout();
            // 
            // LaporanPendapatanBindingSource
            // 
            this.LaporanPendapatanBindingSource.DataMember = "LaporanPendapatan";
            this.LaporanPendapatanBindingSource.DataSource = this.DataSetLaporanPenjualan;
            // 
            // DataSetLaporanPenjualan
            // 
            this.DataSetLaporanPenjualan.DataSetName = "DataSetLaporanPenjualan";
            this.DataSetLaporanPenjualan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(554, 408);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(998, 408);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(176, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // btnCari
            // 
            this.btnCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.IconChar = FontAwesome.Sharp.IconChar.Globe;
            this.btnCari.IconColor = System.Drawing.Color.Black;
            this.btnCari.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCari.IconSize = 15;
            this.btnCari.Location = new System.Drawing.Point(1235, 398);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(115, 45);
            this.btnCari.TabIndex = 34;
            this.btnCari.Text = "Cari";
            this.btnCari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LaporanPendapatanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HaloTek.LaporanPenjualan.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(514, 479);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1108, 567);
            this.reportViewer1.TabIndex = 35;
            // 
            // LaporanPendapatanTableAdapter
            // 
            this.LaporanPendapatanTableAdapter.ClearBeforeFill = true;
            // 
            // Form_LPPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HaloTek.Properties.Resources.Form_LPPenjualan;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form_LPPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_LPPenjualan";
            this.Load += new System.EventHandler(this.Form_LPPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LaporanPendapatanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetLaporanPenjualan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private FontAwesome.Sharp.IconButton btnCari;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LaporanPendapatanBindingSource;
        private DataSetLaporanPenjualan DataSetLaporanPenjualan;
        private DataSetLaporanPenjualanTableAdapters.LaporanPendapatanTableAdapter LaporanPendapatanTableAdapter;
    }
}