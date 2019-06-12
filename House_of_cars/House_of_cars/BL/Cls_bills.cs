using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace House_of_cars.BL
{
    class Cls_bills
    {
        
        public void ADD_BILL(int BILL_ID, DateTime BILL_DATE, string BILL_STATUS, int TOTAL_AMOUNT, int ID_RESERVATION)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@BILL_ID", SqlDbType.Int);
            param[0].Value = BILL_ID;
            param[1] = new SqlParameter("@BILL_DATE", SqlDbType.Date);
            param[1].Value = BILL_DATE;
            param[2] = new SqlParameter("@BILL_STATUS", SqlDbType.Char, 1);
            param[2].Value = BILL_STATUS;
            param[3] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.Int);
            param[3].Value = TOTAL_AMOUNT;
            param[4] = new SqlParameter("@ID_RESERVATION", SqlDbType.Int);
            param[4].Value = ID_RESERVATION;
            
           
            DAL.Executecommand("ADD_BILL", param);
            DAL.close();

        }
        public DataTable GET_BILL_ID()
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_BILL_ID", null);
            DAL.close();
            return dt;
        }
        public void UPDATE_BILLS(int BILL_ID, DateTime BILL_DATE, string BILL_STATUS, int TOTAL_AMOUNT, int ID_RESERVATION)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@BILL_ID", SqlDbType.Int);
            param[0].Value = BILL_ID;
            param[1] = new SqlParameter("@BILL_DATE", SqlDbType.Date);
            param[1].Value = BILL_DATE;
            param[2] = new SqlParameter("@BILL_STATUS", SqlDbType.Char, 1);
            param[2].Value = BILL_STATUS;
            param[3] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.Int);
            param[3].Value = TOTAL_AMOUNT;
            param[4] = new SqlParameter("@ID_RESERVATION", SqlDbType.Int);
            param[4].Value = ID_RESERVATION;

            DAL.Executecommand("UPDATE_BILLS", param);
            DAL.close();

        }

        public DataTable VERIFY_ID_BILLS(string BILL_ID)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@BILL_ID", SqlDbType.VarChar, 25);
            param[0].Value = BILL_ID;
            dt = DAL.SelectData("VERIFY_ID_BILLS", param);
            DAL.close();
            return dt;
        }

        public DataTable GET_BILLS()
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_BILLS", null);
            DAL.close();
            return dt;
        }

        public DataTable SEARCH_BILLS(string BILL_ID)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@BILL_ID", SqlDbType.VarChar, 25);
            param[0].Value = BILL_ID;
            dt = DAL.SelectData("SEARCH_BILLS", param);
            DAL.close();
            return dt;
        }
        public void DELETE_BILLS(string BILL_ID)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@BILL_ID", SqlDbType.VarChar, 25);
            param[0].Value = BILL_ID;
            DAL.Executecommand("DELETE_BILLS", param);
            DAL.close();
        }
    }
}
