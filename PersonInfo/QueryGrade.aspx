<%@ Page language="c#" Inherits="EasyExam.PersonInfo.QueryGrade" CodeFile="QueryGrade.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>成绩查询</title>
		<meta content="Microsoft FrontPage 5.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../CSS/STYLE.CSS" type="text/css" rel="stylesheet">
		<script language="JavaScript" src="../JavaScript/Common.js"></script>
	</HEAD>
	<body leftMargin="0" topMargin="0" rightMargin="0">
		<form id="Form1" method="post" runat="server">
			<table height="540" cellSpacing="0" cellPadding="0" width="800" align="center" border="0">
				<tr>
					<td height="40"></td>
				</tr>
				<tr>
					<td>
						<!--内容开始-->
						<table style="BORDER-COLLAPSE: collapse" borderColor="#6699ff" height="500" cellSpacing="0"
							cellPadding="0" width="780" align="center" border="1">
							<tr>
								<td style="COLOR: #990000" align="center" background="../Images/bg_dh_middle.gif" bgColor="#ffffff"
									height="24"><font style="FONT-SIZE: 16px" face="黑体" color="#ffffff"><asp:label id="labPaperType" runat="server" ForeColor="White"></asp:label>成绩查询</font></td>
							</tr>
							<tr>
								<td style="HEIGHT: 22px">&nbsp; 试卷名称：<asp:textbox id="txtPaperName" runat="server" Width="152px" CssClass="text"></asp:textbox>&nbsp; 
									日期：从
									<asp:textbox id="txtStartTime" onclick="jcomOpenCalender('txtStartTime');" runat="server" Width="80px"
										CssClass="text" MaxLength="50"></asp:textbox></FONT><A onclick="jcomOpenCalender('txtStartTime');" href="#"><IMG height="18" alt="选择" src="../images/Calendar.gif" width="22" border="0"></A>到
									<asp:textbox id="txtEndTime" onclick="jcomOpenCalender('txtEndTime');" runat="server" Width="80px"
										CssClass="text" MaxLength="50"></asp:textbox></FONT><A onclick="jcomOpenCalender('txtEndTime');" href="#"><IMG height="18" alt="选择" src="../images/Calendar.gif" width="22" border="0"></A>&nbsp;
									<asp:button id="ButQuery" runat="server" CssClass="button" Text="查 询" onclick="ButQuery_Click"></asp:button><asp:label id="LabCondition" runat="server" Visible="False">条件</asp:label></td>
							</tr>
							<tr>
								<td vAlign="top" align="center"><asp:datagrid id="DataGridGrade" runat="server" Width="100%" AutoGenerateColumns="False" AllowPaging="True"
										BorderWidth="1px" CellPadding="0" PageSize="15" AllowSorting="True">
										<ItemStyle Height="23px"></ItemStyle>
										<HeaderStyle HorizontalAlign="Center" Height="23px" ForeColor="Black" CssClass="HeadRow" BackColor="#076AA3"></HeaderStyle>
										<Columns>
											<asp:BoundColumn Visible="False" DataField="UserScoreID" ReadOnly="True" HeaderText="UserScoreID">
												<ItemStyle HorizontalAlign="Center"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn Visible="False" DataField="PaperID" ReadOnly="True" HeaderText="PaperID"></asp:BoundColumn>
											<asp:TemplateColumn HeaderText="序号">
												<ItemTemplate>
													<%#RowNum++%>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:BoundColumn DataField="PaperName" SortExpression="PaperName" HeaderText="试卷名称"></asp:BoundColumn>
											<asp:TemplateColumn HeaderText="答题时间">
												<ItemTemplate>
													<asp:Label id="labExamTime" runat="server">答题时间</asp:Label>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:TemplateColumn SortExpression="TotalMark" HeaderText="成绩">
												<ItemTemplate>
													<asp:Label id="LabTotalMark" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"TotalMark") %>'>
													</asp:Label>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:TemplateColumn SortExpression="PassState" HeaderText="通过状态">
												<ItemTemplate>
													<asp:Label id="LabPassState" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"PassState") %>'>
													</asp:Label>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:BoundColumn DataField="JudgeState" SortExpression="JudgeState" HeaderText="评卷状态"></asp:BoundColumn>
											<asp:BoundColumn DataField="JudgeLoginID" SortExpression="JudgeLoginID" HeaderText="评卷人"></asp:BoundColumn>
											<asp:TemplateColumn HeaderText="操作">
												<HeaderStyle Width="90px"></HeaderStyle>
												<ItemTemplate>
													<asp:LinkButton id="LinkButOrder" runat="server" Text="排名" CommandName="Order" CausesValidation="false">排名</asp:LinkButton>
													<asp:LinkButton id="LinkButAnswer" runat="server" Text="答卷" CommandName="Answer" CausesValidation="false">答卷</asp:LinkButton>
													<asp:LinkButton id="LinkButStatis" runat="server" Text="统计" CommandName="Statis" CausesValidation="false">统计</asp:LinkButton>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:BoundColumn Visible="False" DataField="StartTime" ReadOnly="True" HeaderText="开始时间"></asp:BoundColumn>
											<asp:BoundColumn Visible="False" DataField="EndTime" ReadOnly="True" HeaderText="结束时间"></asp:BoundColumn>
											<asp:BoundColumn Visible="False" DataField="SeeResult" ReadOnly="True" HeaderText="查看结果"></asp:BoundColumn>
										</Columns>
										<PagerStyle Height="23px" HorizontalAlign="Right" Mode="NumericPages"></PagerStyle>
									</asp:datagrid><FONT face="宋体">共有<asp:label id="LabelRecord" runat="server" ForeColor="Blue" Font-Bold="True" Font-Names="宋体">0</asp:label>条记录&nbsp;<asp:label id="LabelCountPage" runat="server" ForeColor="Blue" Font-Bold="True" Font-Names="宋体">0</asp:label>页&nbsp;当前是第<asp:label id="LabelCurrentPage" runat="server" ForeColor="Blue" Font-Bold="True" Font-Names="宋体">0</asp:label>页&nbsp;</FONT>
									<asp:linkbutton id="LinkButFirstPage" runat="server" onclick="LinkButFirstPage_Click">第一页</asp:linkbutton>&nbsp;
									<asp:linkbutton id="LinkButPirorPage" runat="server" onclick="LinkButPirorPage_Click">上一页</asp:linkbutton>&nbsp;
									<asp:linkbutton id="LinkButNextPage" runat="server" onclick="LinkButNextPage_Click">下一页</asp:linkbutton>&nbsp;
									<asp:linkbutton id="LinkButLastPage" runat="server" onclick="LinkButLastPage_Click">最后页</asp:linkbutton></td>
							</tr>
						</table>
						<!--内容结束--></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
