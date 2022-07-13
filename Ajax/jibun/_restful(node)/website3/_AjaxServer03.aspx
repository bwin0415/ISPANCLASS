<%@ Page Language="C#" ContentType="text/html" %>
<% 
    System.Threading.Thread.Sleep(1000);
    if(Request["username"] != null)
        Response.Write("歡迎" + Request["username"] + "光臨我們網站..." );
    else
        Response.Write("歡迎光臨我們網站..." );
%>

