<%@ Page language="c#" Inherits="EasyExam.NewsManag.EditNews" CodeFile="EditNews.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>�޸�����</title>
		<meta content="True" name="vs_showGrid">
		<meta content="Microsoft FrontPage 6.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="JavaScript" src="../JavaScript/Calendar.js"></script>
		<LINK href="../CSS/STYLE.CSS" type="text/css" rel="stylesheet">
		<script language="JavaScript" src="../JavaScript/Common.js"></script>
         <script type="text/javascript" src="../JavaScript/jquery-1.8.2.min.js"></script>
      <script src="../JavaScript/kindeditor-4.1.10/kindeditor-min.js" type="text/javascript"></script>
   <script language="javascript" type="text/javascript" src="../JavaScript/kindeditor-4.1.10/kindeditor.js"></script>
    <link rel="stylesheet" href="../JavaScript/kindeditor-4.1.10/themes/default/default.css" />
	<link rel="stylesheet" href="../JavaScript/kindeditor-4.1.10/plugins/code/prettify.css" />
	<script  type="text/javascript" charset="utf-8" src="../JavaScript/kindeditor-4.1.10/kindeditor.js"></script>
	<script  type="text/javascript" charset="utf-8" src="../JavaScript/kindeditor-4.1.10/lang/zh_CN.js"></script>	
    <script  type="text/javascript" charset="utf-8" src="../JavaScript/kindeditor-4.1.10/plugins/code/prettify.js"></script>

     <script type="text/javascript">
       
         KindEditor.ready(function (K) {
             var editor1 = K.create('#txtNewsContent', {
                 
                 cssPath: '../plugins/code/prettify.css',
                 uploadJson: '../Editor/upload_json.ashx',
                            
                 allowFileManager: true
             });

         });
        </script>
	</HEAD>
	<body leftMargin="0" topMargin="0" rightMargin="0">
		<form id="Form1" method="post" runat="server">
			<table height="300px" cellSpacing="0" cellPadding="0" width="750px" align="center" border="0">
				<tr>
					<td height="0"></td>
				</tr>
				<tr>
					<td colspan="2">
						<!--���ݿ�ʼ-->
						<table style="BORDER-COLLAPSE: collapse" borderColor="#6699ff" height="336" cellSpacing="0"
							cellPadding="0" width="100%" align="center" border="1">
							<tr>
								<td style="COLOR: #990000" align="center" background="bg_dh_middle.gif" bgColor="#ffffff"
									height="24" colspan="2"><font style="FONT-SIZE: 16px" face="����" color="#ffffff">�޸�����</font></td>
							</tr>
							<TR>
								<TD style="WIDTH: 100px; HEIGHT: 23px" align="right">���ű��⣺</TD>
								<TD style="HEIGHT: 23px" width="650px"><asp:textbox id="txtNewsTitle" runat="server" Width="344px" CssClass="text" ToolTip="��������100���ַ�"
										MaxLength="100"></asp:textbox></TD>
							</TR>
							<TR>
								<td style="WIDTH: 100px; HEIGHT: 219px" align="right">�������ݣ�</td>
								<td style="HEIGHT: 219px" width="650px" colSpan="5"><FONT face="����"><asp:TextBox runat="server"  TextMode="MultiLine"  style="width:344px;height:248px"
											CssClass="text" ID="txtNewsContent" MaxLength="800"></asp:TextBox>
									</FONT>
								</td>
							</TR>
							<TR>
								<TD style="WIDTH: 100px" align="right" height="26"><FONT face="����">�����Ա��</FONT></TD>
								<TD width="650px" colSpan="5"><ASP:RADIOBUTTON id="rbAllAccount" runat="server" GroupName="SelectAccount" Checked="True" Text="�����ʺ�"></ASP:RADIOBUTTON><FONT face="����">&nbsp;</FONT>&nbsp;
									<ASP:RADIOBUTTON id="rbSelectAccount" runat="server" GroupName="SelectAccount" Text=" "></ASP:RADIOBUTTON><asp:button id="btnSelectAccount" runat="server" Width="54px" CssClass="text" Text="ѡ��..." ToolTip="ѡ�������Ա" onclick="btnSelectAccount_Click"></asp:button><asp:textbox id="txtSelectAccount" runat="server" Width="184px" CssClass="text" MaxLength="50"></asp:textbox></TD>
							</TR>
							<TR>
								<td style="WIDTH: 100px" align="right" height="24"><FONT face="����">�������ڣ�</FONT></td>
								<td width="650px" colSpan="5"><asp:textbox id="txtCreateDate" runat="server" Width="80px" Enabled="False"></asp:textbox></td>
							</TR>
							<tr height="30">
								<td align="center" width="518" colSpan="6" height="24">
									<asp:Button id="ButInput" runat="server" CssClass="button" Text="�� ��" onclick="ButInput_Click"></asp:Button><FONT face="����">&nbsp;
										<input name="Button" type="button" class="button" value="ȡ ��" onClick="window.close();"></FONT></td>
							</tr>
						</table>
						<!--���ݽ���-->
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
