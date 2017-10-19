using System;
using DevExpress.Xpo;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace Exam {

	public class DBHelper  {
        public static string GetBookEditContent(int intSectionID)
        {
            string strcontent="";
            string strConn = "";
            strConn = ConfigurationSettings.AppSettings["strConn"];
            SqlConnection ObjConn = new SqlConnection(strConn);
            SqlCommand ObjCmd = new SqlCommand("select * from SectionInfo where SectionID=" + intSectionID + "", ObjConn);
            ObjConn.Open();
            SqlDataReader ObjDR = ObjCmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (ObjDR.Read())
            {
                strcontent = strcontent + ObjDR["SectionContent"].ToString();
                //Response.Write(ObjDR["SectionContent"].ToString());
            }
          
            //  ObjConn.Dispose();
              ObjConn.Close();
              return strcontent;
        }

        public static bool IsExists(string user)
        {
            string strConn = "";
            strConn = ConfigurationSettings.AppSettings["strConn"];
            SqlConnection ObjConn = new SqlConnection(strConn);
            string strSql = "select count(*) from UserInfo where LoginID='" + user + "'";
            SqlCommand ObjCmd = new SqlCommand(strSql, ObjConn);
            try
            {
                ObjConn.Open();
                int count = Convert.ToInt32(ObjCmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ObjConn.Close();

            }
        }

        public static DataTable GetUserInfo(string user) {

            string strConn = "";
            strConn = ConfigurationSettings.AppSettings["strConn"];
            SqlConnection ObjConn = new SqlConnection(strConn);
            DataSet set = new DataSet();
            string strSql = "select * from UserInfo where LoginID='" + user + "'";
            SqlCommand ObjCmd = new SqlCommand(strSql, ObjConn);
            SqlDataAdapter da = new SqlDataAdapter(ObjCmd);
            try
            {
                ObjConn.Open();
                da.Fill(set);              
                return set.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ObjConn.Close();

            }
        }
	}

}
