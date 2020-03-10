using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TA_20170140104_new_.GUI
{
	public partial class DialogBarang : Form
	{
		private SqlCommand cmd;
		private DataSet ds;
		private SqlDataAdapter da;
		public string kodebarang, namabarang, warna, ukuran, harga = "";

		private void textBox_cari_TextChanged(object sender, EventArgs e)
		{
			cari_barang();
		}

        /// <summary>
        /// untuk menampilkan data berupa tabel 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void dataGridView_barang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridViewRow row = this.dataGridView_barang.Rows[e.RowIndex];
				kodebarang = row.Cells["KodeBarang"].Value.ToString();
				namabarang = row.Cells["NamaBarang"].Value.ToString();
				warna = row.Cells["Warna"].Value.ToString();
				ukuran = row.Cells["Ukuran"].Value.ToString();
				harga = row.Cells["Harga"].Value.ToString();
				this.Close();
			}
			catch (Exception x)
			{
				MessageBox.Show(x.ToString());
			}
		}

		Kelas.Koneksi konn = new Kelas.Koneksi();

		void refresh_barang()
		{
			SqlConnection conn = konn.GetConn();
			{
				try
				{
					conn.Open();
					cmd = new SqlCommand("select * from tbl_barang", conn);
					ds = new DataSet();
					da = new SqlDataAdapter(cmd);
					da.Fill(ds, "tbl_barang");
					dataGridView_barang.DataSource = ds;
					dataGridView_barang.DataMember = "tbl_barang";
					dataGridView_barang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
					dataGridView_barang.AllowUserToAddRows = false;
					dataGridView_barang.Refresh();
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

		void cari_barang()
		{
			SqlConnection conn = konn.GetConn();
			{
				try
				{
					conn.Open();
					cmd = new SqlCommand("select * from tbl_barang where KodeBarang like '%" + textBox_cari.Text + "%' or NamaBarang like '%" + textBox_cari + "%'", conn);
					ds = new DataSet();
					da = new SqlDataAdapter(cmd);
					da.Fill(ds, "tbl_barang");
					dataGridView_barang.DataSource = ds;
					dataGridView_barang.DataMember = "tbl_barang";
					dataGridView_barang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
					dataGridView_barang.AllowUserToAddRows = false;
					dataGridView_barang.Refresh();
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
        /// <summary>
        /// untuk mengambil barang
        /// </summary>
		public DialogBarang()
		{
			InitializeComponent();
			refresh_barang();
		}

		public String ambil_kode_barang
		{
			get
			{
				return kodebarang;
			}
		}

		public String ambil_nama_barang
		{
			get
			{
				return namabarang;
			}
		}

		public String ambil_warna
		{
			get
			{
				return warna;
			}
		}

		public String ambil_ukuran
		{
			get
			{
				return ukuran;
			}
		}

		public String ambil_harga
		{
			get
			{
				return harga;
			}
		}
	}
}
