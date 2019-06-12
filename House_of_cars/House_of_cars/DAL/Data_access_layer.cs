using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace House_of_cars.DAL
{
    class Data_access_layer
    {
        SqlConnection SqlConnection;

        //construction of connection
        public Data_access_layer()
        {
            SqlConnection = new SqlConnection(@"server=.\SQLEXPRESS;Database=House_of_cars;Integrated Security=true");
        }

        //Method to open connectioon
        public void open()
        {
          
                if (SqlConnection.State != ConnectionState.Open)
                {
                    SqlConnection.Open();
                }
            
        }


        //Method to close connection
        public void close()
        {
            if (SqlConnection.State == ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        //Metho to Read data
        public DataTable SelectData(string Stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = Stored_procedure;
            sqlcmd.Connection = SqlConnection;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        //Method to Insert ,Update,Delete
        public void Executecommand(string Stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = Stored_procedure;
            sqlcmd.Connection = SqlConnection;
            if (param != null)
            {


                sqlcmd.Parameters.AddRange(param);

            }

            sqlcmd.ExecuteNonQuery();
        }
    }
}
