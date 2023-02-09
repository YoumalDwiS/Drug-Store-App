namespace HaloTek
{
    partial class Form_DBKepala
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
            this.btnPenjualan = new FontAwesome.Sharp.IconPictureBox();
            this.btnPembelian = new FontAwesome.Sharp.IconPictureBox();
            this.btnPendapatan = new FontAwesome.Sharp.IconPictureBox();
            this.btnLogout = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnPenjualan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPembelian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPendapatan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPenjualan
            // 
            this.btnPenjualan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPenjualan.BackColor = System.Drawing.SystemColors.Control;
            this.btnPenjualan.BackgroundImage = global::HaloTek.Properties.Resources.Icon_Penjualan;
            this.btnPenjualan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPenjualan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPenjualan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPenjualan.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnPenjualan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPenjualan.IconSize = 140;
            this.btnPenjualan.Location = new System.Drawing.Point(614, 360);
            this.btnPenjualan.Margin = new System.Windows.Forms.Padding(4);
            this.btnPenjualan.Name = "btnPenjualan";
            this.btnPenjualan.Size = new System.Drawing.Size(150, 140);
            this.btnPenjualan.TabIndex = 2;
            this.btnPenjualan.TabStop = false;
            this.btnPenjualan.Click += new System.EventHandler(this.btnPenjualan_Click);
            // 
            // btnPembelian
            // 
            this.btnPembelian.BackColor = System.Drawing.SystemColors.Control;
            this.btnPembelian.BackgroundImage = global::HaloTek.Properties.Resources.Icon_Pembelian;
            this.btnPembelian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPembelian.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPembelian.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPembelian.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnPembelian.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPembelian.IconSize = 140;
            this.btnPembelian.Location = new System.Drawing.Point(1334, 360);
            this.btnPembelian.Margin = new System.Windows.Forms.Padding(4);
            this.btnPembelian.Name = "btnPembelian";
            this.btnPembelian.Size = new System.Drawing.Size(150, 140);
            this.btnPembelian.TabIndex = 3;
            this.btnPembelian.TabStop = false;
            this.btnPembelian.Click += new System.EventHandler(this.btnPembelian_Click);
            // 
            // btnPendapatan
            // 
            this.btnPendapatan.BackColor = System.Drawing.SystemColors.Control;
            this.btnPendapatan.BackgroundImage = global::HaloTek.Properties.Resources.Icon_Pendapatan;
            this.btnPendapatan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPendapatan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPendapatan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPendapatan.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnPendapatan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPendapatan.IconSize = 140;
            this.btnPendapatan.Location = new System.Drawing.Point(989, 667);
            this.btnPendapatan.Margin = new System.Windows.Forms.Padding(4);
            this.btnPendapatan.Name = "btnPendapatan";
            this.btnPendapatan.Size = new System.Drawing.Size(150, 140);
            this.btnPendapatan.TabIndex = 4;
            this.btnPendapatan.TabStop = false;
            this.btnPendapatan.Click += new System.EventHandler(this.btnPendapatan_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = global::HaloTek.Properties.Resources.Icon_Logout__1_;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLogout.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 63;
            this.btnLogout.Location = new System.Drawing.Point(40, 503);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(79, 63);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.TabStop = false;
            // 
            // Form_DBKepala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HaloTek.Properties.Resources.Form_DBKepala;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPendapatan);
            this.Controls.Add(this.btnPembelian);
            this.Controls.Add(this.btnPenjualan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_DBKepala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard Kepala";
            ((System.ComponentModel.ISupportInitialize)(this.btnPenjualan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPembelian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPendapatan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btnPenjualan;
        private FontAwesome.Sharp.IconPictureBox btnPembelian;
        private FontAwesome.Sharp.IconPictureBox btnPendapatan;
        private FontAwesome.Sharp.IconPictureBox btnLogout;
    }
}