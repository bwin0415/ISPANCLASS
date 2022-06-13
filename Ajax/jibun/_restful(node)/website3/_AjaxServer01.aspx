<%@ Page Language="C#" ContentType="text/html" %>
<%
    if (Request["username"] == "小倩" && Request["password"] == "采臣")
        Response.Write("pass");
    else
        Response.Write("fail");    
%>

