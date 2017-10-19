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

namespace EasyExam
{
	/// <summary>
	/// MainLeftMenu ��ժҪ˵����
	/// </summary>
	public partial class MainLeftMenu : System.Web.UI.Page
	{
		protected string strMainMenu="";

		string myUserID="";
		string myLoginID="";
		string myUserName="";
		PublicFunction ObjFun=new PublicFunction();
		int intUserID=0,intUserType=0,intRoleMenu=0;

		protected void Page_Load(object sender, System.EventArgs e)
		{
			try
			{
				myUserID=Session["UserID"].ToString();
				myLoginID=Session["LoginID"].ToString();
				myUserName=Session["UserName"].ToString();
			}
			catch
			{
			}
			if (myLoginID=="")
			{
				Response.Redirect("Login.aspx");
			}
			intUserID=Convert.ToInt32(myUserID);
			intUserType=Convert.ToInt32(ObjFun.GetValues("select UserType from UserInfo where LoginID='"+myLoginID+"'","UserType"));
			if (intUserType==0)//��ͨ�ʻ�
			{
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td id='imgmenu1' class='menu_title' onmouseover=this.className='menu_title2'; onclick='showsubmenu(1)'";
				strMainMenu=strMainMenu+"onmouseout=this.className='menu_title'; style='cursor:hand' background='images/menuup.gif'";
				strMainMenu=strMainMenu+"height='25'>";
				strMainMenu=strMainMenu+"<span style='font-weight: bold; left: 18px; color: #215dc6; position: relative; top: 2px'>��������</span></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td id='submenu1' style='DISPLAY: block; font-size:9pt; color:#333333; line-height:150%'>";
				strMainMenu=strMainMenu+"<div class='sec_menu' style='WIDTH: 135px'>";
				strMainMenu=strMainMenu+"<table cellspacing='3' cellpadding='0' width='100' align='center'>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='PersonInfo/BrowNewsList.aspx'><font color='000000'>�鿴����</font></a></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='PersonInfo/JoinExam.aspx'><font color='000000'>�μӿ���</font></a></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='PersonInfo/JoinJob.aspx'><font color='000000'>�μ���ҵ</font></a></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='PersonInfo/JoinStudyFrame.aspx'><font color='000000'>�μ�ѧϰ</font></a></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='PersonInfo/UserInfo.aspx'><font color='000000'>�ʻ���Ϣ</font></a></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='PersonInfo/PassWord.aspx'><font color='000000'>�޸�����</font></a></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"</table>";
				strMainMenu=strMainMenu+"</div>";
				strMainMenu=strMainMenu+"</td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td id='imgmenu2' class='menu_title' onmouseover=this.className='menu_title2'; onclick='showsubmenu(2)'";
				strMainMenu=strMainMenu+"onmouseout=this.className='menu_title'; style='cursor:hand' background='images/menuup.gif'";
				strMainMenu=strMainMenu+"height='25'>";
				strMainMenu=strMainMenu+"<span style='font-weight: bold; left: 18px; color: #215dc6; position: relative; top: 2px'>�ɼ���ѯ</span></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td id='submenu2' style='DISPLAY: block; font-size:9pt; color:#333333; line-height:150%'>";
				strMainMenu=strMainMenu+"<div class='sec_menu' style='WIDTH: 135px'>";
				strMainMenu=strMainMenu+"<table cellspacing='3' cellpadding='0' width='100' style='border-collapse: collapse' bordercolor='#111111'";
				strMainMenu=strMainMenu+"align='center'>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%'><a target='main' href='PersonInfo/QueryGrade.aspx?PaperType=1'><font color='000000'>���Գɼ�</font></a></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%'><a target='main' href='PersonInfo/QueryGrade.aspx?PaperType=2'><font color='000000'>��ҵ�ɼ�</font></a></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"</table>";
				strMainMenu=strMainMenu+"</div>";
				strMainMenu=strMainMenu+"</td>";
				strMainMenu=strMainMenu+"</tr>";
			}
			else//�����ʻ�
			{
				intRoleMenu=Convert.ToInt32(ObjFun.GetValues("select RoleMenu from UserInfo where LoginID='"+myLoginID+"'","RoleMenu"));

				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td id='imgmenu1' class='menu_title' onmouseover=this.className='menu_title2'; onclick='showsubmenu(1)'";
				strMainMenu=strMainMenu+"onmouseout=this.className='menu_title'; style='cursor:hand' background='images/menudown.gif'";
				strMainMenu=strMainMenu+"height='25'>";
				strMainMenu=strMainMenu+"<span style='font-weight: bold; left: 18px; color: #215dc6; position: relative; top: 2px'>��������</span></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td id='submenu1' style='DISPLAY: none; font-size:9pt; color:#333333; line-height:150%'>";
				strMainMenu=strMainMenu+"<div class='sec_menu' style='WIDTH: 135px'>";
				strMainMenu=strMainMenu+"<table cellspacing='3' cellpadding='0' width='100' align='center'>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='PersonInfo/BrowNewsList.aspx'><font color='000000'>�鿴����</font></a></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='PersonInfo/JoinExam.aspx'><font color='000000'>�μӿ���</font></a></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='PersonInfo/JoinJob.aspx'><font color='000000'>�μ���ҵ</font></a></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='PersonInfo/JoinStudyFrame.aspx'><font color='000000'>�μ�ѧϰ</font></a></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='PersonInfo/UserInfo.aspx'><font color='000000'>�ʻ���Ϣ</font></a></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='PersonInfo/PassWord.aspx'><font color='000000'>�޸�����</font></a></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"</table>";
				strMainMenu=strMainMenu+"</div>";
				strMainMenu=strMainMenu+"</td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td id='imgmenu2' class='menu_title' onmouseover=this.className='menu_title2'; onclick='showsubmenu(2)'";
				strMainMenu=strMainMenu+"onmouseout=this.className='menu_title'; style='cursor:hand' background='images/menudown.gif'";
				strMainMenu=strMainMenu+"height='25'>";
				strMainMenu=strMainMenu+"<span style='font-weight: bold; left: 18px; color: #215dc6; position: relative; top: 2px'>�ɼ���ѯ</span></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td id='submenu2' style='DISPLAY: none; font-size:9pt; color:#333333; line-height:150%'>";
				strMainMenu=strMainMenu+"<div class='sec_menu' style='WIDTH: 135px'>";
				strMainMenu=strMainMenu+"<table cellspacing='3' cellpadding='0' width='100' style='border-collapse: collapse' bordercolor='#111111'";
				strMainMenu=strMainMenu+"align='center'>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%'><a target='main' href='PersonInfo/QueryGrade.aspx?PaperType=1'><font color='000000'>���Գɼ�</font></a></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%'><a target='main' href='PersonInfo/QueryGrade.aspx?PaperType=2'><font color='000000'>��ҵ�ɼ�</font></a></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"</table>";
				strMainMenu=strMainMenu+"</div>";
				strMainMenu=strMainMenu+"</td>";
				strMainMenu=strMainMenu+"</tr>";

				if ((intRoleMenu==1)||(ObjFun.GetValues("select OptionID from UserPower where UserID="+intUserID+" and PowerID=3 and OptionID=1","OptionID")!=""))//���Ź���
				{
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td id='imgmenu3' class='menu_title' onmouseover=this.className='menu_title2'; onclick='showsubmenu(3)'";
					strMainMenu=strMainMenu+"onmouseout=this.className='menu_title'; style='cursor:hand' background='images/menudown.gif'";
					strMainMenu=strMainMenu+"height='25'>";
					strMainMenu=strMainMenu+"<span style='font-weight: bold; left: 18px; color: #215dc6; position: relative; top: 2px'>���Ź���</span></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td id='submenu3' style='DISPLAY: none; font-size:9pt; color:#333333; line-height:150%'>";
					strMainMenu=strMainMenu+"<div class='sec_menu' style='WIDTH: 135px'>";
					strMainMenu=strMainMenu+"<table cellspacing='3' cellpadding='0' width='100' style='border-collapse: collapse' bordercolor='#111111'";
					strMainMenu=strMainMenu+"align='center'>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%'><a target='main' href='NewsManag/ManagNewsList.aspx'><font color='000000'>���Ź���</font></a></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"</table>";
					strMainMenu=strMainMenu+"</div>";
					strMainMenu=strMainMenu+"</td>";
					strMainMenu=strMainMenu+"</tr>";
				}
				if ((intRoleMenu==1)||(ObjFun.GetValues("select OptionID from UserPower where UserID="+intUserID+" and PowerID=3 and OptionID=2","OptionID")!=""))//�ʻ�����
				{
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td id='imgmenu4' class='menu_title' onmouseover=this.className='menu_title2'; onclick='showsubmenu(4)'";
					strMainMenu=strMainMenu+"onmouseout=this.className='menu_title'; style='cursor:hand' background='images/menudown.gif'";
					strMainMenu=strMainMenu+"height='25'>";
					strMainMenu=strMainMenu+"<span style='font-weight: bold; left: 18px; color: #215dc6; position: relative; top: 2px'>�ʻ�����</span></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td id='submenu4' style='DISPLAY: none; font-size:9pt; color:#333333; line-height:150%'>";
					strMainMenu=strMainMenu+"<div class='sec_menu' style='WIDTH: 135px'>";
					strMainMenu=strMainMenu+"<table cellspacing='3' cellpadding='0' width='100' style='border-collapse: collapse' bordercolor='#111111'";
					strMainMenu=strMainMenu+"align='center'>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%'><a target='main' href='UserManag/NewMoreUser.aspx'><font color='000000'>�����½�</font></a></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%'><a target='main' href='UserManag/ImportUser.aspx'><font color='000000'>�����ʻ�</font></a></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%'><a target='main' href='UserManag/ManagUserList.aspx'><font color='000000'>�ʻ�����</font></a></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"</table>";
					strMainMenu=strMainMenu+"</div>";
					strMainMenu=strMainMenu+"</td>";
					strMainMenu=strMainMenu+"</tr>";
				}
				if ((intRoleMenu==1)||(ObjFun.GetValues("select OptionID from UserPower where UserID="+intUserID+" and PowerID=3 and OptionID=3","OptionID")!=""))//������
				{
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td id='imgmenu5' class='menu_title' onmouseover=this.className='menu_title2'; onclick='showsubmenu(5)'";
					strMainMenu=strMainMenu+"onmouseout=this.className='menu_title'; style='cursor:hand' background='images/menudown.gif'";
					strMainMenu=strMainMenu+"height='25'>";
					strMainMenu=strMainMenu+"<span style='font-weight: bold; left: 18px; color: #215dc6; position: relative; top: 2px'>������</span></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td id='submenu5' style='DISPLAY: none; font-size:9pt; color:#333333; line-height:150%'>";
					strMainMenu=strMainMenu+"<div class='sec_menu' style='WIDTH: 135px'>";
					strMainMenu=strMainMenu+"<table cellspacing='3' cellpadding='0' width='100' style='border-collapse: collapse' bordercolor='#111111'";
					strMainMenu=strMainMenu+"align='center'>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%'><a target='main' href='RubricManag/ImportTest.aspx'><font color='000000'>��������</font></a></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%'><a target='main' href='RubricManag/ManagTestList.aspx'><font color='000000'>������</font></a></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%'><a target='main' href='RubricManag/CountTest.aspx'><font color='000000'>���ͳ��</font></a></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%'><a target='main' href='RubricManag/ManagBookFrame.aspx'><font color='000000'>�����鼮</font></a></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"</table>";
					strMainMenu=strMainMenu+"</div>";
					strMainMenu=strMainMenu+"</td>";
					strMainMenu=strMainMenu+"</tr>";
				}
				if ((intRoleMenu==1)||(ObjFun.GetValues("select OptionID from UserPower where UserID="+intUserID+" and PowerID=3 and OptionID=4","OptionID")!=""))//�Ծ����
				{
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td id='imgmenu6' class='menu_title' onmouseover=this.className='menu_title2'; onclick='showsubmenu(6)'";
					strMainMenu=strMainMenu+"onmouseout=this.className='menu_title'; style='cursor:hand' background='images/menudown.gif'";
					strMainMenu=strMainMenu+"height='25'>";
					strMainMenu=strMainMenu+"<span style='font-weight: bold; left: 18px; color: #215dc6; position: relative; top: 2px'>�Ծ����</span></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td id='submenu6' style='DISPLAY: none; font-size:9pt; color:#333333; line-height:150%'>";
					strMainMenu=strMainMenu+"<div class='sec_menu' style='WIDTH: 135px'>";
					strMainMenu=strMainMenu+"<table cellspacing='3' cellpadding='0' width='100' style='border-collapse: collapse' bordercolor='#111111'";
					strMainMenu=strMainMenu+"align='center'>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%'><a target='main' href='PaperManag/ManagExamPaper.aspx'><font color='000000'>�����Ծ�</font></a></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%'><a target='main' href='PaperManag/ManagJobPaper.aspx'><font color='000000'>��ҵ�Ծ�</font></a></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"</table>";
					strMainMenu=strMainMenu+"</div>";
					strMainMenu=strMainMenu+"</td>";
					strMainMenu=strMainMenu+"</tr>";
				}
				if ((intRoleMenu==1)||(ObjFun.GetValues("select OptionID from UserPower where UserID="+intUserID+" and PowerID=3 and OptionID=5","OptionID")!=""))//���̹���
				{
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td id='imgmenu7' class='menu_title' onmouseover=this.className='menu_title2'; onclick='showsubmenu(7)'";
					strMainMenu=strMainMenu+"onmouseout=this.className='menu_title'; style='cursor:hand' background='images/menudown.gif'";
					strMainMenu=strMainMenu+"height='25'>";
					strMainMenu=strMainMenu+"<span style='font-weight: bold; left: 18px; color: #215dc6; position: relative; top: 2px'>���̹���</span></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td id='submenu7' style='DISPLAY: none; font-size:9pt; color:#333333; line-height:150%'>";
					strMainMenu=strMainMenu+"<div class='sec_menu' style='WIDTH: 135px'>";
					strMainMenu=strMainMenu+"<table cellspacing='3' cellpadding='0' width='100' style='border-collapse: collapse' bordercolor='#111111'";
					strMainMenu=strMainMenu+"align='center'>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%'><a target='main' href='ProcessManag/ManagProcess.aspx?PaperType=1'><font color='000000'>���Թ���</font></a></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%'><a target='main' href='ProcessManag/ManagProcess.aspx?PaperType=2'><font color='000000'>��ҵ����</font></a></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"</table>";
					strMainMenu=strMainMenu+"</div>";
					strMainMenu=strMainMenu+"</td>";
					strMainMenu=strMainMenu+"</tr>";
				}
				if ((intRoleMenu==1)||(ObjFun.GetValues("select OptionID from UserPower where UserID="+intUserID+" and PowerID=3 and OptionID=6","OptionID")!=""))//�ɼ�����
				{
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td id='imgmenu8' class='menu_title' onmouseover=this.className='menu_title2'; onclick='showsubmenu(8)'";
					strMainMenu=strMainMenu+"onmouseout=this.className='menu_title'; style='cursor:hand' background='images/menudown.gif'";
					strMainMenu=strMainMenu+"height='25'>";
					strMainMenu=strMainMenu+"<span style='font-weight: bold; left: 18px; color: #215dc6; position: relative; top: 2px'>�ɼ�����</span></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td id='submenu8' style='DISPLAY: none; font-size:9pt; color:#333333; line-height:150%'>";
					strMainMenu=strMainMenu+"<div class='sec_menu' style='WIDTH: 135px'>";
					strMainMenu=strMainMenu+"<table cellspacing='3' cellpadding='0' width='100' align='center'>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='GradeManag/ManagGrade.aspx?PaperType=1'><font color='000000'>���Գɼ�</font></a></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='GradeManag/ManagGrade.aspx?PaperType=2'><font color='000000'>��ҵ�ɼ�</font></a></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"</table>";
					strMainMenu=strMainMenu+"</div>";
					strMainMenu=strMainMenu+"</td>";
					strMainMenu=strMainMenu+"</tr>";
				}

				if (myLoginID.Trim().ToUpper()=="ADMIN")//ϵͳ����Ա
				{
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td id='imgmenu9' class='menu_title' onmouseover=this.className='menu_title2'; onclick='showsubmenu(9)'";
					strMainMenu=strMainMenu+"onmouseout=this.className='menu_title'; style='cursor:hand' background='images/menudown.gif'";
					strMainMenu=strMainMenu+"height='25'>";
					strMainMenu=strMainMenu+"<span style='font-weight: bold; left: 18px; color: #215dc6; position: relative; top: 2px'>ϵͳ����</span></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td id='submenu9' style='DISPLAY: none; font-size:9pt; color:#333333; line-height:150%'>";
					strMainMenu=strMainMenu+"<div class='sec_menu' style='WIDTH: 135px'>";
					strMainMenu=strMainMenu+"<table cellspacing='3' cellpadding='0' width='100' align='center'>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='SystemSet/ManagDeptList.aspx'><font color='000000'>��������</font></a></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='SystemSet/ManagJobList.aspx'><font color='000000'>ְ������</font></a></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='SystemSet/ManagSubjectList.aspx'><font color='000000'>��Ŀ����</font></a></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='SystemSet/ManagTestTypeList.aspx'><font color='000000'>��������</font></a></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='SystemSet/ManagPowerList.aspx'><font color='000000'>Ȩ������</font></a></td>";
					strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"<tr>";
					strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='SystemSet/SetOther.aspx'><font color='000000'>�ۺ�����</font></a></td>";
					strMainMenu=strMainMenu+"</tr>";
                    //strMainMenu=strMainMenu+"<tr>";
                    //strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a target='main' href='SystemSet/RegistSoft.aspx'><font color='000000'>���ע��</font></a></td>";
                    //strMainMenu=strMainMenu+"</tr>";
					strMainMenu=strMainMenu+"</table>";
					strMainMenu=strMainMenu+"</div>";
					strMainMenu=strMainMenu+"</td>";
					strMainMenu=strMainMenu+"</tr>";
				}
			}

			if (intUserType==0)//��ͨ�ʻ�
			{
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td id='imgmenu10' class='menu_title' onmouseover=this.className='menu_title2'; onclick='showsubmenu(10)'";
				strMainMenu=strMainMenu+"onmouseout=this.className='menu_title'; style='cursor:hand' background='images/menuup.gif'";
				strMainMenu=strMainMenu+"height='25'>";
				strMainMenu=strMainMenu+"<span style='font-weight: bold; left: 18px; color: #215dc6; position: relative; top: 2px'>ϵͳ����</span></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td id='submenu10' style='DISPLAY: block; font-size:9pt; color:#333333; line-height:150%'>";
				strMainMenu=strMainMenu+"<div class='sec_menu' style='WIDTH: 135px'>";
				strMainMenu=strMainMenu+"<table cellspacing='3' cellpadding='0' width='100' align='center'>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a href='#' onclick={NewWin=window.open('Help/CommoHelp.htm','CommoHelp','titlebar=yes,menubar=no,toolbar=no,location=no,directories=no,status=yes,scrollbars=yes,resizable=no,copyhistory=yes,top=0,left=0,width=screen.availWidth,height=screen.availHeight');NewWin.moveTo(0,0);NewWin.resizeTo(screen.availWidth,screen.availHeight);}><font color='000000'>���߰���</font></a></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a href='#' onclick=showModalDialog('Help/About.aspx',0,'dialogWidth:306px;dialogHeight:224px;help:no;center:yes;resizable:no;status:no;scroll:no');><font color='000000'>����ϵͳ</font></a></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"</table>";
				strMainMenu=strMainMenu+"</div>";
				strMainMenu=strMainMenu+"</td>";
				strMainMenu=strMainMenu+"</tr>";
			}
			else//�����ʻ�
			{
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td id='imgmenu10' class='menu_title' onmouseover=this.className='menu_title2'; onclick='showsubmenu(10)'";
				strMainMenu=strMainMenu+"onmouseout=this.className='menu_title'; style='cursor:hand' background='images/menudown.gif'";
				strMainMenu=strMainMenu+"height='25'>";
				strMainMenu=strMainMenu+"<span style='font-weight: bold; left: 18px; color: #215dc6; position: relative; top: 2px'>ϵͳ����</span></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td id='submenu10' style='DISPLAY: none; font-size:9pt; color:#333333; line-height:150%'>";
				strMainMenu=strMainMenu+"<div class='sec_menu' style='WIDTH: 135px'>";
				strMainMenu=strMainMenu+"<table cellspacing='3' cellpadding='0' width='100' align='center'>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a href='#' onclick={NewWin=window.open('Help/ManagHelp.htm','ManagHelp','titlebar=yes,menubar=no,toolbar=no,location=no,directories=no,status=yes,scrollbars=yes,resizable=no,copyhistory=yes,top=0,left=0,width=screen.availWidth,height=screen.availHeight');NewWin.moveTo(0,0);NewWin.resizeTo(screen.availWidth,screen.availHeight);}><font color='000000'>���߰���</font></a></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"<tr>";
				strMainMenu=strMainMenu+"<td style='font-size: 9pt; color: #333333; line-height: 150%' width='100'><a href='#' onclick=showModalDialog('Help/About.aspx',0,'dialogWidth:306px;dialogHeight:224px;help:no;center:yes;resizable:no;status:no;scroll:no');><font color='000000'>����ϵͳ</font></a></td>";
				strMainMenu=strMainMenu+"</tr>";
				strMainMenu=strMainMenu+"</table>";
				strMainMenu=strMainMenu+"</div>";
				strMainMenu=strMainMenu+"</td>";
				strMainMenu=strMainMenu+"</tr>";
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
