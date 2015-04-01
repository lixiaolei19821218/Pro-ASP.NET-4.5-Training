<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UsingjQuery.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Summits</title>
    <link rel="stylesheet" href="Styles.css" />
    <script src="/Scripts/jquery-2.1.3.js"></script>
    <script src="/Scripts/Default.js"></script>
</head>
<body>
    <h2>Summits</h2>
    <table id="peaksTable">
        <thead>
            <tr>
                <th class="name">Name</th>
                <th>Height (m)</th>
            </tr>
        </thead>
        <tbody id="tableBody">
            
        </tbody>
    </table>
    <input type="button" value="Delete" />
</body>
</html>
