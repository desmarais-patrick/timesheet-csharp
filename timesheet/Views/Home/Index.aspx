<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<timesheet.Models.TimeSheetCollection>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Feuilles de temps
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="text-center">
        <h2>Feuilles de temps</h2>
    </div>
    <div style="margin-left: auto; margin-right: auto; max-width: 400px; margin-top: 40px;">
        <ul class="list-group">
            <% foreach (var m in Model)
               { %>
                    <li class="list-group-item">
                        <span class="badge"><%= m.HoursWorked %>h</span>
                        <span><%= m.Date.ToString("d") %></span>
                        <span style="padding-left: 10px">Travail</span>
                    </li>
            <% } %>
        </ul>
    </div>
</asp:Content>