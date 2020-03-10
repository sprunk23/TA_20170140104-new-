namespace TA_20170140104_new_.GUI
{
	partial class Menu_Utama
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Utama));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.menu_master = new System.Windows.Forms.ToolStripMenuItem();
			this.submenu_barang = new System.Windows.Forms.ToolStripMenuItem();
			this.submenu_pelanggan = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_transaksi = new System.Windows.Forms.ToolStripMenuItem();
			this.submenu_penjualan = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.menuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_master,
            this.menu_transaksi});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip.Size = new System.Drawing.Size(843, 28);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "MenuStrip";
			// 
			// menu_master
			// 
			this.menu_master.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_barang,
            this.submenu_pelanggan});
			this.menu_master.Name = "menu_master";
			this.menu_master.Size = new System.Drawing.Size(53, 24);
			this.menu_master.Text = "&Data";
			// 
			// submenu_barang
			// 
			this.submenu_barang.Name = "submenu_barang";
			this.submenu_barang.Size = new System.Drawing.Size(216, 26);
			this.submenu_barang.Text = "&Barang";
			this.submenu_barang.Click += new System.EventHandler(this.submenu_barang_Click);
			// 
			// submenu_pelanggan
			// 
			this.submenu_pelanggan.Name = "submenu_pelanggan";
			this.submenu_pelanggan.Size = new System.Drawing.Size(216, 26);
			this.submenu_pelanggan.Text = "&Pelanggan";
			this.submenu_pelanggan.Click += new System.EventHandler(this.submenu_pelanggan_Click);
			// 
			// menu_transaksi
			// 
			this.menu_transaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_penjualan});
			this.menu_transaksi.Name = "menu_transaksi";
			this.menu_transaksi.Size = new System.Drawing.Size(80, 24);
			this.menu_transaksi.Text = "&Transaksi";
			// 
			// submenu_penjualan
			// 
			this.submenu_penjualan.Name = "submenu_penjualan";
			this.submenu_penjualan.Size = new System.Drawing.Size(147, 26);
			this.submenu_penjualan.Text = "&Penjualan";
			this.submenu_penjualan.Click += new System.EventHandler(this.submenu_penjualan_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 533);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
			this.statusStrip.Size = new System.Drawing.Size(843, 25);
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "StatusStrip";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(269, 20);
			this.toolStripStatusLabel.Text = "Create by : Zuhad Fathoni 20170140104";
			// 
			// Menu_Utama
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(843, 558);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Menu_Utama";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu Utama";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion


		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.ToolTip toolTip;
		public System.Windows.Forms.ToolStripMenuItem menu_master;
		public System.Windows.Forms.ToolStripMenuItem submenu_barang;
		public System.Windows.Forms.ToolStripMenuItem submenu_pelanggan;
		public System.Windows.Forms.ToolStripMenuItem menu_transaksi;
		public System.Windows.Forms.ToolStripMenuItem submenu_penjualan;
	}
}



