<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Xuly.aspx.cs" Inherits="Web11.Xuly" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Danh sách nhân viên</title>
    <style>
    *{
        font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    }

    h2{
        text-align: center;
    }

    table{
		border-collapse:collapse;
	}

    .table-content{
		margin: 0 auto;
		width: 500px;
	}

	td, th{
        border: 1px solid;
		width: 250px;
		padding: 1px 8px;
		height: 30px;
		line-height: 30px;
    }

    thead{
        background-color:whitesmoke;
    }

    a{
        border-style: solid;
        border-color: inherit;
        border-width: 1px;
        text-decoration:none;
        width: 70px;
        height: 30px;
        background-color: azure;
        margin: 10px 10px 10px 3px;
        display: inline-block;
        text-align:center;
        line-height:30px;
    }

    a:hover{
        background-color:cornsilk;
        color: red;
        transition: 0.5s all;
        font-weight: bold;
    }

    .auto-style1 {
        width: 51px;
     }
    .d {
         
    cursor: pointer;
    background-color: #353535;
    border: none;
    color: #f0f0f0;
    display: block;
    padding: 10px;
    width: 100%;
    font-size: 16px;
    border-radius: 3px;
    outline: none;
}

    .d:hover {
        background-color: #2abb66;
    }

    </style>
</head>
<body>
    <form id="form1" runat="server" action="Default1.aspx" method="get">
            <h2><b>Danh sách nhân viên</b></h2>
        <div class="table-content">
            <table class="right">
            <thead><tr><th class="auto-style1">STT</th><th>Họ và tên</th><th>Ngày sinh</th></tr></thead>
            <tbody id="tblNhanvien" runat="server"></tbody>
        </table>
        
            
            <a   href ="MyForm.htm" Class ="d" >Thêm</a>
        </div>
          

    </form>
</body>
</html>
