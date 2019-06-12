using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace House_of_cars.BL
{
    class CLS_ADD_CLIENT
    {
        public void ADD_CLIENT(int ID_CUSTOMER, string CIN, string FNAME, string LNAME,  int PHONE_NUMBER, string DRIVER_LICENSE)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CUSTOMER", SqlDbType.Int);
            param[0].Value = ID_CUSTOMER;
            param[1] = new SqlParameter("@CIN", SqlDbType.VarChar, 25);
            param[1].Value = CIN;
            param[2] = new SqlParameter("@FNAME", SqlDbType.VarChar, 25);
            param[2].Value = FNAME;
            param[3] = new SqlParameter("@LNAME", SqlDbType.VarChar, 25);
            param[3].Value = LNAME;
            param[4] = new SqlParameter("@PHONE_NUMBER", SqlDbType.Int);
            param[4].Value = PHONE_NUMBER;
            param[5] = new SqlParameter("@DRIVER_LICENSE", SqlDbType.VarChar, 25);
            param[5].Value = DRIVER_LICENSE;
            DAL.Executecommand("ADD_CLIENT", param);
            DAL.close();

        }
        public void UPDATE_CLIENT(int ID_CUSTOMER, string CIN, string FNAME, string LNAME, int PHONE_NUMBER, string DRIVER_LICENSE)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CUSTOMER", SqlDbType.Int);
            param[0].Value = ID_CUSTOMER;
            param[1] = new SqlParameter("@CIN", SqlDbType.VarChar, 25);
            param[1].Value = CIN;
            param[2] = new SqlParameter("@FNAME", SqlDbType.VarChar, 25);
            param[2].Value = FNAME;
            param[3] = new SqlParameter("@LNAME", SqlDbType.VarChar, 25);
            param[3].Value = LNAME;
            param[4] = new SqlParameter("@PHONE_NUMBER", SqlDbType.Int);
            param[4].Value = PHONE_NUMBER;
            param[5] = new SqlParameter("@DRIVER_LICENSE", SqlDbType.VarChar, 25);
            param[5].Value = DRIVER_LICENSE;
            DAL.Executecommand("UPDATE_CLIENT", param);
            DAL.close();

        }

        public DataTable VERIFY_ID_CLIENT(string ID_CUSTOMER)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_CUSTOMER", SqlDbType.VarChar, 25);
            param[0].Value = ID_CUSTOMER;
            dt = DAL.SelectData("VERIFY_ID_CLIENT", param);
            DAL.close();
            return dt;
        }

        public DataTable GET_CLIENT()
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_CLIENT", null);
            DAL.close();
            return dt;
        }
        public DataTable GET_CUSTOMER_ID()
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_CUSTOMER_ID", null);
            DAL.close();
            return dt;
        }

        public DataTable SEARCH_CLIENT(string ID_CUSTOMER)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_CUSTOMER", SqlDbType.VarChar, 25);
            param[0].Value = ID_CUSTOMER;
            dt = DAL.SelectData("SEARCH_CLIENT", param);
            DAL.close();
            return dt;
        }
        public void DELETE_CLIENT(string ID_CUSTOMER)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_CUSTOMER", SqlDbType.VarChar, 25);
            param[0].Value = ID_CUSTOMER;
            DAL.Executecommand("DELETE_CLIENT", param);
            DAL.close();
        }


    }
}

