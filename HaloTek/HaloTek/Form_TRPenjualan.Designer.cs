namespace HaloTek
{
    partial class Form_TRPenjualan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHome = new FontAwesome.Sharp.IconPictureBox();
            this.btnBatal = new FontAwesome.Sharp.IconButton();
            this.btnTambah = new FontAwesome.Sharp.IconButton();
            this.btnCheckout = new FontAwesome.Sharp.IconButton();
            this.btnSimpan = new FontAwesome.Sharp.IconButton();
            this.rbYa = new System.Windows.Forms.RadioButton();
            this.rbTidak = new System.Windows.Forms.RadioButton();
            this.cbResep = new System.Windows.Forms.ComboBox();
            this.mResepBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetResep = new HaloTek.DataSetResep();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.tbSisa = new System.Windows.Forms.TextBox();
            this.tbJumlah = new System.Windows.Forms.TextBox();
            this.tbTotalHarga = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idresepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namadokterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.praktekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kandunganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglinputDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTransaksi = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaAkhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kuantitas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbKembalian = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbBayar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbObat = new System.Windows.Forms.ComboBox();
            this.spLoadObatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetObat2 = new HaloTek.DataSetObat2();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.mResepTableAdapter = new HaloTek.DataSetResepTableAdapters.mResepTableAdapter();
            this.updateOrderOptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_LoadObatTableAdapter = new HaloTek.DataSetObat2TableAdapters.sp_LoadObatTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mResepBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetResep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLoadObatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetObat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateOrderOptionBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.btnHome.Location = new System.Drawing.Point(43, 538);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 52);
            this.btnHome.TabIndex = 31;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnBatal.IconColor = System.Drawing.Color.Black;
            this.btnBatal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBatal.IconSize = 15;
            this.btnBatal.Location = new System.Drawing.Point(387, 788);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(115, 45);
            this.btnBatal.TabIndex = 33;
            this.btnBatal.Text = "Batal";
            this.btnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnTambah.IconColor = System.Drawing.Color.Black;
            this.btnTambah.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTambah.IconSize = 15;
            this.btnTambah.Location = new System.Drawing.Point(529, 788);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(115, 45);
            this.btnTambah.TabIndex = 32;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            this.btnCheckout.IconColor = System.Drawing.Color.Black;
            this.btnCheckout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckout.IconSize = 15;
            this.btnCheckout.Location = new System.Drawing.Point(1292, 886);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(115, 45);
            this.btnCheckout.TabIndex = 34;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btnSimpan.IconColor = System.Drawing.Color.Black;
            this.btnSimpan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSimpan.IconSize = 15;
            this.btnSimpan.Location = new System.Drawing.Point(1765, 896);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(115, 45);
            this.btnSimpan.TabIndex = 35;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // rbYa
            // 
            this.rbYa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbYa.AutoSize = true;
            this.rbYa.Location = new System.Drawing.Point(407, 418);
            this.rbYa.Name = "rbYa";
            this.rbYa.Size = new System.Drawing.Size(46, 21);
            this.rbYa.TabIndex = 42;
            this.rbYa.TabStop = true;
            this.rbYa.Text = "Ya";
            this.rbYa.UseVisualStyleBackColor = true;
            this.rbYa.CheckedChanged += new System.EventHandler(this.rbYa_CheckedChanged);
            // 
            // rbTidak
            // 
            this.rbTidak.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbTidak.AutoSize = true;
            this.rbTidak.Location = new System.Drawing.Point(485, 418);
            this.rbTidak.Name = "rbTidak";
            this.rbTidak.Size = new System.Drawing.Size(64, 21);
            this.rbTidak.TabIndex = 43;
            this.rbTidak.TabStop = true;
            this.rbTidak.Text = "Tidak";
            this.rbTidak.UseVisualStyleBackColor = true;
            this.rbTidak.CheckedChanged += new System.EventHandler(this.rbTidak_CheckedChanged);
            // 
            // cbResep
            // 
            this.cbResep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbResep.DataSource = this.mResepBindingSource;
            this.cbResep.DisplayMember = "id_resep";
            this.cbResep.FormattingEnabled = true;
            this.cbResep.Location = new System.Drawing.Point(407, 456);
            this.cbResep.Name = "cbResep";
            this.cbResep.Size = new System.Drawing.Size(237, 24);
            this.cbResep.TabIndex = 44;
            this.cbResep.ValueMember = "id_resep";
            // 
            // mResepBindingSource
            // 
            this.mResepBindingSource.DataMember = "mResep";
            this.mResepBindingSource.DataSource = this.dataSetResep;
            // 
            // dataSetResep
            // 
            this.dataSetResep.DataSetName = "DataSetResep";
            this.dataSetResep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbHarga
            // 
            this.tbHarga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbHarga.Location = new System.Drawing.Point(405, 565);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(239, 22);
            this.tbHarga.TabIndex = 46;
            // 
            // tbSisa
            // 
            this.tbSisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSisa.Location = new System.Drawing.Point(407, 618);
            this.tbSisa.Name = "tbSisa";
            this.tbSisa.Size = new System.Drawing.Size(237, 22);
            this.tbSisa.TabIndex = 47;
            // 
            // tbJumlah
            // 
            this.tbJumlah.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbJumlah.Location = new System.Drawing.Point(408, 674);
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.Size = new System.Drawing.Size(236, 22);
            this.tbJumlah.TabIndex = 48;
            this.tbJumlah.TextChanged += new System.EventHandler(this.tbJumlah_TextChanged);
            this.tbJumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbJumlah_KeyPress);
            // 
            // tbTotalHarga
            // 
            this.tbTotalHarga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTotalHarga.Location = new System.Drawing.Point(407, 728);
            this.tbTotalHarga.Name = "tbTotalHarga";
            this.tbTotalHarga.Size = new System.Drawing.Size(237, 22);
            this.tbTotalHarga.TabIndex = 49;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(893, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(380, 212);
            this.dataGridView1.TabIndex = 50;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idresepDataGridViewTextBoxColumn,
            this.idcustomerDataGridViewTextBoxColumn,
            this.namadokterDataGridViewTextBoxColumn,
            this.praktekDataGridViewTextBoxColumn,
            this.kandunganDataGridViewTextBoxColumn,
            this.tglinputDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.mResepBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(1414, 352);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(368, 193);
            this.dataGridView2.TabIndex = 51;
            // 
            // idresepDataGridViewTextBoxColumn
            // 
            this.idresepDataGridViewTextBoxColumn.DataPropertyName = "id_resep";
            this.idresepDataGridViewTextBoxColumn.HeaderText = "id_resep";
            this.idresepDataGridViewTextBoxColumn.Name = "idresepDataGridViewTextBoxColumn";
            // 
            // idcustomerDataGridViewTextBoxColumn
            // 
            this.idcustomerDataGridViewTextBoxColumn.DataPropertyName = "id_customer";
            this.idcustomerDataGridViewTextBoxColumn.HeaderText = "id_customer";
            this.idcustomerDataGridViewTextBoxColumn.Name = "idcustomerDataGridViewTextBoxColumn";
            // 
            // namadokterDataGridViewTextBoxColumn
            // 
            this.namadokterDataGridViewTextBoxColumn.DataPropertyName = "nama_dokter";
            this.namadokterDataGridViewTextBoxColumn.HeaderText = "nama_dokter";
            this.namadokterDataGridViewTextBoxColumn.Name = "namadokterDataGridViewTextBoxColumn";
            // 
            // praktekDataGridViewTextBoxColumn
            // 
            this.praktekDataGridViewTextBoxColumn.DataPropertyName = "praktek";
            this.praktekDataGridViewTextBoxColumn.HeaderText = "praktek";
            this.praktekDataGridViewTextBoxColumn.Name = "praktekDataGridViewTextBoxColumn";
            // 
            // kandunganDataGridViewTextBoxColumn
            // 
            this.kandunganDataGridViewTextBoxColumn.DataPropertyName = "kandungan";
            this.kandunganDataGridViewTextBoxColumn.HeaderText = "kandungan";
            this.kandunganDataGridViewTextBoxColumn.Name = "kandunganDataGridViewTextBoxColumn";
            // 
            // tglinputDataGridViewTextBoxColumn
            // 
            this.tglinputDataGridViewTextBoxColumn.DataPropertyName = "tgl_input";
            this.tglinputDataGridViewTextBoxColumn.HeaderText = "tgl_input";
            this.tglinputDataGridViewTextBoxColumn.Name = "tglinputDataGridViewTextBoxColumn";
            // 
            // dgTransaksi
            // 
            this.dgTransaksi.AllowUserToAddRows = false;
            this.dgTransaksi.AllowUserToDeleteRows = false;
            this.dgTransaksi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgTransaksi.BackgroundColor = System.Drawing.Color.White;
            this.dgTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nama,
            this.Resep,
            this.Harga,
            this.HargaAkhir,
            this.Stock,
            this.Kuantitas});
            this.dgTransaksi.Location = new System.Drawing.Point(912, 671);
            this.dgTransaksi.Margin = new System.Windows.Forms.Padding(4);
            this.dgTransaksi.Name = "dgTransaksi";
            this.dgTransaksi.Size = new System.Drawing.Size(499, 196);
            this.dgTransaksi.TabIndex = 122;
            this.dgTransaksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTransaksi_CellContentClick);
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
            // Resep
            // 
            this.Resep.HeaderText = "ID Resep";
            this.Resep.Name = "Resep";
            // 
            // Harga
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Harga.DefaultCellStyle = dataGridViewCellStyle9;
            this.Harga.HeaderText = "Harga (Rp)";
            this.Harga.Name = "Harga";
            // 
            // HargaAkhir
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.HargaAkhir.DefaultCellStyle = dataGridViewCellStyle10;
            this.HargaAkhir.HeaderText = "Total Harga (Rp)";
            this.HargaAkhir.Name = "HargaAkhir";
            // 
            // Stock
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Stock.DefaultCellStyle = dataGridViewCellStyle11;
            this.Stock.HeaderText = "Stok";
            this.Stock.Name = "Stock";
            // 
            // Kuantitas
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Kuantitas.DefaultCellStyle = dataGridViewCellStyle12;
            this.Kuantitas.HeaderText = "Jumlah";
            this.Kuantitas.Name = "Kuantitas";
            this.Kuantitas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tbKembalian
            // 
            this.tbKembalian.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbKembalian.Location = new System.Drawing.Point(1724, 799);
            this.tbKembalian.Name = "tbKembalian";
            this.tbKembalian.Size = new System.Drawing.Size(179, 22);
            this.tbKembalian.TabIndex = 137;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1524, 793);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 28);
            this.label9.TabIndex = 136;
            this.label9.Text = "Kembalian                     :";
            // 
            // tbBayar
            // 
            this.tbBayar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbBayar.Location = new System.Drawing.Point(1724, 742);
            this.tbBayar.Name = "tbBayar";
            this.tbBayar.Size = new System.Drawing.Size(179, 22);
            this.tbBayar.TabIndex = 135;
            this.tbBayar.TextChanged += new System.EventHandler(this.tbBayar_TextChanged);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1524, 734);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 28);
            this.label11.TabIndex = 134;
            this.label11.Text = "Bayar                            :";
            this.label11.TextChanged += new System.EventHandler(this.label11_TextChanged);
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSubtotal.Location = new System.Drawing.Point(1723, 678);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.Size = new System.Drawing.Size(180, 22);
            this.tbSubtotal.TabIndex = 133;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1520, 671);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 28);
            this.label8.TabIndex = 132;
            this.label8.Text = "SubTotal untuk Produk  :";
            // 
            // cbObat
            // 
            this.cbObat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbObat.DataSource = this.spLoadObatBindingSource;
            this.cbObat.DisplayMember = "nama_obat";
            this.cbObat.FormattingEnabled = true;
            this.cbObat.Location = new System.Drawing.Point(405, 516);
            this.cbObat.Name = "cbObat";
            this.cbObat.Size = new System.Drawing.Size(239, 24);
            this.cbObat.TabIndex = 138;
            this.cbObat.ValueMember = "id_obat";
            this.cbObat.SelectedIndexChanged += new System.EventHandler(this.cbObat_SelectedIndexChanged);
            // 
            // spLoadObatBindingSource
            // 
            this.spLoadObatBindingSource.DataMember = "sp_LoadObat";
            this.spLoadObatBindingSource.DataSource = this.dataSetObat2;
            // 
            // dataSetObat2
            // 
            this.dataSetObat2.DataSetName = "DataSetObat2";
            this.dataSetObat2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTotal.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(1108, 896);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(114, 28);
            this.lblSubTotal.TabIndex = 139;
            this.lblSubTotal.Text = "SubTotal :  Rp. ";
            // 
            // mResepTableAdapter
            // 
            this.mResepTableAdapter.ClearBeforeFill = true;
            // 
            // updateOrderOptionBindingSource
            // 
            this.updateOrderOptionBindingSource.DataSource = typeof(HaloTek.DatasetObatTableAdapters.TableAdapterManager.UpdateOrderOption);
            // 
            // sp_LoadObatTableAdapter
            // 
            this.sp_LoadObatTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 28);
            this.label1.TabIndex = 140;
            this.label1.Text = "Resep";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(287, 509);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 28);
            this.label7.TabIndex = 141;
            this.label7.Text = "Nama Obat";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 28);
            this.label2.TabIndex = 142;
            this.label2.Text = "Harga";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(287, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 28);
            this.label3.TabIndex = 143;
            this.label3.Text = "Sisa Stok";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 668);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.TabIndex = 144;
            this.label4.Text = "Jumlah";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 722);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 28);
            this.label5.TabIndex = 145;
            this.label5.Text = "Total Harga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(383, 565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 23);
            this.label6.TabIndex = 146;
            this.label6.Text = "Rp.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(384, 726);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 23);
            this.label10.TabIndex = 147;
            this.label10.Text = "Rp.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(1699, 678);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 23);
            this.label12.TabIndex = 148;
            this.label12.Text = "Rp.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(1699, 742);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 23);
            this.label13.TabIndex = 149;
            this.label13.Text = "Rp.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(1701, 799);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 23);
            this.label14.TabIndex = 150;
            this.label14.Text = "Rp.";
            // 
            // Form_TRPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HaloTek.Properties.Resources.Form_TRPenjualan1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.cbObat);
            this.Controls.Add(this.tbKembalian);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbBayar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbSubtotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgTransaksi);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbTotalHarga);
            this.Controls.Add(this.tbJumlah);
            this.Controls.Add(this.tbSisa);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.cbResep);
            this.Controls.Add(this.rbTidak);
            this.Controls.Add(this.rbYa);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_TRPenjualan";
            this.Text = "Transaksi Penjualan";
            this.Load += new System.EventHandler(this.Form_TRPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mResepBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetResep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLoadObatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetObat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateOrderOptionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btnHome;
        private FontAwesome.Sharp.IconButton btnBatal;
        private FontAwesome.Sharp.IconButton btnTambah;
        private FontAwesome.Sharp.IconButton btnCheckout;
        private FontAwesome.Sharp.IconButton btnSimpan;
        private System.Windows.Forms.RadioButton rbYa;
        private System.Windows.Forms.RadioButton rbTidak;
        private System.Windows.Forms.ComboBox cbResep;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.TextBox tbSisa;
        private System.Windows.Forms.TextBox tbJumlah;
        private System.Windows.Forms.TextBox tbTotalHarga;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dgTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaAkhir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kuantitas;
        private System.Windows.Forms.TextBox tbKembalian;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbBayar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbObat;
        private System.Windows.Forms.Label lblSubTotal;
        private DataSetResep dataSetResep;
        private System.Windows.Forms.BindingSource mResepBindingSource;
        private DataSetResepTableAdapters.mResepTableAdapter mResepTableAdapter;
        private System.Windows.Forms.BindingSource updateOrderOptionBindingSource;
        private DataSetObat2 dataSetObat2;
        private System.Windows.Forms.BindingSource spLoadObatBindingSource;
        private DataSetObat2TableAdapters.sp_LoadObatTableAdapter sp_LoadObatTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idresepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namadokterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn praktekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kandunganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglinputDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}