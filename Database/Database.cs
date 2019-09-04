using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VedioRental.Database
{
    class Database
    {
        // Sql Connection
        private SqlConnection Con = new SqlConnection();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();

        public SqlCommand command1 => cmd;

        public Database()
        {
            //connecting with the database
            string constring = @"Data Source=DESKTOP-89NTJEN\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=True";
            Con.ConnectionString = constring;
            cmd.Connection = Con;
        }
        // methode to fill the data grid view with the class DGV
        public DataTable FillDGV(string querySelect)
        {
            //database class
            DataTable dt = new DataTable();
            //fill by the query
            using (da = new SqlDataAdapter(querySelect, Con))
            {
                Con.Open();
                da.Fill(dt);
                Con.Close();
            }

            return dt;
        }

        public void AddDeleteUpdate(string queryAddDeleteUpdate)
        {
            using (cmd = new SqlCommand(queryAddDeleteUpdate, Con))
            {
                //open connection
                Con.Open();
                //execute insert query
                cmd.ExecuteNonQuery();
                //close connection
                Con.Close();
            }
        }
    }
}
