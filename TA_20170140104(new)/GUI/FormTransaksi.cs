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
	/// <summary>
	/// Class <c>FormTransaksi</c> form untuk transaksi pembelian barang
	/// </summary>

	public partial class FormTransaksi : Form
	{

		Kelas.Koneksi konn = new Kelas.Koneksi();

		/// <summary>
		/// <c>clear</c> membuat halaman awal kosong dan tidak berisi
		/// </summary>

		private void clear()
		{
			textBox_nokwitansi.Text = "";
			dateTimePicker_kwitansi.Value = DateTime.Now;
			textBox_idpelanggan.Text = "";
			textBox_namapelanggan.Text = "";
			textBox_kodebarang.Text = "";
			textBox_namabarang.Text = "";
			textBox_warna.Text = "";
			textBox_ukuran.Text = "";
			textBox_harga.Text = "0";
			textBox_jumlah.Text = "0";
			textBox_idpelanggan.Enabled = false;
			textBox_namapelanggan.Enabled = false;
			textBox_kodebarang.Enabled = false;
			textBox_namabarang.Enabled = false;
			textBox_warna.Enabled = false;
			textBox_ukuran.Enabled = false;
			textBox_harga.Enabled = false;
			button_minus.Enabled = false;
			button_simpan.Enabled = false;
			textBox_total.Enabled = false;
			textBox_kembali.Enabled = false;
			textBox_bayar.Text = "";
			textBox_total.Text = "";
			textBox_kembali.Text = "";

		}

		private void awal()
		{
			clear();
			SqlConnection conn = konn.GetConn();
			{
				try
				{
					conn.Open();
					cmd = new SqlCommand("select * from vw_penjualan order by NoKwitansi DESC", conn);
					ds = new DataSet();
					da = new SqlDataAdapter(cmd);
					da.Fill(ds, "vw_penjualan");
					dataGridView_transaksi.DataSource = ds;
					dataGridView_transaksi.DataMember = "vw_penjualan";
					dataGridView_transaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
					dataGridView_transaksi.AllowUserToAddRows = false;
					dataGridView_transaksi.Refresh();
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
		/// <c>auto_number</c> membuat nomer kwitansi menjadi auto atau urut
		/// </summary>
		
		private void auto_number()
		{
			long hitung; // penentukan pjg
			string urut; // urutkan
			//SqlDataReader rd;
			SqlConnection conn = konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("select NoKwitansi from tbl_penjualan where NoKwitansi in (select max(NoKwitansi) from tbl_penjualan) order by NoKwitansi desc", conn);
			rd = cmd.ExecuteReader();
			rd.Read();
			if (rd.HasRows)
			{
				hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["NoKwitansi"].ToString().Length - 12, 4)) + 1;
				string joinstr = "0000" + hitung;
				urut = "Trx" + joinstr.Substring(joinstr.Length - 4, 4) + "/" + DateTime.Now.ToString ("MM/yyyy"); //convert ambil 3 angka
			}
			else
			{
				urut = "Trx-001/" + DateTime.Now.ToString("MM/yyyy");
			}
			rd.Close();
			textBox_nokwitansi.Enabled = false;
			textBox_nokwitansi.Text = urut;
			conn.Close();
		}

		private void Simpan_MasterPenjualan()
		{
			SqlConnection conn = konn.GetConn();
			{
				cmd = new SqlCommand("insert into tbl_penjualan values('" + textBox_nokwitansi.Text + "', '" + dateTimePicker_kwitansi.Text + "', '" + textBox_idpelanggan.Text + "')", conn);
				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}

		private void Simpan_DetailPenjualan()
		{
			SqlConnection conn = konn.GetConn();
			{
				cmd = new SqlCommand("insert into tbl_dtlPenjualan values('" + textBox_nokwitansi.Text + "','" + textBox_kodebarang.Text + "','" + textBox_jumlah.Text + "')", conn);
				conn.Open();
				cmd.ExecuteNonQuery();
			}
		}

		private void refresh_penjualan()
		{
			SqlConnection conn = konn.GetConn();
			{
				try
				{
					conn.Open();
					cmd = new SqlCommand("select * from vw_detail where NoKwitansi = '"+ textBox_nokwitansi.Text +"'", conn);
					ds = new DataSet();
					da = new SqlDataAdapter(cmd);
					da.Fill(ds, "vw_detail");
					dataGridView_transaksi.DataSource = ds;
					dataGridView_transaksi.DataMember = "vw_detail";
					dataGridView_transaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
					dataGridView_transaksi.AllowUserToAddRows = false;
					dataGridView_transaksi.Refresh();
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

		private void RefreshTransaksi()
		{
			refresh_penjualan();
			textBox_kodebarang.Clear();
			textBox_namabarang.Clear();
			textBox_warna.Clear();
			textBox_ukuran.Clear();
			textBox_harga.Text = "0";
			textBox_jumlah.Text = "0";
			textBox_jumlah.Focus();

		}

		/// <summary>
		/// untuk menjumlah total harga belanjaan
		/// </summary>


		private void totalseluruh()
		{
			SqlConnection conn = konn.GetConn();
			{
				conn.Open();
				cmd = new SqlCommand("select sum(Harga*Jumlah) as TotalBayar from vw_detail where NoKwitansi= '" + textBox_nokwitansi.Text + "'", conn);
				cmd.Connection = conn;
				int result = (int)cmd.ExecuteScalar();
				String TotalSeluruh = result.ToString();
				textBox_total.Text = result.ToString();
				conn.Close();
			}
		}



		public FormTransaksi()
		{
			InitializeComponent();
			awal();
			auto_number();
		}

		private SqlCommand cmd;
		private SqlDataReader rd;
		private DataSet ds;
		private SqlDataAdapter da;


		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		/// <summary>
		/// button untuk mencari nama pelanggan
		/// </summary>
		/// <param name="sender"><c>object sender</c> parameter yang disebut Pengirim yang berisi referensi ke kontrol / objek yang mengangkat peristiwa.</param>
		/// <param name="e"><c>EventArgs e</c> parameter yang disebut e yang berisi data peristiwa.</param>


		private void button_caripelanggan_Click(object sender, EventArgs e)
		{
			DialogPelanggan plgn = new DialogPelanggan();
			plgn.ShowDialog();
			textBox_idpelanggan.Text = plgn.ambil_id_pelanggan;
			textBox_namapelanggan.Text = plgn.ambil_nama_pelanggan;
			
		}


		/// <summary>
		/// button untuk mencari nama pelanggan
		/// </summary>
		/// <param name="sender"><c>object sender</c> parameter yang disebut Pengirim yang berisi referensi ke kontrol / objek yang mengangkat peristiwa.</param>
		/// <param name="e"><c>EventArgs e</c> parameter yang disebut e yang berisi data peristiwa.</param>

		private void button_caribarang_Click(object sender, EventArgs e)
		{
			DialogBarang brg = new DialogBarang();
			brg.ShowDialog();
			textBox_kodebarang.Text = brg.ambil_kode_barang;
			textBox_namabarang.Text = brg.ambil_nama_barang;
			textBox_warna.Text = brg.ambil_warna;
			textBox_ukuran.Text = brg.ambil_ukuran;
			textBox_harga.Text = brg.ambil_harga;
		}


		/// <summary>
		/// buttom untuk menambah data transaksi baru
		/// </summary>
		/// <param name="sender"><c>object sender</c> parameter yang disebut Pengirim yang berisi referensi ke kontrol / objek yang mengangkat peristiwa.</param>
		/// <param name="e"><c>EventArgs e</c> parameter yang disebut e yang berisi data peristiwa.</param>


		private void button_baru_Click(object sender, EventArgs e)
		{
			awal();
			auto_number();
			dateTimePicker_kwitansi.Focus();
			button_caripelanggan.Enabled = true;
		}

		/// <summary>
		/// buttom untuk menambah data barang
		/// </summary>
		/// <param name="sender"><c>object sender</c> parameter yang disebut Pengirim yang berisi referensi ke kontrol / objek yang mengangkat peristiwa.</param>
		/// <param name="e"><c>EventArgs e</c> parameter yang disebut e yang berisi data peristiwa.</param>


		private void button_plus_Click(object sender, EventArgs e)
		{
			SqlDataReader reader = null;
			SqlConnection conn = konn.GetConn();
			{
				if (textBox_nokwitansi.Text.Trim()== "" || textBox_idpelanggan.Text.Trim() == "" || textBox_kodebarang.Text.Trim() == "" || textBox_jumlah.Text.Trim() == "" )
				{
					MessageBox.Show("Data Belum Lengkap", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					conn.Open();
					cmd = new SqlCommand("select * from tbl_penjualan where NoKwitansi = '" + textBox_nokwitansi.Text + "'", conn);
					cmd.ExecuteNonQuery();
					reader = cmd.ExecuteReader();
					if (reader.Read())
					{
						Simpan_DetailPenjualan();
						totalseluruh();
						
					}
					else
					{
						Simpan_MasterPenjualan();
						Simpan_DetailPenjualan();
						totalseluruh();
						
					}
					button_caripelanggan.Enabled = false;
					button_simpan.Enabled = true;
					RefreshTransaksi();
				}
			}
		}

		/// <summary>
		/// menampilkan data transaksi yang sudah dibuat
		/// </summary>
		/// <param name="sender"><c>object sender</c> parameter yang disebut Pengirim yang berisi referensi ke kontrol / objek yang mengangkat peristiwa.</param>
		/// <param name="e"><c>EventArgs e</c> parameter yang disebut e yang berisi data peristiwa.</param>


		private void dataGridView_transaksi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			button_plus.Enabled = false;
			button_minus.Enabled = true;
			DataGridViewRow row = this.dataGridView_transaksi.Rows[e.RowIndex];
			textBox_kodebarang.Text = row.Cells["KodeBarang"].Value.ToString();
			textBox_namabarang.Text = row.Cells["NamaBarang"].Value.ToString();
			textBox_warna.Text = row.Cells["Warna"].Value.ToString();
			textBox_ukuran.Text = row.Cells["Ukuran"].Value.ToString();
			textBox_harga.Text = row.Cells["Harga"].Value.ToString();
			textBox_jumlah.Text = row.Cells["Jumlah"].Value.ToString();
		}

		/// <summary>
		/// buttom untuk mengurangi/menghapus data barang
		/// </summary>
		/// <param name="sender"><c>object sender</c> parameter yang disebut Pengirim yang berisi referensi ke kontrol / objek yang mengangkat peristiwa.</param>
		/// <param name="e"><c>EventArgs e</c> parameter yang disebut e yang berisi data peristiwa.</param>


		private void button_minus_Click(object sender, EventArgs e)
		{
			SqlConnection conn = konn.GetConn();
			{
				conn.Open();
				cmd = new SqlCommand("DELETE from tbl_dtlPenjualan where NoKwitansi = '" + textBox_nokwitansi.Text + "' AND KodeBarang = '" + textBox_kodebarang.Text + "'", conn);
				
				cmd.ExecuteNonQuery();
				totalseluruh();
				MessageBox.Show("Berhasil");
				
				RefreshTransaksi();
				button_plus.Enabled = true;
				button_minus.Enabled = false;
			}
		}

		/// <summary>
		/// buttom untuk menyimpan data
		/// </summary>
		/// <param name="sender"><c>object sender</c> parameter yang disebut Pengirim yang berisi referensi ke kontrol / objek yang mengangkat peristiwa.</param>
		/// <param name="e"><c>EventArgs e</c> parameter yang disebut e yang berisi data peristiwa.</param>


		private void button_simpan_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Transaksi Selesai");

			awal();
			textBox_total.Text = "";
			button_caripelanggan.Enabled = true;
			auto_number();
			clear();
		}

		private void textBox_total_KeyPress(object sender, KeyPressEventArgs e)
		{

		}

		private void textBox_kembali_TextChanged(object sender, EventArgs e)
		{
			
		}

		/// <summary>
		/// <c>textBox_bayar</c> 
		/// </summary>
		/// <param name="sender"><c>object sender</c> parameter yang disebut Pengirim yang berisi referensi ke kontrol / objek yang mengangkat peristiwa.</param>
		/// <param name="e"><c>EventArgs e</c> parameter yang disebut e yang berisi data peristiwa.</param>


		private void textBox_bayar_TextChanged(object sender, EventArgs e)
		{
			kembalian();
		}


		void kembalian()
		{
			Double total, bayar,  kembali;
			total = Double.Parse(textBox_total.Text);
			bayar = Double.Parse(textBox_bayar.Text);
			//string tot = Convert.ToString(total);
			//kembali = total - bayar;

			if (bayar >= total)
			{
				kembali = bayar - total;
				textBox_kembali.Text = "Rp. " + kembali.ToString();
			}
			else
			{
				textBox_kembali.Text = "Rp. -" + (total - bayar);
			}
		}

		private void textBox_total_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
