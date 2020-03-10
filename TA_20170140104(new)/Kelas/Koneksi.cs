using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TA_20170140104_new_.Kelas
{
	class Koneksi
	{
		//membuat getconn
		public SqlConnection GetConn()
		{
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = "Data Source = SPRUNK; Initial Catalog=tokosepatu; Integrated Security=True";
			return conn;
		}
	}
}
