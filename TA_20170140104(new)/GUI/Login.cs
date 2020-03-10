using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_20170140104_new_.GUI
{
	/// <summary>
	/// class <c>Login</c> login halaman awal
	/// </summary>

	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
			password_txt.PasswordChar = '*';
		}

		/// <summary>
		/// button login untuk login
		/// </summary>
		/// <returns>
		/// error
		/// </returns>
		/// <param name="sender"><c>object sender</c> parameter yang disebut Pengirim yang berisi referensi ke kontrol / objek yang mengangkat peristiwa.</param>
		/// <param name="e"><c>EventArgs e</c> parameter yang disebut e yang berisi data peristiwa.</param>

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				MessageBox.Show("Masukkan Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textBox1.Focus();
				return;
			}
			if (password_txt.Text == "")
			{
				MessageBox.Show("Masukkan Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				password_txt.Focus();
				return;
			}
			try
			{
				if (textBox1.Text == "admin" && password_txt.Text == "123") 
				{
					MessageBox.Show("Berhasil Login " + textBox1.Text);

					Menu_Utama mu = new Menu_Utama();
					this.Hide();
					mu.Show();
				}
			}
			catch
			{
				MessageBox.Show("Error!!!");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
