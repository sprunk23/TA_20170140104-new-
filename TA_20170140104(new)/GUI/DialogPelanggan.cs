﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
/// <summary>
/// tugas sqta
/// </summary>
namespace TA_20170140104_new_.GUI
{
    /// <summary>
    /// kelas pelangan untuk menulis perintah query, menampilkan data, dan mengeksekusi perintah query
    /// </summary>
	public partial class DialogPelanggan : Form
	{
		private SqlCommand cmd;
		private DataSet ds;
		private SqlDataAdapter da;
        /// <summary>
        /// untuk menampilkan id pelanggan
        /// </summary>
        public string idpelanggan = "";
        /// <summary>
        /// untuk menampilkan nama pelanggan
        /// </summary>
        public string namapelanggan = "";
        /// <summary>
        /// untuk menampilkan alamat pelanggan
        /// </summary>
        public string alamat = "";
        /// <summary>
        /// untuk nenampilkan no tlp pelanggan
        /// </summary>
        public string notelpon = "";

		Kelas.Koneksi konn = new Kelas.Koneksi();

		void refresh_pelanggan()
		{
			SqlConnection conn = konn.GetConn();
			{
				try
				{
					conn.Open();
					cmd = new SqlCommand("select * from tbl_pelanggan", conn);
					ds = new DataSet();
					da = new SqlDataAdapter(cmd);
					da.Fill(ds, "tbl_pelanggan");
					dataGridView_pelanggan.DataSource = ds;
					dataGridView_pelanggan.DataMember = "tbl_pelanggan";
					dataGridView_pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
					dataGridView_pelanggan.AllowUserToAddRows = false;
					dataGridView_pelanggan.Refresh();
				}
				catch (Exception e)
				{
					MessageBox.Show(e.ToString());
				}
				finally
				{
					conn.Close();
				}
			}
		}

		void cari_pelanggan()
		{
			SqlConnection conn = konn.GetConn();
			{
				try
				{
					conn.Open();
					cmd = new SqlCommand("select * from tbl_pelanggan where IdPelanggan like '%" + textBox_cari.Text + "%' or NamaPelanggan like '%" + textBox_cari + "%'", conn);
					ds = new DataSet();
					da = new SqlDataAdapter(cmd);
					da.Fill(ds, "tbl_pelanggan");
					dataGridView_pelanggan.DataSource = ds;
					dataGridView_pelanggan.DataMember = "tbl_pelanggan";
					dataGridView_pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
					dataGridView_pelanggan.AllowUserToAddRows = false;
					dataGridView_pelanggan.Refresh();
				}
				catch (Exception e)
				{
					MessageBox.Show(e.ToString());
				}
				finally
				{
					conn.Close();
				}
			}
		}

		private void textBox_cari_TextChanged(object sender, EventArgs e)
		{
			cari_pelanggan();
		}

		private void dataGridView_pelanggan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridViewRow row = this.dataGridView_pelanggan.Rows[e.RowIndex];
				idpelanggan = row.Cells["IdPelanggan"].Value.ToString();
				namapelanggan = row.Cells["NamaPelanggan"].Value.ToString();
				alamat = row.Cells["Alamat"].Value.ToString();
				notelpon = row.Cells["NoTelepon"].Value.ToString();
				this.Close();
			}
			catch (Exception x)
			{
				MessageBox.Show(x.ToString());
			}
		}
        /// <summary>
        ///  ketika user klick id pelanggan maka akan muncul di texbox class from transaksi tentang id pelanggan tersebut
        /// </summary>
		public String ambil_id_pelanggan
		{
			get
			{
				return idpelanggan;
			}
		}
        /// <summary>
        /// ketika user klick nama pelanggan maka akan muncul di texbox class from transaksi tentang id pelanggan tersebut
        /// </summary>
        public String ambil_nama_pelanggan
		{
			get
			{
				return namapelanggan;
			}
		}
        /// <summary>
        /// ketika user klick alamat pelanggan maka akan muncul di texbox class from transaksi tentang id pelanggan tersebut
        /// </summary>
		public String ambil_alamat
		{
			get
			{
				return alamat;
			}
		}
        /// <summary>
        /// ketika user klick notelp pelanggan maka akan muncul di texbox class from transaksi tentang id pelanggan tersebut
        /// </summary>
		public String ambil_no_telpon
		{
			get
			{
				return notelpon;
			}
		}

		public DialogPelanggan()
		{
			InitializeComponent();
			refresh_pelanggan();
			
		}
	}
}
