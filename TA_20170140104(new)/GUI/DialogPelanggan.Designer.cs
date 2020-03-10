namespace TA_20170140104_new_.GUI
{
	partial class DialogPelanggan
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox_cari = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView_pelanggan = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_pelanggan)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView_pelanggan);
			this.groupBox1.Controls.Add(this.textBox_cari);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(776, 368);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Data Pelanggan";
			// 
			// textBox_cari
			// 
			this.textBox_cari.Location = new System.Drawing.Point(167, 38);
			this.textBox_cari.Name = "textBox_cari";
			this.textBox_cari.Size = new System.Drawing.Size(590, 22);
			this.textBox_cari.TabIndex = 3;
			this.textBox_cari.TextChanged += new System.EventHandler(this.textBox_cari_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Cari Barang";
			// 
			// dataGridView_pelanggan
			// 
			this.dataGridView_pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_pelanggan.Location = new System.Drawing.Point(18, 76);
			this.dataGridView_pelanggan.Name = "dataGridView_pelanggan";
			this.dataGridView_pelanggan.RowTemplate.Height = 24;
			this.dataGridView_pelanggan.Size = new System.Drawing.Size(740, 272);
			this.dataGridView_pelanggan.TabIndex = 4;
			this.dataGridView_pelanggan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_pelanggan_CellDoubleClick);
			// 
			// DialogPelanggan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DialogPelanggan";
			this.Text = "Cari Pelanggan";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_pelanggan)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView_pelanggan;
		private System.Windows.Forms.TextBox textBox_cari;
		private System.Windows.Forms.Label label1;
	}
}