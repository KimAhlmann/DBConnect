using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DBConnect
{

    /// <summary>
    /// space for ducomentation
    /// </summary>
    class sqlDB
    {
        //ConnectionString
        private static string ConnectionString = @"Data Source=DESKTOP-4S7QIDF\SQLEXPRESS;Initial Catalog=sqleksempler; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static void Insert(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))

            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
        }
        public static void Select(string sql)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(table);

                foreach (DataRow kunde in table.Rows)
                {
                    Console.WriteLine(kunde["id"].ToString());
                    Console.WriteLine(kunde["navn"].ToString());
                    Console.WriteLine(kunde["adr"].ToString());
                    Console.WriteLine(kunde["regNr"].ToString());
                    Console.WriteLine(kunde["mærke"].ToString());
                    Console.WriteLine(kunde["model"].ToString());
                    Console.WriteLine(kunde["brændstofstype"].ToString());
                    Console.WriteLine(kunde["årgang"].ToString());
                    Console.WriteLine(kunde["km"].ToString());
                   
                    Console.WriteLine();

                    
                }
                //string denførsterække = table.Rows[0]["navn"].ToString();
                //Console.WriteLine(denførsterække);
            }


        }
    }
}
