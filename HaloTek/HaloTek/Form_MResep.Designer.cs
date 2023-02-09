namespace HaloTek
{
    partial class Form_MResep
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHapus = new FontAwesome.Sharp.IconButton();
            this.btnUbah = new FontAwesome.Sharp.IconButton();
            this.btnBatal = new FontAwesome.Sharp.IconButton();
            this.btnSimpan = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconPictureBox();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.spLoadCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetCustomer = new HaloTek.DatasetCustomer();
            this.tbNamaDokter = new System.Windows.Forms.TextBox();
            this.tbPraktek = new System.Windows.Forms.TextBox();
            this.tbKandungan = new System.Windows.Forms.TextBox();
            this.dtTglInput = new System.Windows.Forms.DateTimePicker();
            this.tbCari = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.sp_LoadCustomerTableAdapter = new HaloTek.DatasetCustomerTableAdapters.sp_LoadCustomerTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLoadCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnHapus.IconColor = System.Drawing.Color.Black;
            this.btnHapus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHapus.IconSize = 15;
            this.btnHapus.Location = new System.Drawing.Point(359, 737);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(115, 45);
            this.btnHapus.TabIndex = 33;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnUbah.IconColor = System.Drawing.Color.Black;
            this.btnUbah.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUbah.IconSize = 15;
            this.btnUbah.Location = new System.Drawing.Point(541, 737);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(4);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(115, 45);
            this.btnUbah.TabIndex = 32;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnBatal.IconColor = System.Drawing.Color.Black;
            this.btnBatal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBatal.IconSize = 15;
            this.btnBatal.Location = new System.Drawing.Point(359, 663);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(115, 45);
            this.btnBatal.TabIndex = 31;
            this.btnBatal.Text = "Batal";
            this.btnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btnSimpan.IconColor = System.Drawing.Color.Black;
            this.btnSimpan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSimpan.IconSize = 15;
            this.btnSimpan.Location = new System.Drawing.Point(541, 663);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(115, 45);
            this.btnSimpan.TabIndex = 30;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::HaloTek.Properties.Resources.Icon_Home;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHome.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 52;
            this.btnHome.Location = new System.Drawing.Point(13, 530);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 52);
            this.btnHome.TabIndex = 34;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Globe;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 15;
            this.iconButton5.Location = new System.Drawing.Point(1580, 387);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(4);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(115, 45);
            this.iconButton5.TabIndex = 35;
            this.iconButton5.Text = "Cari";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nama Customer";
            // 
            // cbCustomer
            // 
            this.cbCustomer.DataSource = this.spLoadCustomerBindingSource;
            this.cbCustomer.DisplayMember = "nama_customer";
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(359, 427);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(297, 24);
            this.cbCustomer.TabIndex = 41;
            this.cbCustomer.ValueMember = "id_customer";
            // 
            // spLoadCustomerBindingSource
            // 
            this.spLoadCustomerBindingSource.DataMember = "sp_LoadCustomer";
            this.spLoadCustomerBindingSource.DataSource = this.datasetCustomer;
            // 
            // datasetCustomer
            // 
            this.datasetCustomer.DataSetName = "DatasetCustomer";
            this.datasetCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbNamaDokter
            // 
            this.tbNamaDokter.Location = new System.Drawing.Point(359, 480);
            this.tbNamaDokter.Name = "tbNamaDokter";
            this.tbNamaDokter.Size = new System.Drawing.Size(297, 22);
            this.tbNamaDokter.TabIndex = 42;
            this.tbNamaDokter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNamaDokter_KeyPress);
            // 
            // tbPraktek
            // 
            this.tbPraktek.Location = new System.Drawing.Point(359, 525);
            this.tbPraktek.Name = "tbPraktek";
            this.tbPraktek.Size = new System.Drawing.Size(297, 22);
            this.tbPraktek.TabIndex = 43;
            this.tbPraktek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPraktek_KeyPress);
            // 
            // tbKandungan
            // 
            this.tbKandungan.Location = new System.Drawing.Point(359, 566);
            this.tbKandungan.Name = "tbKandungan";
            this.tbKandungan.Size = new System.Drawing.Size(297, 22);
            this.tbKandungan.TabIndex = 44;
            // 
            // dtTglInput
            // 
            this.dtTglInput.Location = new System.Drawing.Point(359, 613);
            this.dtTglInput.Name = "dtTglInput";
            this.dtTglInput.Size = new System.Drawing.Size(297, 22);
            this.dtTglInput.TabIndex = 45;
            // 
            // tbCari
            // 
            this.tbCari.Location = new System.Drawing.Point(1369, 410);
            this.tbCari.Name = "tbCari";
            this.tbCari.Size = new System.Drawing.Size(195, 22);
            this.tbCari.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(163)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(1117, 439);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(578, 333);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1580, 779);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 45);
            this.btnRefresh.TabIndex = 76;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // sp_LoadCustomerTableAdapter
            // 
            this.sp_LoadCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(201, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 28);
            this.label6.TabIndex = 77;
            this.label6.Text = "Nama Dokter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(201, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 28);
            this.label7.TabIndex = 78;
            this.label7.Text = "Praktek";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(201, 560);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 28);
            this.label8.TabIndex = 79;
            this.label8.Text = "Kandungan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(201, 607);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 28);
            this.label9.TabIndex = 80;
            this.label9.Text = "Tanggal Input";
            // 
            // Form_MResep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HaloTek.Properties.Resources.Form_MResep;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbCari);
            this.Controls.Add(this.dtTglInput);
            this.Controls.Add(this.tbKandungan);
            this.Controls.Add(this.tbPraktek);
            this.Controls.Add(this.tbNamaDokter);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_MResep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Resep";
            this.Load += new System.EventHandler(this.Form_MResep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLoadCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnHapus;
        private FontAwesome.Sharp.IconButton btnUbah;
        private FontAwesome.Sharp.IconButton btnBatal;
        private FontAwesome.Sharp.IconButton btnSimpan;
        private FontAwesome.Sharp.IconPictureBox btnHome;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.TextBox tbNamaDokter;
        private System.Windows.Forms.TextBox tbPraktek;
        private System.Windows.Forms.TextBox tbKandungan;
        private System.Windows.Forms.DateTimePicker dtTglInput;
        private System.Windows.Forms.TextBox tbCari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private DatasetCustomer datasetCustomer;
        private System.Windows.Forms.BindingSource spLoadCustomerBindingSource;
        private DatasetCustomerTableAdapters.sp_LoadCustomerTableAdapter sp_LoadCustomerTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}