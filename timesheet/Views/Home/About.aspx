<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
    À propos de ce site
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="text-center">
        <h2>À propos de ce site</h2>
    </div>
        
    <div style="margin-top: 40px">
        <p>Ce site est un exemple ASP.NET-C#. Le projet a été créé depuis VisualStudio 2010 et d'une base de projet MVC 2.</p>
    </div>
</asp:Content>
