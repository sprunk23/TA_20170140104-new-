namespace TA_20170140104_new_.GUI
{
	partial class FormTransaksi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransaksi));
			this.dataGridView_transaksi = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button_caripelanggan = new System.Windows.Forms.Button();
			this.textBox_ukuran = new System.Windows.Forms.TextBox();
			this.textBox_warna = new System.Windows.Forms.TextBox();
			this.dateTimePicker_kwitansi = new System.Windows.Forms.DateTimePicker();
			this.textBox_nokwitansi = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.button_caribarang = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.textBox_idpelanggan = new System.Windows.Forms.TextBox();
			this.textBox_namapelanggan = new System.Windows.Forms.TextBox();
			this.textBox_kodebarang = new System.Windows.Forms.TextBox();
			this.textBox_harga = new System.Windows.Forms.TextBox();
			this.textBox_jumlah = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox_namabarang = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_kembali = new System.Windows.Forms.TextBox();
			this.textBox_bayar = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox_total = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button_minus = new System.Windows.Forms.Button();
			this.button_plus = new System.Windows.Forms.Button();
			this.button_baru = new System.Windows.Forms.Button();
			this.button_simpan = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_transaksi)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView_transaksi
			// 
			this.dataGridView_transaksi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView_transaksi.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_transaksi.Location = new System.Drawing.Point(14, 180);
			this.dataGridView_transaksi.Name = "dataGridView_transaksi";
			this.dataGridView_transaksi.RowTemplate.Height = 24;
			this.dataGridView_transaksi.Size = new System.Drawing.Size(778, 167);
			this.dataGridView_transaksi.TabIndex = 29;
			this.dataGridView_transaksi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_transaksi_CellDoubleClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox1.Controls.Add(this.button_caripelanggan);
			this.groupBox1.Controls.Add(this.textBox_ukuran);
			this.groupBox1.Controls.Add(this.textBox_warna);
			this.groupBox1.Controls.Add(this.dateTimePicker_kwitansi);
			this.groupBox1.Controls.Add(this.textBox_nokwitansi);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.button_caribarang);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.textBox_idpelanggan);
			this.groupBox1.Controls.Add(this.textBox_namapelanggan);
			this.groupBox1.Controls.Add(this.textBox_kodebarang);
			this.groupBox1.Controls.Add(this.textBox_harga);
			this.groupBox1.Controls.Add(this.textBox_jumlah);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textBox_namabarang);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(780, 170);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Transaksi";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// button_caripelanggan
			// 
			this.button_caripelanggan.BackColor = System.Drawing.Color.White;
			this.button_caripelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_caripelanggan.Image = global::TA_20170140104_new_.Properties.Resources.search16;
			this.button_caripelanggan.Location = new System.Drawing.Point(249, 30);
			this.button_caripelanggan.Name = "button_caripelanggan";
			this.button_caripelanggan.Size = new System.Drawing.Size(35, 29);
			this.button_caripelanggan.TabIndex = 41;
			this.button_caripelanggan.UseVisualStyleBackColor = false;
			this.button_caripelanggan.Click += new System.EventHandler(this.button_caripelanggan_Click);
			// 
			// textBox_ukuran
			// 
			this.textBox_ukuran.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_ukuran.Location = new System.Drawing.Point(414, 134);
			this.textBox_ukuran.Name = "textBox_ukuran";
			this.textBox_ukuran.Size = new System.Drawing.Size(57, 22);
			this.textBox_ukuran.TabIndex = 40;
			// 
			// textBox_warna
			// 
			this.textBox_warna.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_warna.Location = new System.Drawing.Point(325, 134);
			this.textBox_warna.Name = "textBox_warna";
			this.textBox_warna.Size = new System.Drawing.Size(83, 22);
			this.textBox_warna.TabIndex = 39;
			// 
			// dateTimePicker_kwitansi
			// 
			this.dateTimePicker_kwitansi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker_kwitansi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker_kwitansi.Location = new System.Drawing.Point(614, 63);
			this.dateTimePicker_kwitansi.Name = "dateTimePicker_kwitansi";
			this.dateTimePicker_kwitansi.Size = new System.Drawing.Size(160, 22);
			this.dateTimePicker_kwitansi.TabIndex = 37;
			// 
			// textBox_nokwitansi
			// 
			this.textBox_nokwitansi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_nokwitansi.Location = new System.Drawing.Point(614, 36);
			this.textBox_nokwitansi.Name = "textBox_nokwitansi";
			this.textBox_nokwitansi.Size = new System.Drawing.Size(160, 22);
			this.textBox_nokwitansi.TabIndex = 36;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(516, 63);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(60, 17);
			this.label12.TabIndex = 35;
			this.label12.Text = "Tanggal";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(516, 39);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(81, 17);
			this.label11.TabIndex = 34;
			this.label11.Text = "No Kwitansi";
			// 
			// button_caribarang
			// 
			this.button_caribarang.BackColor = System.Drawing.Color.White;
			this.button_caribarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_caribarang.Image = global::TA_20170140104_new_.Properties.Resources.search16;
			this.button_caribarang.Location = new System.Drawing.Point(6, 133);
			this.button_caribarang.Name = "button_caribarang";
			this.button_caribarang.Size = new System.Drawing.Size(35, 29);
			this.button_caribarang.TabIndex = 29;
			this.button_caribarang.UseVisualStyleBackColor = false;
			this.button_caribarang.Click += new System.EventHandler(this.button_caribarang_Click);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(9, 41);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(93, 17);
			this.label14.TabIndex = 28;
			this.label14.Text = "ID Pelanggan";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(9, 70);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(116, 17);
			this.label13.TabIndex = 27;
			this.label13.Text = "Nama pelanggan";
			// 
			// textBox_idpelanggan
			// 
			this.textBox_idpelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_idpelanggan.Location = new System.Drawing.Point(138, 36);
			this.textBox_idpelanggan.Name = "textBox_idpelanggan";
			this.textBox_idpelanggan.Size = new System.Drawing.Size(105, 22);
			this.textBox_idpelanggan.TabIndex = 26;
			// 
			// textBox_namapelanggan
			// 
			this.textBox_namapelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_namapelanggan.Location = new System.Drawing.Point(138, 65);
			this.textBox_namapelanggan.Name = "textBox_namapelanggan";
			this.textBox_namapelanggan.Size = new System.Drawing.Size(146, 22);
			this.textBox_namapelanggan.TabIndex = 25;
			// 
			// textBox_kodebarang
			// 
			this.textBox_kodebarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_kodebarang.Location = new System.Drawing.Point(47, 136);
			this.textBox_kodebarang.Name = "textBox_kodebarang";
			this.textBox_kodebarang.Size = new System.Drawing.Size(88, 22);
			this.textBox_kodebarang.TabIndex = 24;
			// 
			// textBox_harga
			// 
			this.textBox_harga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_harga.Location = new System.Drawing.Point(476, 133);
			this.textBox_harga.Name = "textBox_harga";
			this.textBox_harga.Size = new System.Drawing.Size(135, 22);
			this.textBox_harga.TabIndex = 20;
			// 
			// textBox_jumlah
			// 
			this.textBox_jumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_jumlah.Location = new System.Drawing.Point(614, 133);
			this.textBox_jumlah.Name = "textBox_jumlah";
			this.textBox_jumlah.Size = new System.Drawing.Size(160, 22);
			this.textBox_jumlah.TabIndex = 10;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(490, 113);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(65, 17);
			this.label9.TabIndex = 19;
			this.label9.Tag = " ";
			this.label9.Text = "Harga @";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(47, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kode Barang";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(155, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nama Barang";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(331, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Warna";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(618, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Jumlah Beli";
			// 
			// textBox_namabarang
			// 
			this.textBox_namabarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_namabarang.Location = new System.Drawing.Point(141, 135);
			this.textBox_namabarang.Name = "textBox_namabarang";
			this.textBox_namabarang.Size = new System.Drawing.Size(179, 22);
			this.textBox_namabarang.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(416, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Ukuran";
			// 
			// textBox_kembali
			// 
			this.textBox_kembali.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.textBox_kembali.Location = new System.Drawing.Point(626, 421);
			this.textBox_kembali.Name = "textBox_kembali";
			this.textBox_kembali.Size = new System.Drawing.Size(156, 22);
			this.textBox_kembali.TabIndex = 25;
			this.textBox_kembali.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox_kembali.TextChanged += new System.EventHandler(this.textBox_kembali_TextChanged);
			// 
			// textBox_bayar
			// 
			this.textBox_bayar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.textBox_bayar.Location = new System.Drawing.Point(626, 395);
			this.textBox_bayar.Name = "textBox_bayar";
			this.textBox_bayar.Size = new System.Drawing.Size(156, 22);
			this.textBox_bayar.TabIndex = 24;
			this.textBox_bayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox_bayar.TextChanged += new System.EventHandler(this.textBox_bayar_TextChanged);
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(512, 371);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 17);
			this.label6.TabIndex = 26;
			this.label6.Text = "Total";
			// 
			// textBox_total
			// 
			this.textBox_total.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.textBox_total.Location = new System.Drawing.Point(626, 368);
			this.textBox_total.Name = "textBox_total";
			this.textBox_total.Size = new System.Drawing.Size(156, 22);
			this.textBox_total.TabIndex = 23;
			this.textBox_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBox_total.TextChanged += new System.EventHandler(this.textBox_total_TextChanged);
			this.textBox_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_total_KeyPress);
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(512, 398);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 17);
			this.label7.TabIndex = 27;
			this.label7.Text = "Pembayaran";
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(512, 424);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(98, 17);
			this.label8.TabIndex = 28;
			this.label8.Text = "Pengembalian";
			// 
			// button_minus
			// 
			this.button_minus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button_minus.BackColor = System.Drawing.Color.White;
			this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_minus.Location = new System.Drawing.Point(95, 368);
			this.button_minus.Name = "button_minus";
			this.button_minus.Size = new System.Drawing.Size(75, 23);
			this.button_minus.TabIndex = 22;
			this.button_minus.Text = "-";
			this.button_minus.UseVisualStyleBackColor = false;
			this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
			// 
			// button_plus
			// 
			this.button_plus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button_plus.BackColor = System.Drawing.Color.White;
			this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_plus.Location = new System.Drawing.Point(14, 368);
			this.button_plus.Name = "button_plus";
			this.button_plus.Size = new System.Drawing.Size(75, 23);
			this.button_plus.TabIndex = 21;
			this.button_plus.Text = "+";
			this.button_plus.UseVisualStyleBackColor = false;
			this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
			// 
			// button_baru
			// 
			this.button_baru.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button_baru.BackColor = System.Drawing.Color.White;
			this.button_baru.Location = new System.Drawing.Point(14, 398);
			this.button_baru.Name = "button_baru";
			this.button_baru.Size = new System.Drawing.Size(75, 43);
			this.button_baru.TabIndex = 30;
			this.button_baru.Text = "Baru";
			this.button_baru.UseVisualStyleBackColor = false;
			this.button_baru.Click += new System.EventHandler(this.button_baru_Click);
			// 
			// button_simpan
			// 
			this.button_simpan.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button_simpan.BackColor = System.Drawing.Color.White;
			this.button_simpan.Location = new System.Drawing.Point(95, 398);
			this.button_simpan.Name = "button_simpan";
			this.button_simpan.Size = new System.Drawing.Size(75, 43);
			this.button_simpan.TabIndex = 31;
			this.button_simpan.Text = "Simpan";
			this.button_simpan.UseVisualStyleBackColor = false;
			this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
			// 
			// FormTransaksi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button_simpan);
			this.Controls.Add(this.button_baru);
			this.Controls.Add(this.button_plus);
			this.Controls.Add(this.button_minus);
			this.Controls.Add(this.dataGridView_transaksi);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox_total);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox_bayar);
			this.Controls.Add(this.textBox_kembali);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormTransaksi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form Transaksi";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_transaksi)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dataGridView_transaksi;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox_harga;
		private System.Windows.Forms.TextBox textBox_jumlah;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox_namabarang;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_kodebarang;
		private System.Windows.Forms.Button button_caripelanggan;
		private System.Windows.Forms.TextBox textBox_ukuran;
		private System.Windows.Forms.TextBox textBox_warna;
		private System.Windows.Forms.DateTimePicker dateTimePicker_kwitansi;
		private System.Windows.Forms.TextBox textBox_nokwitansi;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button button_caribarang;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBox_idpelanggan;
		private System.Windows.Forms.TextBox textBox_namapelanggan;
		private System.Windows.Forms.TextBox textBox_kembali;
		private System.Windows.Forms.TextBox textBox_bayar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox_total;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button_minus;
		private System.Windows.Forms.Button button_plus;
		private System.Windows.Forms.Button button_baru;
		private System.Windows.Forms.Button button_simpan;
	}
}