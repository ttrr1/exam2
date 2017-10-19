<%@ Page Language="c#" Inherits="EasyExam.RubricManag.HtmlEditor" CodeFile="HtmlEditor.aspx.cs" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>HTML编辑器</title>
    <meta content="Microsoft FrontPage 5.0" name="GENERATOR">
    <meta content="C#" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
    <script type="text/javascript" src="../JavaScript/jquery-1.8.2.min.js"></script>
    <script src="../JavaScript/kindeditor-4.1.10/kindeditor-min.js" type="text/javascript"></script>
    <script language="javascript" type="text/javascript" src="../JavaScript/kindeditor-4.1.10/kindeditor.js"></script>
    <link rel="stylesheet" href="../JavaScript/kindeditor-4.1.10/themes/default/default.css" />
    <link rel="stylesheet" href="../JavaScript/kindeditor-4.1.10/plugins/code/prettify.css" />
    <script type="text/javascript" charset="utf-8" src="../JavaScript/kindeditor-4.1.10/kindeditor.js"></script>
    <script type="text/javascript" charset="utf-8" src="../JavaScript/kindeditor-4.1.10/lang/zh_CN.js"></script>
    <script type="text/javascript" charset="utf-8" src="../JavaScript/kindeditor-4.1.10/plugins/code/prettify.js"></script>
    <script language="javascript">
        function ReturnText() {
            try {
                //  var cc = EditorIframe.getHTML();
                var content = document.getElementById("EditorIframe").value;
                alert(content);
                opener.HtmlEditorCallBack(content);
            } catch (e) { };
            window.close();
        }
        function GetHtmlEditorText() {
            EditorIframe.setHTML(opener.SetHtmlEditorText());
        }
       
        KindEditor.ready(function (K) {
            var editor1 = K.create('#EditorIframe', {
                cssPath: '../plugins/code/prettify.css',
                uploadJson: '../Editor/upload_json.ashx',
                allowFileManager: true,
                afterBlur: function () { this.sync(); }
            });

        });
    </script>
    <link href="../CSS/STYLE.CSS" type="text/css" rel="stylesheet" />
</head>
<body leftmargin="0" topmargin="0" rightmargin="0" onload="GetHtmlEditorText()">
    <form id="Form1" method="post" enctype="multipart/form-data" runat="server">
    <table id="Table1" style="width: 600px; border-collapse: collapse; height: 350px"
        cellspacing="0" bordercolordark="#6699ff" cellpadding="0"  align="center"
        bordercolorlight="#6699ff" border="1">
        <tr>
            <td width="520" colspan="6">
               <%-- <asp:TextBox ID="EditorIframe" name="content"  Height="288px" TextMode="MultiLine"
                    Width="100%"></asp:TextBox>--%>
                    <textarea ID="EditorIframe" name="content"   style="width:100%;height:288px;visibility:hidden;">
                <%=content%>
                </textarea>
                 
                <%-- <IFRAME id="EditorIframe" style="WIDTH: 100%; HEIGHT: 288px" src="../Editor/Editor.aspx?SectionID=<%=strSectionID%>"
							frameBorder="0" scrolling="no"></IFRAME>--%>
            </td>
        </tr>
        <tr height="30">
            <td align="center" width="513" colspan="6">
                <input class="button" onclick="ReturnText();" type="button" value="提 交" name="Button">&nbsp;
                <input class="button" onclick="window.close();" type="button" value="取 消" name="Button">
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
