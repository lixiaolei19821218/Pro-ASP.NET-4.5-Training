﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Price.aspx.cs" Inherits="Events.Price" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <p>Today's date is <%= DateTime.Now.ToShortDateString() %></p>
<p>A new shirt costs <%= 20.ToString("C") %></p>
</body>
</html>
