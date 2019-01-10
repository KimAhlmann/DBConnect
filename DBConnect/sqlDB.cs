using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;


namespace DBConnect
{

    /// <summary>
    /// space for ducomentation
    /// </summary>
    class sqlDB
    {
        //ConnectionString
        private static string ConnectionString = @"Data Source=DESKTOP-4S7QIDF\SQLEXPRESS;Initial Catalog=Autoværksted; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
       
        public static void Insert(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))

            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
        }
        public static void Select(string sql, string type)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(table);

                if (type=="kunde")
                {

                foreach (DataRow kunde in table.Rows)
                {
                    Console.WriteLine("Kunder i Databasen");
                    Console.WriteLine("KundeID:          "+kunde["id"].ToString());
                    Console.WriteLine("Navn:             "+kunde["navn"].ToString());
                    Console.WriteLine("Adresse:          "+kunde["adr"].ToString());
                    Console.WriteLine("Bykunde:          "+kunde["byNavn"].ToString());
                    Console.WriteLine("PostNr:           "+kunde["postNr"].ToString());

                    Console.WriteLine("Oprettet:         "+kunde["dato"].ToString());
                    Console.WriteLine();


                }
                }

                else if(type.ToLower()=="besøg")
                {
                    foreach (DataRow besøg in table.Rows)
                    {
                        Console.WriteLine("biler i værkstedsbesøg");
                        Console.WriteLine("BesøgsID:          " + besøg["BesøgsID"].ToString());
                        Console.WriteLine("noter:             " + besøg["noter"].ToString());
                        Console.WriteLine("pris:              " + besøg["pris"].ToString());
                        Console.WriteLine();
                    }

                }


                else
                {

                foreach (DataRow biler in table.Rows)
                {
                    Console.WriteLine("BilID:          " + biler["BilID"].ToString());
                    Console.WriteLine("KundeID:        " + biler["KundeID"].ToString());
                    Console.WriteLine("regNR:          " + biler["regNr"].ToString());
                    Console.WriteLine("Mærke:          " + biler["mærke"].ToString());
                    Console.WriteLine("Model:          " + biler["model"].ToString());
                    Console.WriteLine("Brændstof:      " + biler["brændstofstype"].ToString());
                    Console.WriteLine("årgang:         " + biler["årgang"].ToString());
                    Console.WriteLine("KM:             " + biler["km"].ToString());
                    Console.WriteLine("oprettet:       " + biler["dato"].ToString());
                    Console.WriteLine();
                }
                }


                //string denførsterække = table.Rows[0]["navn"].ToString();
                //Console.WriteLine(denførsterække);
            }


        }
            public static void Update(string sql)
            {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
        }

        public static void Delete(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }

        }

    }
}
