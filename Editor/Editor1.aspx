<%@ Page Language="c#" Inherits="EasyExam.Editor.Editor" CodeFile="Editor1.aspx.cs" %>
<html>
	<head id="Head1" runat="server">
    <script type="text/javascript" src="../JavaScript/jquery-1.8.2.min.js"></script>
      <script src="../JavaScript/kindeditor-4.1.10/kindeditor-min.js" type="text/javascript"></script>
   <script language="javascript" type="text/javascript" src="../JavaScript/kindeditor-4.1.10/kindeditor.js"></script>
    <link rel="stylesheet" href="../JavaScript/kindeditor-4.1.10/themes/default/default.css" />
	<link rel="stylesheet" href="../JavaScript/kindeditor-4.1.10/plugins/code/prettify.css" />
	<script  type="text/javascript" charset="utf-8" src="../JavaScript/kindeditor-4.1.10/kindeditor.js"></script>
	<script  type="text/javascript" charset="utf-8" src="../JavaScript/kindeditor-4.1.10/lang/zh_CN.js"></script>	
    <script  type="text/javascript" charset="utf-8" src="../JavaScript/kindeditor-4.1.10/plugins/code/prettify.js"></script>
     <title></title>
        <script type="text/javascript">
//            $(function () {
//                var editor;
//                KindEditor.ready(function (K) {
//                    editor = K.create('#txtContent', {
//                        uploadJson: '/Ajax/AjaxUpload.aspx?method=UploadPhoto',
//                        fileManagerJson: '/Ajax/AjaxUpload.aspx?method=UploadFile',
//                        allowFileManager: true,
//                        afterUpload: function (data) {

//                        },
//                        items: ['source', 'preview', 'print', 'cut', 'copy', 'paste',
//                    'plainpaste', 'wordpaste', '|', 'justifyleft', 'justifycenter', 'justifyright',
//                    'justifyfull', 'insertorderedlist', 'insertunorderedlist', 'indent', 'outdent', 'subscript',
//                    'superscript', 'clearhtml', 'quickformat', 'selectall', '|', 'fullscreen', '/',
//                    'formatblock', 'fontname', 'fontsize', '|', 'forecolor', 'hilitecolor', 'bold',
//                    'italic', 'underline', 'strikethrough', 'lineheight', 'removeformat', '|', 'image',
//                    'flash', 'media', 'insertfile', 'table', 'hr']
//                    });
//                });
//            });
           
//        });
            KindEditor.ready(function (K) {
                var editor1 = K.create('#txtContent', {
                    cssPath: '../plugins/code/prettify.css',
                    uploadJson: '../Editor/upload_json.ashx',
                    allowFileManager: true
                });

            });
        </script>
    </head>
<body>
    <form id="form1" runat="server">
       
       
            
       
            <asp:TextBox ID="txtContent" name="content" runat="server" Height="100%" TextMode="MultiLine" 
                Width="100%"></asp:TextBox>
      
            
    </form>
</body>
</html>