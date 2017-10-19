<%@ Page language="c#" Inherits="EasyExam.PersonalInfo.ShowAnswer" CodeFile="ShowAnswer.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>查看答卷</title>
		<meta content="Microsoft FrontPage 5.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../CSS/STYLE.CSS" type="text/css" rel="stylesheet">
		<script language="JavaScript" src="../JavaScript/Common.js"></script>
	</HEAD>
	<body leftMargin="0" topMargin="0" rightMargin="0">
		<form id="Form1" method="post" runat="server">
			<table cellSpacing="0" cellPadding="1" width="95%" align="center" border="0">
				<tr>
					<td height="6"></td>
				</tr>
				<tr>
					<td align="center">
						<table cellSpacing="0" cellPadding="1" width="100%" align="center" border="0" style="LINE-HEIGHT: 200%">
							<tr>
								<td vAlign="bottom" width="20%"><FONT face="宋体"></FONT></td>
								<td vAlign="bottom" align="center" width="60%"><span id="lblTitle" style="FONT-WEIGHT: bold; FONT-SIZE: 14pt"><%=strPaperName%></span></td>
								<td vAlign="bottom" align="right" width="20%"><span id="lblSubTitle">总共<%=strTestCount%>
										题共<%=strPaperMark%>分</span></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td style="HEIGHT: 2px" bgColor="#0000ff" height="2"></td>
				</tr>
				<tr>
					<td align="center" style="HEIGHT: 20px" height="20"><span id="lblMessage">帐号:<%=strLoginID%>&nbsp;&nbsp;姓名:<%=strUserName%>&nbsp;&nbsp;答题时间:<%=strExamTime%>&nbsp;&nbsp;通过分数:<%=strPassMark%>&nbsp;&nbsp;考生得分:<%=strTotalMark%></span></td>
				</tr>
				<tr>
					<td align="center">
						<table cellSpacing="0" cellPadding="1" width="100%" align="center" border="0" style="LINE-HEIGHT: 200%">
							<tr>
								<td vAlign="bottom" width="20%"><FONT face="宋体"></FONT></td>
								<td vAlign="bottom" align="center" width="60%">
									<asp:RadioButton id="RadioButAll" runat="server" Text="全部显示" GroupName="ShowTest" Checked="True"
										AutoPostBack="True" oncheckedchanged="RadioButAll_CheckedChanged"></asp:RadioButton>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
									<asp:RadioButton id="RadioButWrong" runat="server" Text="错题显示" GroupName="ShowTest" AutoPostBack="True" oncheckedchanged="RadioButWrong_CheckedChanged"></asp:RadioButton></td>
								<td vAlign="bottom" align="right" width="20%"><INPUT class="lenButton" onclick="jscomExportTableToWord('tblPaper')" type="button" value="导出到Word">&nbsp;&nbsp;<INPUT class="button" onclick="window.print();" type="button" value="打 印"></td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td bgColor="#cee7ff">
						<table id="tblPaper" cellSpacing="0" cellPadding="1" width="100%" align="center" bgColor="white"
							border="0">
							<%=strPaperContent%>
						</table>
					</td>
				</tr>
				<tr>
					<td align="center"><input class="button" onclick="window.close();" type="button" value="关 闭" name="button1"></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
