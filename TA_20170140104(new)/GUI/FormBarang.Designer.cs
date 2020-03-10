namespace TA_20170140104_new_.GUI
{
	partial class FormBarang
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBarang));
			this.groupBox_data = new System.Windows.Forms.GroupBox();
			this.dataGridView_barang = new System.Windows.Forms.DataGridView();
			this.textBox_cari = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox_form = new System.Windows.Forms.GroupBox();
			this.button_hapus = new System.Windows.Forms.Button();
			this.button_ubah = new System.Windows.Forms.Button();
			this.button_simpan = new System.Windows.Forms.Button();
			this.button_baru = new System.Windows.Forms.Button();
			this.textBox_harga = new System.Windows.Forms.TextBox();
			this.textBox_stok = new System.Windows.Forms.TextBox();
			this.textBox_warna = new System.Windows.Forms.TextBox();
			this.comboBox_ukuran = new System.Windows.Forms.ComboBox();
			this.textBox_namabarang = new System.Windows.Forms.TextBox();
			this.textBox_kodebarang = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox_data.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_barang)).BeginInit();
			this.groupBox_form.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox_data
			// 
			this.groupBox_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox_data.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox_data.Controls.Add(this.dataGridView_barang);
			this.groupBox_data.Controls.Add(this.textBox_cari);
			this.groupBox_data.Controls.Add(this.label7);
			this.groupBox_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_data.Location = new System.Drawing.Point(400, 12);
			this.groupBox_data.Name = "groupBox_data";
			this.groupBox_data.Size = new System.Drawing.Size(388, 426);
			this.groupBox_data.TabIndex = 0;
			this.groupBox_data.TabStop = false;
			this.groupBox_data.Text = "Data Barang";
			this.groupBox_data.Enter += new System.EventHandler(this.groupBox_data_Enter);
			// 
			// dataGridView_barang
			// 
			this.dataGridView_barang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView_barang.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_barang.Location = new System.Drawing.Point(11, 101);
			this.dataGridView_barang.Name = "dataGridView_barang";
			this.dataGridView_barang.RowTemplate.Height = 24;
			this.dataGridView_barang.Size = new System.Drawing.Size(364, 304);
			this.dataGridView_barang.TabIndex = 2;
			this.dataGridView_barang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_barang_CellClick);
			// 
			// textBox_cari
			// 
			this.textBox_cari.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox_cari.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_cari.Location = new System.Drawing.Point(150, 67);
			this.textBox_cari.Name = "textBox_cari";
			this.textBox_cari.Size = new System.Drawing.Size(225, 22);
			this.textBox_cari.TabIndex = 1;
			this.textBox_cari.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(15, 67);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(129, 17);
			this.label7.TabIndex = 0;
			this.label7.Text = "Cari (Kode / Nama)";
			// 
			// groupBox_form
			// 
			this.groupBox_form.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox_form.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox_form.Controls.Add(this.button_hapus);
			this.groupBox_form.Controls.Add(this.button_ubah);
			this.groupBox_form.Controls.Add(this.button_simpan);
			this.groupBox_form.Controls.Add(this.button_baru);
			this.groupBox_form.Controls.Add(this.textBox_harga);
			this.groupBox_form.Controls.Add(this.textBox_stok);
			this.groupBox_form.Controls.Add(this.textBox_warna);
			this.groupBox_form.Controls.Add(this.comboBox_ukuran);
			this.groupBox_form.Controls.Add(this.textBox_namabarang);
			this.groupBox_form.Controls.Add(this.textBox_kodebarang);
			this.groupBox_form.Controls.Add(this.label6);
			this.groupBox_form.Controls.Add(this.label5);
			this.groupBox_form.Controls.Add(this.label4);
			this.groupBox_form.Controls.Add(this.label3);
			this.groupBox_form.Controls.Add(this.label2);
			this.groupBox_form.Controls.Add(this.label1);
			this.groupBox_form.Font = new System.Drawing.Font("Oswald", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_form.Location = new System.Drawing.Point(12, 12);
			this.groupBox_form.Name = "groupBox_form";
			this.groupBox_form.Size = new System.Drawing.Size(382, 426);
			this.groupBox_form.TabIndex = 3;
			this.groupBox_form.TabStop = false;
			this.groupBox_form.Text = "Form Barang";
			// 
			// button_hapus
			// 
			this.button_hapus.BackColor = System.Drawing.Color.White;
			this.button_hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_hapus.Location = new System.Drawing.Point(196, 365);
			this.button_hapus.Name = "button_hapus";
			this.button_hapus.Size = new System.Drawing.Size(128, 40);
			this.button_hapus.TabIndex = 16;
			this.button_hapus.Text = "Delete";
			this.button_hapus.UseVisualStyleBackColor = false;
			this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
			// 
			// button_ubah
			// 
			this.button_ubah.BackColor = System.Drawing.Color.White;
			this.button_ubah.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_ubah.Location = new System.Drawing.Point(18, 365);
			this.button_ubah.Name = "button_ubah";
			this.button_ubah.Size = new System.Drawing.Size(128, 40);
			this.button_ubah.TabIndex = 15;
			this.button_ubah.Text = "Edit";
			this.button_ubah.UseVisualStyleBackColor = false;
			this.button_ubah.Click += new System.EventHandler(this.button_ubah_Click);
			// 
			// button_simpan
			// 
			this.button_simpan.BackColor = System.Drawing.Color.White;
			this.button_simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_simpan.Location = new System.Drawing.Point(196, 319);
			this.button_simpan.Name = "button_simpan";
			this.button_simpan.Size = new System.Drawing.Size(128, 40);
			this.button_simpan.TabIndex = 14;
			this.button_simpan.Text = "Simpan";
			this.button_simpan.UseVisualStyleBackColor = false;
			this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
			// 
			// button_baru
			// 
			this.button_baru.BackColor = System.Drawing.Color.White;
			this.button_baru.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_baru.Location = new System.Drawing.Point(18, 319);
			this.button_baru.Name = "button_baru";
			this.button_baru.Size = new System.Drawing.Size(128, 40);
			this.button_baru.TabIndex = 13;
			this.button_baru.Text = "Clear";
			this.button_baru.UseVisualStyleBackColor = false;
			this.button_baru.Click += new System.EventHandler(this.button_baru_Click);
			// 
			// textBox_harga
			// 
			this.textBox_harga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_harga.Location = new System.Drawing.Point(130, 234);
			this.textBox_harga.Name = "textBox_harga";
			this.textBox_harga.Size = new System.Drawing.Size(238, 22);
			this.textBox_harga.TabIndex = 12;
			// 
			// textBox_stok
			// 
			this.textBox_stok.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_stok.Location = new System.Drawing.Point(130, 203);
			this.textBox_stok.Name = "textBox_stok";
			this.textBox_stok.Size = new System.Drawing.Size(238, 22);
			this.textBox_stok.TabIndex = 11;
			// 
			// textBox_warna
			// 
			this.textBox_warna.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_warna.Location = new System.Drawing.Point(130, 133);
			this.textBox_warna.Name = "textBox_warna";
			this.textBox_warna.Size = new System.Drawing.Size(238, 22);
			this.textBox_warna.TabIndex = 10;
			// 
			// comboBox_ukuran
			// 
			this.comboBox_ukuran.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_ukuran.FormattingEnabled = true;
			this.comboBox_ukuran.Items.AddRange(new object[] {
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44"});
			this.comboBox_ukuran.Location = new System.Drawing.Point(130, 169);
			this.comboBox_ukuran.Name = "comboBox_ukuran";
			this.comboBox_ukuran.Size = new System.Drawing.Size(104, 24);
			this.comboBox_ukuran.TabIndex = 9;
			// 
			// textBox_namabarang
			// 
			this.textBox_namabarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_namabarang.Location = new System.Drawing.Point(130, 101);
			this.textBox_namabarang.Name = "textBox_namabarang";
			this.textBox_namabarang.Size = new System.Drawing.Size(238, 22);
			this.textBox_namabarang.TabIndex = 8;
			// 
			// textBox_kodebarang
			// 
			this.textBox_kodebarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_kodebarang.Location = new System.Drawing.Point(130, 67);
			this.textBox_kodebarang.Name = "textBox_kodebarang";
			this.textBox_kodebarang.Size = new System.Drawing.Size(238, 22);
			this.textBox_kodebarang.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(15, 240);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 17);
			this.label6.TabIndex = 6;
			this.label6.Text = "Harga Barang";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(15, 203);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 17);
			this.label5.TabIndex = 5;
			this.label5.Text = "Stok";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(15, 169);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 17);
			this.label4.TabIndex = 4;
			this.label4.Text = "Ukuran";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Warna";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nama Barang";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Kode Barang";
			// 
			// FormBarang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox_form);
			this.Controls.Add(this.groupBox_data);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormBarang";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form Barang";
			this.groupBox_data.ResumeLayout(false);
			this.groupBox_data.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_barang)).EndInit();
			this.groupBox_form.ResumeLayout(false);
			this.groupBox_form.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox_data;
		private System.Windows.Forms.GroupBox groupBox_form;
		private System.Windows.Forms.Button button_hapus;
		private System.Windows.Forms.Button button_ubah;
		private System.Windows.Forms.Button button_simpan;
		private System.Windows.Forms.Button button_baru;
		private System.Windows.Forms.TextBox textBox_harga;
		private System.Windows.Forms.TextBox textBox_stok;
		private System.Windows.Forms.TextBox textBox_warna;
		private System.Windows.Forms.ComboBox comboBox_ukuran;
		private System.Windows.Forms.TextBox textBox_namabarang;
		private System.Windows.Forms.TextBox textBox_kodebarang;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_cari;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.DataGridView dataGridView_barang;
	}
}