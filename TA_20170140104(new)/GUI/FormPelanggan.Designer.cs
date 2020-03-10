namespace TA_20170140104_new_.GUI
{
	partial class FormPelanggan
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPelanggan));
			this.groupBox_form = new System.Windows.Forms.GroupBox();
			this.button_hapus = new System.Windows.Forms.Button();
			this.button_ubah = new System.Windows.Forms.Button();
			this.button_simpan = new System.Windows.Forms.Button();
			this.button_baru = new System.Windows.Forms.Button();
			this.textBox_notelpon = new System.Windows.Forms.TextBox();
			this.textBox_alamat = new System.Windows.Forms.TextBox();
			this.textBox_namapelanggan = new System.Windows.Forms.TextBox();
			this.textBox_idpelanggan = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox_data = new System.Windows.Forms.GroupBox();
			this.dataGridView_pelanggan = new System.Windows.Forms.DataGridView();
			this.textBox_cari = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox_form.SuspendLayout();
			this.groupBox_data.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_pelanggan)).BeginInit();
			this.SuspendLayout();
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
			this.groupBox_form.Controls.Add(this.textBox_notelpon);
			this.groupBox_form.Controls.Add(this.textBox_alamat);
			this.groupBox_form.Controls.Add(this.textBox_namapelanggan);
			this.groupBox_form.Controls.Add(this.textBox_idpelanggan);
			this.groupBox_form.Controls.Add(this.label5);
			this.groupBox_form.Controls.Add(this.label3);
			this.groupBox_form.Controls.Add(this.label2);
			this.groupBox_form.Controls.Add(this.label1);
			this.groupBox_form.Font = new System.Drawing.Font("Oswald", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_form.Location = new System.Drawing.Point(12, 12);
			this.groupBox_form.Name = "groupBox_form";
			this.groupBox_form.Size = new System.Drawing.Size(382, 426);
			this.groupBox_form.TabIndex = 5;
			this.groupBox_form.TabStop = false;
			this.groupBox_form.Text = "Form Pelanggan";
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
			// textBox_notelpon
			// 
			this.textBox_notelpon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_notelpon.Location = new System.Drawing.Point(130, 245);
			this.textBox_notelpon.Name = "textBox_notelpon";
			this.textBox_notelpon.Size = new System.Drawing.Size(238, 22);
			this.textBox_notelpon.TabIndex = 11;
			// 
			// textBox_alamat
			// 
			this.textBox_alamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_alamat.Location = new System.Drawing.Point(130, 133);
			this.textBox_alamat.Multiline = true;
			this.textBox_alamat.Name = "textBox_alamat";
			this.textBox_alamat.Size = new System.Drawing.Size(238, 100);
			this.textBox_alamat.TabIndex = 10;
			// 
			// textBox_namapelanggan
			// 
			this.textBox_namapelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_namapelanggan.Location = new System.Drawing.Point(130, 101);
			this.textBox_namapelanggan.Name = "textBox_namapelanggan";
			this.textBox_namapelanggan.Size = new System.Drawing.Size(238, 22);
			this.textBox_namapelanggan.TabIndex = 8;
			// 
			// textBox_idpelanggan
			// 
			this.textBox_idpelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_idpelanggan.Location = new System.Drawing.Point(130, 67);
			this.textBox_idpelanggan.Name = "textBox_idpelanggan";
			this.textBox_idpelanggan.Size = new System.Drawing.Size(238, 22);
			this.textBox_idpelanggan.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(15, 245);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 17);
			this.label5.TabIndex = 5;
			this.label5.Text = "No Telepon";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Alamat";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nama Pelanggan";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Id Pelanggan";
			// 
			// groupBox_data
			// 
			this.groupBox_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox_data.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox_data.Controls.Add(this.dataGridView_pelanggan);
			this.groupBox_data.Controls.Add(this.textBox_cari);
			this.groupBox_data.Controls.Add(this.label7);
			this.groupBox_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox_data.Location = new System.Drawing.Point(400, 12);
			this.groupBox_data.Name = "groupBox_data";
			this.groupBox_data.Size = new System.Drawing.Size(388, 426);
			this.groupBox_data.TabIndex = 4;
			this.groupBox_data.TabStop = false;
			this.groupBox_data.Text = "Data Pelanggan";
			// 
			// dataGridView_pelanggan
			// 
			this.dataGridView_pelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView_pelanggan.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView_pelanggan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView_pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView_pelanggan.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_pelanggan.Location = new System.Drawing.Point(11, 101);
			this.dataGridView_pelanggan.Name = "dataGridView_pelanggan";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView_pelanggan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView_pelanggan.RowTemplate.Height = 24;
			this.dataGridView_pelanggan.Size = new System.Drawing.Size(364, 304);
			this.dataGridView_pelanggan.TabIndex = 2;
			this.dataGridView_pelanggan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_pelanggan_CellClick);
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
			this.textBox_cari.TextChanged += new System.EventHandler(this.textBox_cari_TextChanged);
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
			// FormPelanggan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBox_form);
			this.Controls.Add(this.groupBox_data);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormPelanggan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form Pelanggan";
			this.groupBox_form.ResumeLayout(false);
			this.groupBox_form.PerformLayout();
			this.groupBox_data.ResumeLayout(false);
			this.groupBox_data.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_pelanggan)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox_form;
		private System.Windows.Forms.Button button_hapus;
		private System.Windows.Forms.Button button_ubah;
		private System.Windows.Forms.Button button_simpan;
		private System.Windows.Forms.Button button_baru;
		private System.Windows.Forms.TextBox textBox_notelpon;
		private System.Windows.Forms.TextBox textBox_alamat;
		private System.Windows.Forms.TextBox textBox_namapelanggan;
		private System.Windows.Forms.TextBox textBox_idpelanggan;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox_data;
		public System.Windows.Forms.DataGridView dataGridView_pelanggan;
		private System.Windows.Forms.TextBox textBox_cari;
		private System.Windows.Forms.Label label7;
	}
}