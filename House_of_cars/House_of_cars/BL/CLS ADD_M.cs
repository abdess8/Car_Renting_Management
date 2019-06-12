using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace House_of_cars.BL
{
    class CLS_ADD_M
    {
        public void ADD_M(int ID_M, string USERNAME, string PASSWORD, string FULLNAME, string usertype, int phone, string email)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID_M", SqlDbType.Int);
            param[0].Value = ID_M;
            param[1] = new SqlParameter("@USERNAME", SqlDbType.VarChar, 25);
            param[1].Value = USERNAME;
            param[2] = new SqlParameter("@PASSWORD", SqlDbType.VarChar, 25);
            param[2].Value = PASSWORD;
            param[3] = new SqlParameter("@FULLNAME", SqlDbType.VarChar, 25);
            param[3].Value = FULLNAME;
            param[4] = new SqlParameter("@usertype", SqlDbType.VarChar, 25);
            param[4].Value = usertype;
            param[5] = new SqlParameter("@phone", SqlDbType.Int);
            param[5].Value = phone;
            param[6] = new SqlParameter("@email", SqlDbType.VarChar, 25);
            param[6].Value = email;
            DAL.Executecommand("ADD_M", param);
            DAL.close();

        }
        public void update_manager(int ID_eddit, string USERNAME, string PASSWORD, string FULLNAME, string usertype, int phone, string email)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID_edit", SqlDbType.Int);
            param[0].Value = ID_eddit;
            param[1] = new SqlParameter("@USERNAME", SqlDbType.VarChar, 25);
            param[1].Value = USERNAME;
            param[2] = new SqlParameter("@PASSWORD", SqlDbType.VarChar, 25);
            param[2].Value = PASSWORD;
            param[3] = new SqlParameter("@FULLNAME", SqlDbType.VarChar, 25);
            param[3].Value = FULLNAME;
            param[4] = new SqlParameter("@usertype", SqlDbType.VarChar, 25);
            param[4].Value = usertype;
            param[5] = new SqlParameter("@phone", SqlDbType.Int);
            param[5].Value = phone;
            param[6] = new SqlParameter("@email", SqlDbType.VarChar, 25);
            param[6].Value = email;
            DAL.Executecommand("update_manager", param);
            DAL.close();

        }

        public DataTable VERIFY_ID(string ID_M)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 25);
            param[0].Value = ID_M;
            dt = DAL.SelectData("VERIFY_ID", param);
            DAL.close();
            return dt;
        }

        public DataTable GET_MANAGER()
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_MANAGER", null);
            DAL.close();
            return dt;
        }
        public DataTable GET_ADMIN_ID()
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("GET_ADMIN_ID", null);
            DAL.close();
            return dt;
        }

        public DataTable search_M(string ID)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 25);
            param[0].Value = ID;
            dt = DAL.SelectData("search_M", param);
            DAL.close();
            return dt;
        }
        public void Delet_M(string ID)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar,25);
            param[0].Value = ID;
            DAL.Executecommand("Delet_M", param);
            DAL.close();
        }

         
    }
}
