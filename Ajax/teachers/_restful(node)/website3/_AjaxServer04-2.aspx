<%@ Page Language="C#" ContentType="text/html" %>
<% 
    if (Request["username"] != null && Request["username"] != "")
        Response.Write("歡迎"+Request["username"]+ "光臨本網站...");
    else
        Response.StatusCode = 400; //Bad Request
%>

