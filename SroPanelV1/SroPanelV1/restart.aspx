<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="restart.aspx.cs" Inherits="SroPanelV1.restart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="jumbotron">
         <img src="img/power.png" class="img-circle" alt="user" width="50" height="50" runat="server" />
                           <label for="res" runat="server">Restart Atmak</label>
    <asp:Button ID="reset" runat="server" Text="Server Makinasına Restart At" CssClass="btn-success" OnClick="reset_Click"  />
        <br />
        <asp:Label ID="Label1" runat="server" Text="" CssClass="text-danger"></asp:Label>
    </div>



</asp:Content>
