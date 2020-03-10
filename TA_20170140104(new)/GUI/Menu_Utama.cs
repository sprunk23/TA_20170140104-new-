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
	/// class <c>Menu_Utama</c> tampilan menu utama
	/// </summary>
	public partial class Menu_Utama : Form
	{
		//form jd objek
		FormBarang brg;
		FormPelanggan plgn;
		FormTransaksi trx;

		//buat closed_brg
		void brg_FormClosed(Object sender, FormClosedEventArgs e)
		{
			brg = null;
		}

		void plgn_FormClosed(Object sender, FormClosedEventArgs e)
		{
			plgn = null;
		}

		void trx_FormClosed(Object sender, FormClosedEventArgs e)
		{
			trx = null;
		}

		public Menu_Utama()
		{
			InitializeComponent();
		}

		private void submenu_barang_Click(object sender, EventArgs e)
		{
			if (brg == null)
			{
				brg = new FormBarang();
				brg.MdiParent = this;
				brg.FormClosed += new FormClosedEventHandler(brg_FormClosed);
				brg.Show();
			}
			else
			{
				brg.Activate();
			}
		}

		private void submenu_pelanggan_Click(object sender, EventArgs e)
		{
			if (plgn == null)
			{
				plgn = new FormPelanggan();
				plgn.MdiParent = this;
				plgn.FormClosed += new FormClosedEventHandler(plgn_FormClosed);
				plgn.Show();
			}
			else
			{
				plgn.Activate();
			}
		}

		/// <summary>
		/// menu penjualan 
		/// </summary>
		/// <param name="sender"><c>object sender</c> parameter yang disebut Pengirim yang berisi referensi ke kontrol / objek yang mengangkat peristiwa.</param>
		/// <param name="e"><c>EventArgs e</c> parameter yang disebut e yang berisi data peristiwa.</param>
		private void submenu_penjualan_Click(object sender, EventArgs e)
		{
			if (trx == null)
			{
				trx = new FormTransaksi();
				trx.MdiParent = this;
				trx.FormClosed += new FormClosedEventHandler(trx_FormClosed);
				trx.Show();
			}
			else
			{
				trx.Activate();
			}
		}
	}
}
