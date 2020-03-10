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
    /// kelas barang untuk menulis perintah query, menampilkan data, dan mengeksekusi perintah query
    /// </summary>
	public partial class FormBarang : Form
	{
		//variable sql
		private SqlCommand cmd; // perintah query
		private DataSet ds; //menampilkan data
		private SqlDataAdapter da; //mengeksekusi perintah query

		Kelas.Koneksi konn = new Kelas.Koneksi();
		void clear()
		{
			textBox_kodebarang.Text = "";
			textBox_namabarang.Text = "";
			textBox_warna.Text = "";
			textBox_stok.Text = "0";
			textBox_harga.Text = "0";
			textBox_cari.Text = "";
			comboBox_ukuran.Text = "-Pilih Ukuran-";
		}

		void atur_tombol(Boolean status)
		{
			button_ubah.Enabled = status;
			button_hapus.Enabled = status;
		}

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
                    ///<sumary>
                    ///data gird view
                    /// </sumary>
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

		//cari barang
		void cari_barang()
		{
			SqlConnection conn = konn.GetConn();
			{
				try
				{
					conn.Open();
					cmd = new SqlCommand("select * from tbl_barang where KodeBarang like '%"+textBox_cari.Text+"%' or NamaBarang like '%"+textBox_cari.Text+"%'",  conn);
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


		void auto_number()
		{
			long hitung; // penentukan pjg
			string urut; // urutkan
			SqlDataReader rd;
			SqlConnection conn = konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("select KodeBarang from tbl_barang where KodeBarang in (select max (KodeBarang) from tbl_barang) order by KodeBarang desc", conn);
			rd = cmd.ExecuteReader();
			rd.Read();
			if (rd.HasRows)
			{
				hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["KodeBarang"].ToString().Length - 3, 3)) + 1;
				string joinstr = "000" + hitung;
				urut = "A" + joinstr.Substring(joinstr.Length - 3, 3); //convert ambil 3 angka
			}
			else
			{
				urut = "A001";
			}
			rd.Close();
			textBox_kodebarang.Enabled = false;
			textBox_kodebarang.Text = urut;
			conn.Close();
		}
        /// <summary>
        /// form barang digunakan untuk mengeksekusi auto number refresh barang dan clear
        /// </summary>
		public FormBarang()
		{
			InitializeComponent();
			clear();
			atur_tombol(false);
			refresh_barang();
			auto_number();
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{
			cari_barang();
		}

		private void groupBox_data_Enter(object sender, EventArgs e)
		{

		}

		private void button_simpan_Click(object sender, EventArgs e)
		{
			if(textBox_kodebarang.Text.Trim()=="" || textBox_namabarang.Text.Trim()=="" || textBox_warna.Text.Trim()=="" || textBox_stok.Text.Trim()=="" || textBox_harga.Text.Trim()=="" || comboBox_ukuran.Text.Trim() == "")
			{
				MessageBox.Show("Data Belum Lengkap", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				SqlConnection conn = konn.GetConn();
				try
				{
					cmd = new SqlCommand("insert into tbl_barang values ('" +textBox_kodebarang.Text+ "', '" +textBox_namabarang.Text+ "', '" +textBox_warna.Text+ "', '" + comboBox_ukuran.Text + "', '" + textBox_stok.Text+"', '"+textBox_harga.Text+"' ) ", conn);
					conn.Open();
					cmd.ExecuteNonQuery();
					MessageBox.Show("Data Berhasil Tersimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
					refresh_barang();
					clear();
					auto_number();
					atur_tombol(false);
				}
				catch (Exception x)
				{
					MessageBox.Show(x.ToString());
				}
			}
		}

        /// <summary>
        /// mengambil nilai data record
        /// </summary>
        private void dataGridView_barang_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			
			try
			{
				button_simpan.Enabled = false;
				atur_tombol(true);
				DataGridViewRow row = this.dataGridView_barang.Rows[e.RowIndex];
				textBox_kodebarang.Text = row.Cells["KodeBarang"].Value.ToString();
				textBox_namabarang.Text = row.Cells["NamaBarang"].Value.ToString();
				textBox_warna.Text = row.Cells["Warna"].Value.ToString();
				comboBox_ukuran.Text = row.Cells["Ukuran"].Value.ToString();
				textBox_stok.Text = row.Cells["Stok"].Value.ToString();
				textBox_harga.Text = row.Cells["Harga"].Value.ToString();

			}
			catch (Exception x)
			{
				MessageBox.Show(x.ToString());
			}
		}

		private void button_ubah_Click(object sender, EventArgs e)
		{
			if (textBox_kodebarang.Text.Trim() == "" || textBox_namabarang.Text.Trim() == "" || textBox_warna.Text.Trim() == "" || textBox_stok.Text.Trim() == "" || textBox_harga.Text.Trim() == "" || comboBox_ukuran.Text.Trim() == "")
			{
				MessageBox.Show("Data Belum Lengkap", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				SqlConnection conn = konn.GetConn();
				try
				{
					cmd = new SqlCommand("update tbl_barang set NamaBarang = '" + textBox_namabarang.Text + "', warna = '" + textBox_warna.Text + "', Ukuran = '" + comboBox_ukuran.Text + "', Stok = '" + textBox_stok.Text + "', Harga = '" + textBox_harga.Text + "' where KodeBarang = '"+textBox_kodebarang.Text+"'", conn);
					conn.Open();
					cmd.ExecuteNonQuery();
					MessageBox.Show("Data Berhasil Diubah", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
					refresh_barang();
					clear();
					atur_tombol(false);
					auto_number();
					button_simpan.Enabled = true;
				}
				catch (Exception x)
				{
					MessageBox.Show(x.ToString());
				}
			}
		}

		private void button_hapus_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data : " + textBox_namabarang.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				SqlConnection conn = konn.GetConn();
				{
					cmd = new SqlCommand("delete from tbl_barang where KodeBarang = '" + textBox_kodebarang.Text + "'", conn);
					conn.Open();
					cmd.ExecuteNonQuery();
					MessageBox.Show("Data Berhasil Dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
					refresh_barang();
					clear();
					atur_tombol(false);
					auto_number();
					button_simpan.Enabled = true;
				}
			}
		}

		private void button_baru_Click(object sender, EventArgs e)
		{
			clear();
			atur_tombol(false);
			button_simpan.Enabled = true;
			auto_number();
		}
	}
}
