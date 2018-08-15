<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="SroPanelV1.profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Text="New UserName : "></asp:Label>
        <asp:TextBox ID="username" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="New Password : "></asp:Label>
        <asp:TextBox ID="password" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Change/Değiştir" CssClass="btn-success" OnClick="Button1_Click" />
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    </div>

</asp:Content>
