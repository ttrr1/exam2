<%@ Page language="c#" Inherits="EasyExam.PersonalInfo.JoinJob" CodeFile="JoinJob.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>�μ���ҵ</title>
		<meta content="Microsoft FrontPage 5.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../CSS/STYLE.CSS" type="text/css" rel="stylesheet">
	</HEAD>
	<body leftMargin="0" topMargin="0" rightMargin="0">
		<form id="Form1" method="post" runat="server">
			<table height="540" cellSpacing="0" cellPadding="0" width="800" align="center" border="0">
				<tr>
					<td height="40"><FONT face="����"></FONT></td>
				</tr>
				<tr>
					<td>
						<!--���ݿ�ʼ-->
						<table style="BORDER-COLLAPSE: collapse" borderColor="#6699ff" height="500" cellSpacing="0"
							cellPadding="0" width="780" align="center" border="1">
							<tr>
								<td style="COLOR: #990000" align="center" background="../Images/bg_dh_middle.gif" bgColor="#ffffff"
									height="24"><font style="FONT-SIZE: 16px" face="����" color="#ffffff">�μ���ҵ</font></td>
							</tr>
							<tr>
								<td vAlign="top" align="center"><asp:datagrid id="DataGridPaper" runat="server" Width="100%" PageSize="15" CellPadding="0" BorderWidth="1px"
										AllowPaging="True" AutoGenerateColumns="False" AllowSorting="True">
										<ItemStyle Height="23px"></ItemStyle>
										<HeaderStyle HorizontalAlign="Center" Height="23px" ForeColor="Black" CssClass="HeadRow" BackColor="#076AA3"></HeaderStyle>
										<Columns>
											<asp:BoundColumn Visible="False" DataField="PaperID" ReadOnly="True" HeaderText="PaperID">
												<ItemStyle HorizontalAlign="Center"></ItemStyle>
											</asp:BoundColumn>
											<asp:TemplateColumn HeaderText="���">
												<ItemTemplate>
													<%#RowNum++%>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:BoundColumn DataField="PaperName" SortExpression="PaperName" HeaderText="�Ծ�����"></asp:BoundColumn>
											<asp:BoundColumn DataField="ProduceWay" SortExpression="ProduceWay" HeaderText="���ⷽʽ"></asp:BoundColumn>
											<asp:BoundColumn DataField="ShowModal" SortExpression="ShowModal" HeaderText="��ʾģʽ"></asp:BoundColumn>
											<asp:TemplateColumn HeaderText="��Чʱ��">
												<ItemTemplate>
													<asp:Label id="labAvaiTime" runat="server">��Чʱ��</asp:Label>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:BoundColumn DataField="TestCount" SortExpression="TestCount" HeaderText="����"></asp:BoundColumn>
											<asp:BoundColumn DataField="PaperMark" SortExpression="PaperMark" HeaderText="�ܷ�"></asp:BoundColumn>
											<asp:BoundColumn DataField="CreateLoginID" SortExpression="CreateLoginID" HeaderText="������"></asp:BoundColumn>
											<asp:TemplateColumn HeaderText="����">
												<HeaderStyle Width="60px"></HeaderStyle>
												<ItemTemplate>
													<asp:LinkButton id="LinkButStartExam" runat="server" Text="��ʼ��ҵ" CommandName="StartExam" CausesValidation="false">��ʼ��ҵ</asp:LinkButton>
												</ItemTemplate>
											</asp:TemplateColumn>
											<asp:BoundColumn Visible="False" DataField="PaperType" ReadOnly="True" HeaderText="�Ծ�����"></asp:BoundColumn>
											<asp:BoundColumn Visible="False" DataField="StartTime" ReadOnly="True" HeaderText="��ʼʱ��"></asp:BoundColumn>
											<asp:BoundColumn Visible="False" DataField="EndTime" ReadOnly="True" HeaderText="����ʱ��"></asp:BoundColumn>
											<asp:BoundColumn Visible="False" DataField="CreateWay" ReadOnly="True" HeaderText="���ʽ"></asp:BoundColumn>
											<asp:BoundColumn Visible="False" DataField="ShowModal" ReadOnly="True" HeaderText="��ʾģʽ"></asp:BoundColumn>
										</Columns>
										<PagerStyle Height="23px" HorizontalAlign="Right" Mode="NumericPages"></PagerStyle>
									</asp:datagrid><FONT face="����">����<asp:label id="LabelRecord" runat="server" Font-Bold="True" Font-Names="����" ForeColor="Blue">0</asp:label>����¼&nbsp;<asp:label id="LabelCountPage" runat="server" Font-Bold="True" Font-Names="����" ForeColor="Blue">0</asp:label>ҳ&nbsp;��ǰ�ǵ�<asp:label id="LabelCurrentPage" runat="server" Font-Bold="True" Font-Names="����" ForeColor="Blue">0</asp:label>ҳ&nbsp;</FONT>
									<asp:linkbutton id="LinkButFirstPage" runat="server" onclick="LinkButFirstPage_Click">��һҳ</asp:linkbutton>&nbsp;
									<asp:linkbutton id="LinkButPirorPage" runat="server" onclick="LinkButPirorPage_Click">��һҳ</asp:linkbutton>&nbsp;
									<asp:linkbutton id="LinkButNextPage" runat="server" onclick="LinkButNextPage_Click">��һҳ</asp:linkbutton>&nbsp;
									<asp:linkbutton id="LinkButLastPage" runat="server" onclick="LinkButLastPage_Click">���ҳ</asp:linkbutton></td>
							</tr>
						</table>
						<!--���ݽ���-->
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
