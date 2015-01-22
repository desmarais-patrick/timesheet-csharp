<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<% if (Request.IsAuthenticated) { %>
    <b><%: Page.User.Identity.Name %></b><%: Html.ActionLink("Déconnexion", "LogOff", "Account") %>
<% } else { %> 
    <%: Html.ActionLink("Connexion", "LogOn", "Account") %>
<% } %>