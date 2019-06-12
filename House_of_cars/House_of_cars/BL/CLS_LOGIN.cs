using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace House_of_cars.BL
{
    class CLS_LOGIN
    {
        public DataTable login(string USERNAME, string PASSWORD)
        {
            DAL.Data_access_layer DAL = new DAL.Data_access_layer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@USERNAME", SqlDbType.VarChar, 25);
            param[0].Value = USERNAME;
            param[1] = new SqlParameter("@PASSWORD", SqlDbType.VarChar, 25);
            param[1].Value = PASSWORD;
            DAL.open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("SP_LOGIN", param);
            DAL.close();
            return dt;
        }
    }
}
