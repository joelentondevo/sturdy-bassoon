﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>

    <form name="login" action="api/Login2/LoginAttempt" method="post"
        enctype="application/x-www-form-urlencoded">
     <label for="username">Username:</label>
     <input type="text" id="username" name="username">
    <label for="password">Password:</label>
    <input type="password" id="password" name="password">
    <input type="submit" value="Submit">
   </form>

    <p id="failmessage" style="visibility:hidden">
        LOGIN FAILED
    </p>

</body>
</html>

<script>

</script>