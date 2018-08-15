<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SroPanelV1.Default" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-theme.min.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-1.9.0.min.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
<div class="container" runat="server">
       <div class="row" runat="server">
           <div class="col-md-8 col-md-offset-2" runat="server">
               <h4 class="text-center">SILKROAD MONITOR PANEL V.10000</h4>
               <div class="well" runat="server">
                   <form runat="server">
                       <img src="img/favicon.png" class="img-circle" alt="user" width="100" height="150" runat="server" />
                       &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp<label class="alert-warning" for="database" runat="server">Varsayılan/Default Username : admin <br /> Varsayılan/Default Password : admin</label>
                       <p class="bg-danger">[TR] Lütfen Database ismini doğru giridiğinizden emin olunuz aksi takdirde bağlantı başarısız olacaktır!...</p>
                       <p class="bg-danger">[EN] You must enter the correct database name otherwise you will fail</p>

                       <div class="form-group" runat="server">
                           <label for="username" runat="server">Username:</label>
                           <asp:TextBox ID="kad" runat="server" class="form-control" meta:resourcekey="kadResource1"></asp:TextBox>
                       </div>

                       <div class="form-group" runat="server">
                           <label for="password" runat="server">Password:</label>
                           <asp:TextBox ID="password" runat="server" class="form-control" meta:resourcekey="passwordResource1"></asp:TextBox>
                         
                          
                       </div>
                       <div class="form-group" runat="server">
                           <label for="database" runat="server">Database Name:</label>
                           <asp:TextBox ID="dbad" runat="server" class="form-control" meta:resourcekey="dbadResource1">SRO_VT_ACCOUNT</asp:TextBox>
                            <asp:Button ID="button" runat="server"  Text="Giriş Yap" style="position:relative;top:5px;" CssClass="btn btn-danger" OnClick="button_Click" meta:resourcekey="buttonResource1"/>
                       </div>
                       <asp:Label ID="Label1" runat="server" meta:resourcekey="Label1Resource1"></asp:Label>
                       

                       
                   </form>
                   
               </div>
           </div>
       </div>
    </div>
</body>
</html>