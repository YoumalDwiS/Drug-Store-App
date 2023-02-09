namespace HaloTek
{
    partial class Form_DBAdmin1
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
            this.btnTransaksi = new FontAwesome.Sharp.IconPictureBox();
            this.btnLogout = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnTransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.BackColor = System.Drawing.SystemColors.Control;
            this.btnTransaksi.BackgroundImage = global::HaloTek.Properties.Resources.Icon_Transaksi;
            this.btnTransaksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTransaksi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTransaksi.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTransaksi.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnTransaksi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTransaksi.IconSize = 140;
            this.btnTransaksi.Location = new System.Drawing.Point(987, 490);
            this.btnTransaksi.Margin = new System.Windows.Forms.Padding(4);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(150, 140);
            this.btnTransaksi.TabIndex = 1;
            this.btnTransaksi.TabStop = false;
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click);
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
            this.btnLogout.Location = new System.Drawing.Point(43, 490);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(79, 63);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form_DBAdmin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HaloTek.Properties.Resources.Form_DBAdmin1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnTransaksi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_DBAdmin1";
            this.Text = "Dashboard Admin";
            ((System.ComponentModel.ISupportInitialize)(this.btnTransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btnTransaksi;
        private FontAwesome.Sharp.IconPictureBox btnLogout;
    }
}