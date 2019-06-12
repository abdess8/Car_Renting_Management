using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace House_of_cars.BL
{
    class CLS_CAR
    {

        public void ADD_CAR(int ID_CAR, string AVAILABILITY_FLAG, string MODEL_NAME, int MODEL_YEAR, int MILEAGE, string CAR_CATEGORY_NAME)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAR", SqlDbType.Int);
            param[0].Value =ID_CAR;
            param[1] = new SqlParameter("@AVAILABILITY_FLAG", SqlDbType.Char, 1);
            param[1].Value = AVAILABILITY_FLAG;
            param[2] = new SqlParameter("@MODEL_NAME", SqlDbType.VarChar, 25);
            param[2].Value = MODEL_NAME;
            param[3] = new SqlParameter("@MODEL_YEAR", SqlDbType.Int);
            param[3].Value = MODEL_YEAR;
            param[4] = new SqlParameter("@MILEAGE", SqlDbType.Int);
            param[4].Value = MILEAGE;
            param[5] = new SqlParameter("@CAR_CATEGORY_NAME", SqlDbType.VarChar,25);
            param[5].Value = CAR_CATEGORY_NAME;
            DAL.Executecommand("ADD_CAR", param);
            DAL.close();

        }

        public void UPDATE_CAR(int ID_CAR, string AVAILABILITY_FLAG, string MODEL_NAME, int MODEL_YEAR, int MILEAGE, string CAR_CATEGORY_NAME)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_CAR", SqlDbType.Int);
            param[0].Value = ID_CAR;
            param[1] = new SqlParameter("@AVAILABILITY_FLAG", SqlDbType.Char, 1);
            param[1].Value = AVAILABILITY_FLAG;
            param[2] = new SqlParameter("@MODEL_NAME", SqlDbType.VarChar, 25);
            param[2].Value = MODEL_NAME;
            param[3] = new SqlParameter("@MODEL_YEAR", SqlDbType.Int);
            param[3].Value = MODEL_YEAR;
            param[4] = new SqlParameter("@MILEAGE", SqlDbType.Int);
            param[4].Value = MILEAGE;
            param[5] = new SqlParameter("@CAR_CATEGORY_NAME", SqlDbType.VarChar,25);
            param[5].Value = CAR_CATEGORY_NAME;
            DAL.Executecommand("UPDATE_CAR", param);
            DAL.close();

        }

        public DataTable VERIFY_ID_car(string ID_CAR)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 25);
            param[0].Value = ID_CAR;
            dt = DAL.SelectData("VERIFY_ID_car", param);
            DAL.close();
            return dt;
        }

        public DataTable GET_CAR()
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_CAR", null);
            DAL.close();
            return dt;
        }

        public DataTable search_CAR(string ID)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 25);
            param[0].Value = ID;
            dt = DAL.SelectData("search_CAR", param);
            DAL.close();
            return dt;
        }
        public void Delet_CAR(string ID)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 25);
            param[0].Value = ID;
            DAL.Executecommand("Delet_CAR", param);
            DAL.close();
        }
    }
}
