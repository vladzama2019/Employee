<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="Employee.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee</title>
    <script type="text/javascript" src="./scripts/jquery-3.3.1.min.js"></script>
    <script type="text/javascript" src="./scripts/main.js"></script>
</head>
<body>
    <form id="form1" runat="server" onsubmit="return onSubmit()">
        <div>
            ID:<br />
              <input type="text" name="id" id="id" value="">
              <br />
            Name:<br />
              <input type="text" name="name" id="name" value="">
              <br />
            Address:<br />
              <input type="text" name="address" id="address" value="">
            <br />
            City:<br />
              <input type="text" name="city" id="city" value="">
              <br />
            State:<br />
              <input type="text" name="state" id="state" value="">
              <br /><br />
              <input type="submit" value="Submit">
        </div>
    </form>
</body>
</html>
