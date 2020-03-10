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
    /// untuk mebambah edit dan delet daftar pelanggan
    /// </summary>
	public partial class FormPelanggan : Form
	{
		private SqlCommand cmd; // perintah query
		private DataSet ds; //menampilkan data
		private SqlDataAdapter da; //mengeksekusi perintah query

		Kelas.Koneksi konn = new Kelas.Koneksi();

		void clear()
		{
			textBox_idpelanggan.Text = "";
			textBox_namapelanggan.Text = "";
			textBox_alamat.Text = "";
			textBox_notelpon.Text = "";
			textBox_namapelanggan.Focus();
		}

		void atur_tombol(Boolean status)
		{
			button_ubah.Enabled = status;
			button_hapus.Enabled = status;
		}

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

		void auto_number()
		{
			long hitung; // penentukan pjg
			string urut; // urutkan
			SqlDataReader rd;
			SqlConnection conn = konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("select IdPelanggan from tbl_pelanggan where IdPelanggan in (select max (IdPelanggan) from tbl_pelanggan) order by IdPelanggan desc", conn);
			rd = cmd.ExecuteReader();
			rd.Read();
			if (rd.HasRows)
			{
				hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["IdPelanggan"].ToString().Length - 3, 3)) + 1;
				string joinstr = "000" + hitung;
				urut = "P" + joinstr.Substring(joinstr.Length - 3, 3); //convert ambil 3 angka
			}
			else
			{
				urut = "P001";
			}
			rd.Close();
			textBox_idpelanggan.Enabled = false;
			textBox_idpelanggan.Text = urut;
			conn.Close();
		}

		public FormPelanggan()
		{
			InitializeComponent();
			clear();
			atur_tombol(false);
			auto_number();
		}

		private void textBox_cari_TextChanged(object sender, EventArgs e)
		{
			cari_pelanggan();
		}

		private void button_simpan_Click(object sender, EventArgs e)
		{
			if (textBox_idpelanggan.Text.Trim() == "" || textBox_namapelanggan.Text.Trim() == "" || textBox_alamat.Text.Trim() == "" || textBox_notelpon.Text.Trim() == "")
			{
				MessageBox.Show("Data Belum Lengkap", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				SqlConnection conn = konn.GetConn();
				try
				{
					cmd = new SqlCommand("insert into tbl_pelanggan values ('" + textBox_idpelanggan.Text + "', '" + textBox_namapelanggan.Text + "', '" + textBox_alamat.Text + "', '" + textBox_notelpon.Text + "' ) ", conn);
					conn.Open();
					cmd.ExecuteNonQuery();
					MessageBox.Show("Data Berhasil Tersimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
					refresh_pelanggan();
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

		private void dataGridView_pelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				button_simpan.Enabled = false;
				atur_tombol(true);
				DataGridViewRow row = this.dataGridView_pelanggan.Rows[e.RowIndex];
				textBox_idpelanggan.Text = row.Cells["IdPelanggan"].Value.ToString();
				textBox_namapelanggan.Text = row.Cells["NamaPelanggan"].Value.ToString();
				textBox_alamat.Text = row.Cells["Alamat"].Value.ToString();
				textBox_notelpon.Text = row.Cells["NoTelepon"].Value.ToString();

			}
			catch (Exception x)
			{
				MessageBox.Show(x.ToString());
			}
		}

		private void button_ubah_Click(object sender, EventArgs e)
		{
			if (textBox_idpelanggan.Text.Trim() == "" || textBox_namapelanggan.Text.Trim() == "" || textBox_alamat.Text.Trim() == "" || textBox_notelpon.Text.Trim() == "" )
			{
				MessageBox.Show("Data Belum Lengkap", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				SqlConnection conn = konn.GetConn();
				try
				{
					cmd = new SqlCommand("update tbl_pelanggan set Namapelanggan = '" + textBox_namapelanggan.Text + "', Alamat = '" + textBox_alamat.Text + "', NoTelepon = '" + textBox_notelpon.Text + "' where IdPelanggan = '" + textBox_idpelanggan.Text + "'", conn);
					conn.Open();
					cmd.ExecuteNonQuery();
					MessageBox.Show("Data Berhasil Diubah", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
					refresh_pelanggan();
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
			if (MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data : " + textBox_namapelanggan.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				SqlConnection conn = konn.GetConn();
				{
					cmd = new SqlCommand("delete from tbl_pelanggan where IdPelanggan = '" + textBox_idpelanggan.Text + "'", conn);
					conn.Open();
					cmd.ExecuteNonQuery();
					MessageBox.Show("Data Berhasil Dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
					refresh_pelanggan();
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
