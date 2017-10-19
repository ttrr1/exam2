using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Configuration;
using System.Data.SqlClient;
using Exam;

namespace EasyExam.Editor
{
	/// <summary>
	/// Editor ��ժҪ˵����
	/// </summary>
	public partial class Editor : System.Web.UI.Page
	{
		protected string strSectionID;
        protected int intSectionID;
        protected string strcontent="";
		protected void Page_Load(object sender, System.EventArgs e)
		{
            
        if (!IsPostBack) { 
            strSectionID=Convert.ToString(Request["SectionID"]);
            intSectionID = Convert.ToInt32(Request["SectionID"]);
            
            if (intSectionID != 0)
            {
              strcontent=  DBHelper.GetBookEditContent(intSectionID);
              this.txtContent.Text = strcontent;
             // Response.Write(strcontent);
             // Response.End();
            }
            
        }
			

		}

		#region Web ������������ɵĴ���
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �õ����� ASP.NET Web ���������������ġ�
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{    
		}
		#endregion
	}
}
