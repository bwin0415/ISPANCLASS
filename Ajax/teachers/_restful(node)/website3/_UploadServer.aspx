<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" %>
<script runat="server">
    private string galleryPath = "Uploads/";
    private void Page_Load(System.Object sender, System.EventArgs e)
    {
        String username = Request["username"];
        username = username == null || username == "" ? "閣下" : Request["username"];

        HttpPostedFile sourceFile = Request.Files["upload"];
        String message;
        if (sourceFile != null)//Request含upload欄位
        {
            string fileName = System.IO.Path.GetFileName(sourceFile.FileName);
            if(fileName=="")
                message = "Oops: 您忘記上傳圖檔了...";
            else
            {
                sourceFile.SaveAs(Server.MapPath(galleryPath + fileName));
                message = "感謝" + username + ": 您的檔案(" + fileName + ")上傳成功...";
            }
            Response.Write(message);
        }
    }
</script>

