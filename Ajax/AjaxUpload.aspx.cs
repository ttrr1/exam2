using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;
using System.Collections;
using LitJson;

/// <summary>
/// 上传图片或文件
/// </summary>
public partial class Ajax_AjaxUpload : System.Web.UI.Page
{
    /// <summary>
    /// 获取当前要执行的函数名
    /// </summary>
    public string methodName ="";

    protected void Page_Load(object sender, EventArgs e)
    {
        methodName = Request["method"];
        if (methodName != "")
        {
            Type type = GetType();
            MethodInfo method = type.GetMethod(methodName);
            if (method != null) {
                method.Invoke(this, null);
            }
        }
    }


    /// <summary>
    /// 上传图片()
    /// </summary>
    public void UploadPhoto() {

        UploadFiles upload = new UploadFiles("UploadFile");
        upload.TWidth = 50;
        upload.UpLoadIMG(Request.Files[0]);
        ResponseWrite(upload.FileName);
    }

    /// <summary>
    /// 上传新闻内容图片
    /// </summary>
    public void UpLoadImgNewsContent()
    {
        UploadFiles ui = new UploadFiles("UploadFile/News");
        bool flg = ui.UpLoadIMG(Request.Files["imgFile"]);

        Hashtable hash = new Hashtable();
        hash["error"] = 0;
        hash["url"] = ui.FileName;
        hash["title"] = ui.TFileName;
        Response.AddHeader("Content-Type", "text/html; charset=UTF-8");
        Response.Write(JsonMapper.ToJson(hash));
        Response.End();
    }

    /// <summary>
    /// 上传文件
    /// </summary>
    public void UploadFile() {
        UploadFiles ui = new UploadFiles("UploadFile");
        bool flg = ui.UpLoadFile(Request.Files["imgFile"]);

        Hashtable hash = new Hashtable();
        hash["error"] = 0;
        hash["url"] = ui.FileName;
        Response.AddHeader("Content-Type", "text/html; charset=UTF-8");
        Response.Write(JsonMapper.ToJson(hash));
        Response.End();
    }

    /// <summary>
    /// 输出
    /// </summary>
    /// <param name="obj"></param>
    public void ResponseWrite(object obj) {
        if (obj == null) {
            obj = "";
        }
        Response.Write(obj.ToString());
        ApplicationInstance.CompleteRequest();
    }
}