namespace HaloTek
{
    partial class Form_TRPembelian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBatal = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconPictureBox();
            this.btnSimpan = new FontAwesome.Sharp.IconButton();
            this.btnCheckout = new FontAwesome.Sharp.IconButton();
            this.btnTambah = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.datasetObat = new HaloTek.DatasetObat();
            this.mObatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mObatTableAdapter = new HaloTek.DatasetObatTableAdapters.mObatTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idsupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namasupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telpsupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spLoadSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetSupplier = new HaloTek.DatasetSupplier();
            this.label1 = new System.Windows.Forms.Label();
            this.sp_LoadSupplierTableAdapter = new HaloTek.DatasetSupplierTableAdapters.sp_LoadSupplierTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaAkhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kuantitas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.cbObat = new System.Windows.Forms.ComboBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbSisa = new System.Windows.Forms.TextBox();
            this.tbJumlah = new System.Windows.Forms.TextBox();
            this.tbTotalHarga = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetObat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mObatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLoadSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBatal
            // 
            this.btnBatal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnBatal.IconColor = System.Drawing.Color.Black;
            this.btnBatal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBatal.IconSize = 15;
            this.btnBatal.Location = new System.Drawing.Point(441, 823);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(115, 45);
            this.btnBatal.TabIndex = 35;
            this.btnBatal.Text = "Batal";
            this.btnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::HaloTek.Properties.Resources.Icon_Home;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHome.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 52;
            this.btnHome.Location = new System.Drawing.Point(44, 498);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 52);
            this.btnHome.TabIndex = 36;
            this.btnHome.TabStop = false;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btnSimpan.IconColor = System.Drawing.Color.Black;
            this.btnSimpan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSimpan.IconSize = 15;
            this.btnSimpan.Location = new System.Drawing.Point(1761, 774);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(115, 45);
            this.btnSimpan.TabIndex = 38;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            this.btnCheckout.IconColor = System.Drawing.Color.Black;
            this.btnCheckout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckout.IconSize = 15;
            this.btnCheckout.Location = new System.Drawing.Point(1321, 940);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(115, 45);
            this.btnCheckout.TabIndex = 37;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnTambah.IconColor = System.Drawing.Color.Black;
            this.btnTambah.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTambah.IconSize = 15;
            this.btnTambah.Location = new System.Drawing.Point(587, 823);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(115, 45);
            this.btnTambah.TabIndex = 39;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(902, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(371, 216);
            this.dataGridView1.TabIndex = 40;
            // 
            // datasetObat
            // 
            this.datasetObat.DataSetName = "DatasetObat";
            this.datasetObat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mObatBindingSource
            // 
            this.mObatBindingSource.DataMember = "mObat";
            this.mObatBindingSource.DataSource = this.datasetObat;
            // 
            // mObatTableAdapter
            // 
            this.mObatTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsupplierDataGridViewTextBoxColumn,
            this.namasupplierDataGridViewTextBoxColumn,
            this.telpsupplierDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.spLoadSupplierBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(1410, 346);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(401, 216);
            this.dataGridView2.TabIndex = 41;
            // 
            // idsupplierDataGridViewTextBoxColumn
            // 
            this.idsupplierDataGridViewTextBoxColumn.DataPropertyName = "id_supplier";
            this.idsupplierDataGridViewTextBoxColumn.HeaderText = "ID Supplier";
            this.idsupplierDataGridViewTextBoxColumn.Name = "idsupplierDataGridViewTextBoxColumn";
            // 
            // namasupplierDataGridViewTextBoxColumn
            // 
            this.namasupplierDataGridViewTextBoxColumn.DataPropertyName = "nama_supplier";
            this.namasupplierDataGridViewTextBoxColumn.HeaderText = "Nama Supplier";
            this.namasupplierDataGridViewTextBoxColumn.Name = "namasupplierDataGridViewTextBoxColumn";
            // 
            // telpsupplierDataGridViewTextBoxColumn
            // 
            this.telpsupplierDataGridViewTextBoxColumn.DataPropertyName = "telp_supplier";
            this.telpsupplierDataGridViewTextBoxColumn.HeaderText = "No Telepon";
            this.telpsupplierDataGridViewTextBoxColumn.Name = "telpsupplierDataGridViewTextBoxColumn";
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            // 
            // spLoadSupplierBindingSource
            // 
            this.spLoadSupplierBindingSource.DataMember = "sp_LoadSupplier";
            this.spLoadSupplierBindingSource.DataSource = this.datasetSupplier;
            // 
            // datasetSupplier
            // 
            this.datasetSupplier.DataSetName = "DatasetSupplier";
            this.datasetSupplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 28);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nama Supplier ";
            // 
            // sp_LoadSupplierTableAdapter
            // 
            this.sp_LoadSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nama,
            this.Supplier,
            this.Harga,
            this.HargaAkhir,
            this.Stock,
            this.Kuantitas});
            this.dataGridView3.Location = new System.Drawing.Point(877, 700);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(559, 220);
            this.dataGridView3.TabIndex = 121;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID Obat";
            this.ID.Name = "ID";
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama Obat";
            this.Nama.Name = "Nama";
            // 
            // Supplier
            // 
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            // 
            // Harga
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Harga.DefaultCellStyle = dataGridViewCellStyle13;
            this.Harga.HeaderText = "Harga (Rp)";
            this.Harga.Name = "Harga";
            // 
            // HargaAkhir
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.HargaAkhir.DefaultCellStyle = dataGridViewCellStyle14;
            this.HargaAkhir.HeaderText = "Total Harga (Rp)";
            this.HargaAkhir.Name = "HargaAkhir";
            // 
            // Stock
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Stock.DefaultCellStyle = dataGridViewCellStyle15;
            this.Stock.HeaderText = "Stok";
            this.Stock.Name = "Stock";
            // 
            // Kuantitas
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Kuantitas.DefaultCellStyle = dataGridViewCellStyle16;
            this.Kuantitas.HeaderText = "Jumlah";
            this.Kuantitas.Name = "Kuantitas";
            this.Kuantitas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cbSupplier
            // 
            this.cbSupplier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSupplier.DataSource = this.spLoadSupplierBindingSource;
            this.cbSupplier.DisplayMember = "nama_supplier";
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(441, 432);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(261, 24);
            this.cbSupplier.TabIndex = 124;
            this.cbSupplier.ValueMember = "id_supplier";
            // 
            // cbObat
            // 
            this.cbObat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbObat.DataSource = this.mObatBindingSource;
            this.cbObat.DisplayMember = "nama_obat";
            this.cbObat.FormattingEnabled = true;
            this.cbObat.Location = new System.Drawing.Point(441, 489);
            this.cbObat.Name = "cbObat";
            this.cbObat.Size = new System.Drawing.Size(261, 24);
            this.cbObat.TabIndex = 125;
            this.cbObat.ValueMember = "id_obat";
            this.cbObat.SelectedIndexChanged += new System.EventHandler(this.cbObat_SelectedIndexChanged);
            // 
            // tbHarga
            // 
            this.tbHarga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHarga.Location = new System.Drawing.Point(441, 540);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(261, 22);
            this.tbHarga.TabIndex = 130;
            // 
            // tbSisa
            // 
            this.tbSisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSisa.Location = new System.Drawing.Point(441, 591);
            this.tbSisa.Name = "tbSisa";
            this.tbSisa.Size = new System.Drawing.Size(261, 22);
            this.tbSisa.TabIndex = 131;
            // 
            // tbJumlah
            // 
            this.tbJumlah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbJumlah.Location = new System.Drawing.Point(441, 648);
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.Size = new System.Drawing.Size(261, 22);
            this.tbJumlah.TabIndex = 132;
            this.tbJumlah.TextChanged += new System.EventHandler(this.tbJumlah_TextChanged);
            this.tbJumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJumlah_KeyPress);
            // 
            // tbTotalHarga
            // 
            this.tbTotalHarga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTotalHarga.Location = new System.Drawing.Point(441, 706);
            this.tbTotalHarga.Name = "tbTotalHarga";
            this.tbTotalHarga.Size = new System.Drawing.Size(261, 22);
            this.tbTotalHarga.TabIndex = 133;
            this.tbTotalHarga.TextChanged += new System.EventHandler(this.tbTotalHarga_TextChanged);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTotal.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(1136, 957);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(110, 28);
            this.lblSubTotal.TabIndex = 134;
            this.lblSubTotal.Text = "SubTotal : Rp. ";
            // 
            // tbTotal
            // 
            this.tbTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTotal.Location = new System.Drawing.Point(1681, 706);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(195, 22);
            this.tbTotal.TabIndex = 136;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1512, 700);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 28);
            this.label8.TabIndex = 135;
            this.label8.Text = "Total Pembayaran";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(311, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 28);
            this.label7.TabIndex = 137;
            this.label7.Text = "Nama Obat";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 28);
            this.label2.TabIndex = 138;
            this.label2.Text = "Harga";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 585);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 28);
            this.label3.TabIndex = 139;
            this.label3.Text = "Sisa Stok";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 642);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 28);
            this.label4.TabIndex = 140;
            this.label4.Text = "Jumlah ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 700);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 28);
            this.label5.TabIndex = 141;
            this.label5.Text = "Total Harga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(416, 540);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 23);
            this.label6.TabIndex = 142;
            this.label6.Text = "Rp.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(416, 706);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 23);
            this.label9.TabIndex = 143;
            this.label9.Text = "Rp.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(1652, 704);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 23);
            this.label10.TabIndex = 144;
            this.label10.Text = "Rp.";
            // 
            // Form_TRPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HaloTek.Properties.Resources.Form_TRPembelian;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.tbTotalHarga);
            this.Controls.Add(this.tbJumlah);
            this.Controls.Add(this.tbSisa);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.cbObat);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnBatal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_TRPembelian";
            this.Text = "Transaksi Pembelian";
            this.Load += new System.EventHandler(this.Form_TRPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetObat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mObatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLoadSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBatal;
        private FontAwesome.Sharp.IconPictureBox btnHome;
        private FontAwesome.Sharp.IconButton btnSimpan;
        private FontAwesome.Sharp.IconButton btnCheckout;
        private FontAwesome.Sharp.IconButton btnTambah;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatasetObat datasetObat;
        private System.Windows.Forms.BindingSource mObatBindingSource;
        private DatasetObatTableAdapters.mObatTableAdapter mObatTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private DatasetSupplier datasetSupplier;
        private System.Windows.Forms.BindingSource spLoadSupplierBindingSource;
        private DatasetSupplierTableAdapters.sp_LoadSupplierTableAdapter sp_LoadSupplierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namasupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telpsupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaAkhir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kuantitas;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.ComboBox cbObat;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbSisa;
        private System.Windows.Forms.TextBox tbJumlah;
        private System.Windows.Forms.TextBox tbTotalHarga;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}