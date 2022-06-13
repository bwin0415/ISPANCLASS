<%@ Page Language="C#" ContentType="text/html" %>
<%   
    if (Request["username"] == "hello" && Request["password"] == "kitty")
        Response.Write("{\"status\": \"pass\"}");
    else
        Response.Write("{\"status\": \"fail\"}");
%>

