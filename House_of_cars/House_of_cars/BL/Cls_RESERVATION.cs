using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace House_of_cars.BL
{
    class Cls_RESERVATION
    {
        public void ADD_RESERVATION(int ID_RESERVATION, DateTime DATE_RESERVATION, int RENTAL_DAYS, string STATUS, string MODEL_NAME, string CIN_COSTUMER)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_RESERVATION", SqlDbType.Int);
            param[0].Value = ID_RESERVATION;
            param[1] = new SqlParameter("DATE_RESERVATION", SqlDbType.Date);
            param[1].Value = DATE_RESERVATION;
            param[2] = new SqlParameter("@RENTAL_DAYS", SqlDbType.Int);
            param[2].Value = RENTAL_DAYS;
            param[3] = new SqlParameter("@STATUS", SqlDbType.Char, 1);
            param[3].Value = STATUS;
            param[4] = new SqlParameter("@MODEL_NAME", SqlDbType.VarChar, 25);
            param[4].Value = MODEL_NAME;
            param[5] = new SqlParameter("@CIN_COSTUMER", SqlDbType.VarChar, 25);
            param[5].Value = CIN_COSTUMER;
            DAL.Executecommand("ADD_RESERVATION", param);
            DAL.close();

        }

        internal void UPDATE_RESERVATION(int v1, string text1, int v2, char v3, object text2, string text3)
        {
            throw new NotImplementedException();
        }

        public void UPDATE_RESERVATION(int ID_RESERVATION, DateTime DATE_RESERVATION, int RENTAL_DAYS, string STATUS, string MODEL_NAME, string CIN_COSTUMER)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_RESERVATION", SqlDbType.Int);
            param[0].Value = ID_RESERVATION;
            param[1] = new SqlParameter("DATE_RESERVATION", SqlDbType.Date);
            param[1].Value = DATE_RESERVATION;
            param[2] = new SqlParameter("@RENTAL_DAYS", SqlDbType.Int);
            param[2].Value = RENTAL_DAYS;
            param[3] = new SqlParameter("@STATUS", SqlDbType.Char, 1);
            param[3].Value = STATUS;
            param[4] = new SqlParameter("@MODEL_NAME", SqlDbType.VarChar, 25);
            param[4].Value = MODEL_NAME;
            param[5] = new SqlParameter("@CIN_COSTUMER", SqlDbType.VarChar, 25);
            param[5].Value = CIN_COSTUMER;
            DAL.Executecommand("UPDATE_RESERVATION", param);
            DAL.close();

        }

        public DataTable VERIFY_ID_RESERVATION(string ID_RESERVATION)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_RESERVATION", SqlDbType.VarChar, 25);
            param[0].Value = ID_RESERVATION;
            dt = DAL.SelectData("VERIFY_ID_RESERVATION", param);
            DAL.close();
            return dt;
        }

        public DataTable GET_RESERVATION()
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_RESERVATION", null);
            DAL.close();
            return dt;
        }
        public DataTable GET_RESERVATION_ID()
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_RESERVATION_ID", null);
            DAL.close();
            return dt;
        }

        public DataTable search_RESERVATION(string ID_RESERVATION)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_RESERVATION", SqlDbType.VarChar, 25);
            param[0].Value = ID_RESERVATION;
            dt = DAL.SelectData("search_RESERVATION", param);
            DAL.close();
            return dt;
        }
        public void Delet_RESERVATION(string ID_RESERVATION)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_RESERVATION", SqlDbType.VarChar, 25);
            param[0].Value = ID_RESERVATION;
            DAL.Executecommand("Delet_RESERVATION", param);
            DAL.close();
        }
    }
}
