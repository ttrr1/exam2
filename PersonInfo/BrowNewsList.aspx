<%@ Page language="c#" Inherits="EasyExam.PersonInfo.BrowNewsList" CodeFile="BrowNewsList.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>新闻管理</title>
		<meta content="Microsoft FrontPage 6.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../CSS/STYLE.CSS" type="text/css" rel="stylesheet">
		<script language="JavaScript" src="../JavaScript/Common.js"></script>
	</HEAD>
	<body leftMargin="0" topMargin="0" rightMargin="0">
		<form id="Form1" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="800" border="0" height="540" align="center">
				<tr>
					<td height="40"></td>
				</tr>
				<tr>
					<td>
						<!--内容开始-->
						<table cellSpacing="0" cellPadding="0" width="780" border="1" height="500" style="BORDER-COLLAPSE:collapse"
							bordercolor="#6699ff" align="center">
							<tr>
								<td style="COLOR: #990000" align="center" bgColor="#ffffff" height="24" background="../Images/bg_dh_middle.gif"><font style="FONT-SIZE: 16px" face="黑体" color="#ffffff">查看新闻</font></td>
							</tr>
							<tr>
								<td align="center" valign="top"><asp:datagrid id="DataGridNews" runat="server" Width="100%" AutoGenerateColumns="False" AllowPaging="True"
										BorderWidth="1px" CellPadding="0" PageSize="15" ForeColor="Black" AllowSorting="True">
										<ItemStyle Height="23px"></ItemStyle>
										<HeaderStyle HorizontalAlign="Center" Height="23px" ForeColor="Black" CssClass="HeadRow" BackColor="#076AA3"></HeaderStyle>
										<Columns>
											<asp:BoundColumn Visible="False" DataField="NewsID" ReadOnly="True" HeaderText="NewsID"></asp:BoundColumn>
											<asp:TemplateColumn HeaderText="&lt;IMG src='../images/arrow.gif'' border='0'">
												<ItemStyle HorizontalAlign="Center"></ItemStyle>
												<ItemTemplate>
													<asp:image id="ImgArrow" runat="server" ImageUrl="../Images/arrow.gif"></asp:image>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:TemplateColumn HeaderText="序号">
												<ItemTemplate>
													<%#RowNum++%>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:TemplateColumn SortExpression="NewsTitle" HeaderText="新闻标题">
												<ItemTemplate>
													<asp:LinkButton id="LinkButNewsTitle" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"NewsTitle") %>' CommandName="NewsTitle" CausesValidation="false" ToolTip="点击浏览">
													</asp:LinkButton>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:BoundColumn DataField="BrowNumber" SortExpression="BrowNumber" HeaderText="浏览次数"></asp:BoundColumn>
											<asp:BoundColumn DataField="CreateLoginID" SortExpression="CreateLoginID" HeaderText="发布人"></asp:BoundColumn>
											<asp:TemplateColumn SortExpression="CreateDate" HeaderText="发布日期">
												<ItemTemplate>
													<asp:Label id="labCreateDate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"CreateDate") %>'>
													</asp:Label>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:TemplateColumn HeaderText="操作">
												<HeaderStyle HorizontalAlign="Center" Width="30px"></HeaderStyle>
												<ItemStyle HorizontalAlign="Center"></ItemStyle>
												<ItemTemplate>
													<asp:LinkButton id="LinkButBrowNews" runat="server" Text="浏览" CommandName="BrowNews" CausesValidation="false">浏览</asp:LinkButton>
												</ItemTemplate>
											</asp:TemplateColumn>
										</Columns>
										<PagerStyle Height="23px" HorizontalAlign="Right" Mode="NumericPages"></PagerStyle>
									</asp:datagrid><FONT face="宋体">共有<asp:Label id="LabelRecord" runat="server" ForeColor="Blue" Font-Names="宋体" Font-Bold="True">0</asp:Label>条记录&nbsp;<asp:Label id="LabelCountPage" runat="server" ForeColor="Blue" Font-Names="宋体" Font-Bold="True">0</asp:Label>页&nbsp;当前是第<asp:Label id="LabelCurrentPage" runat="server" ForeColor="Blue" Font-Names="宋体" Font-Bold="True">0</asp:Label>页&nbsp;</FONT>
									<asp:linkbutton id="LinkButFirstPage" runat="server" onclick="LinkButFirstPage_Click">第一页</asp:linkbutton>&nbsp;
									<asp:linkbutton id="LinkButPirorPage" runat="server" onclick="LinkButPirorPage_Click">上一页</asp:linkbutton>&nbsp;
									<asp:linkbutton id="LinkButNextPage" runat="server" onclick="LinkButNextPage_Click">下一页</asp:linkbutton>&nbsp;
									<asp:linkbutton id="LinkButLastPage" runat="server" onclick="LinkButLastPage_Click">最后页</asp:linkbutton>
								</td>
							</tr>
						</table>
						<!--内容结束-->
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
