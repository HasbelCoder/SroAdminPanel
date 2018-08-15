<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="yonetim.aspx.cs" Inherits="SroPanelV1.yonetim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


  
       
           <div class="container">
               <div class="form-group pull-left">
                  
           <asp:TextBox CssClass="text-success" ID="TextBox1" runat="server"  Width="500" Height="200" TextMode="MultiLine" ></asp:TextBox>
                
               
             </div>
               <br />
               <br />
               <br />
               &nbsp&nbsp&nbsp&nbsp<asp:Button ID="Button1" runat="server" Text="Gönder/Submit" CssClass="btn-success" OnClick="Button1_Click"/>
               <asp:Label ID="Label1" runat="server" CssClass="label-warning"></asp:Label>
       </div>

 
        
     

</asp:Content>
