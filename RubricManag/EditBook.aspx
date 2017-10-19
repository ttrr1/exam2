<%@ Page Language="c#" Inherits="EasyExam.RubricManag.EditBook" CodeFile="EditBook.aspx.cs" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>HTML编辑器</title>
    <meta content="Microsoft FrontPage 5.0" name="GENERATOR">
    <meta content="C#" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
    <%--<script language="javascript">
			function ReturnText()
			{
				try
				{
					opener.HtmlEditorCallBack(EditorIframe.getHTML());
				}catch(e){};
				window.close();
			}
			function GetHtmlEditorText()
			{
				EditorIframe.setHTML(opener.SetHtmlEditorText());
			}
			function CheckForm()
			{
  				document.all("sectioncontent").value=EditorIframe.getHTML();
  				return true;  
			}
		</script>--%>
    <script type="text/javascript" src="../JavaScript/jquery-1.8.2.min.js"></script>
    <script src="../JavaScript/kindeditor-4.1.10/kindeditor-min.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript" src="../JavaScript/kindeditor-4.1.10/kindeditor.js"></script>
    <link rel="stylesheet" href="../JavaScript/kindeditor-4.1.10/themes/default/default.css" />
    <link rel="stylesheet" href="../JavaScript/kindeditor-4.1.10/plugins/code/prettify.css" />
    <script type="text/javascript" charset="utf-8" src="../JavaScript/kindeditor-4.1.10/kindeditor.js"></script>
    <script type="text/javascript" charset="utf-8" src="../JavaScript/kindeditor-4.1.10/lang/zh_CN.js"></script>
    <script type="text/javascript" charset="utf-8" src="../JavaScript/kindeditor-4.1.10/plugins/code/prettify.js"></script>
    <link href="../CSS/STYLE.CSS" type="text/css" rel="stylesheet" />
    <script type="text/javascript">
     
        KindEditor.ready(function (K) {
            var editor1 = K.create('#txtContent', {
                cssPath: '../plugins/code/prettify.css',
                uploadJson: '../Editor/upload_json.ashx',
                allowFileManager: true,
                afterBlur: function () { this.sync(); }
            });

        });
    </script>
</head>
<body leftmargin="0" topmargin="0" rightmargin="0">
    <form id="Form1" onsubmit="return CheckForm()" method="post" enctype="multipart/form-data"
    runat="server">
    <table id="Table1" style="width: 688px; border-collapse: collapse; height: 465px"
        cellspacing="0" bordercolordark="#6699ff" cellpadding="0" align="center" bordercolorlight="#6699ff"
        border="1">
        <tr>
            <td colspan="6">
            
            <asp:TextBox ID="txtContent" name="content" runat="server" Height="465px" TextMode="MultiLine" 
                Width="100%"></asp:TextBox>
              <%--  <iframe id="EditorIframe" style="width: 100%; height: 465px" src="../Editor/Editor1.aspx?SectionID=<%=strSectionID%>"
                    frameborder="0" scrolling="no"></iframe>--%>
            </td>
        </tr>
        <tr height="30">
            <td align="center" colspan="6">
                <textarea style="display: none; width: 72px; height: 20px" name="sectioncontent"
                    rows="1" cols="6"></textarea>
                <asp:Button ID="ButInput" runat="server" Text="提 交" CssClass="button" OnClick="ButInput_Click">
                </asp:Button>&nbsp;
                <input class="button" onclick="window.close();" type="button" value="取 消" name="Button">
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
