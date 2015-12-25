<%@ Page Title="" Language="C#" MasterPageFile="~/XtremeCinema.Master" AutoEventWireup="true" CodeBehind="RentMovies.aspx.cs" Inherits="HW5_Exercise9._4.RentMovies" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .validation-error {
            color: red;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceholder" runat="server">
    <div class="callout" style="overflow: auto">
        <h3>Rent a Movie</h3>
        <form id="rentMovieForm" runat="server">
            <div class="row">
                <div class="large-6 columns">
                    <label>
                        Movie Title
                    <asp:RequiredFieldValidator CssClass="validation-error" ControlToValidate="movieTitleTextBox" ID="movieTitleRequiredFieldValidator" runat="server" ErrorMessage="(Required)"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="movieTitleTextBox" runat="server"></asp:TextBox>
                    </label>
                </div>

                <div class="large-6 columns">
                    <label>&nbsp;</label>
                    <asp:CheckBox ID="newReleaseCheckBox" runat="server" />
                    <asp:Label AssociatedControlID="newReleaseCheckBox" ID="newReleaseCheckBoxLabel" runat="server" Text="New Release"></asp:Label>
                    <i>($1 extra)</i>
                </div>
            </div>
            <div class="row">
                <div class="large-6 columns">
                    <label>Movie Format</label>
                    <asp:RadioButton ID="dvdFormat" runat="server" Checked="True" GroupName="movieFormat" />
                    <asp:Label AssociatedControlID="dvdFormat" ID="dvdFormatLabel" runat="server" Text="DVD"></asp:Label>
                    <i>($4.50)</i>
                    <asp:RadioButton ID="bluerayFormat" runat="server" GroupName="movieFormat" />
                    <asp:Label AssociatedControlID="bluerayFormat" ID="bluerayFormatLabel" runat="server" Text="Blueray"></asp:Label>
                    <i>($5.00)</i>
                </div>

                <div class="large-6 columns">
                    <label>&nbsp;</label>
                    <asp:CheckBox ID="membershipCheckBox" runat="server" />
                    <asp:Label AssociatedControlID="membershipCheckBox" ID="membershipCheckBoxLabel" runat="server" Text="Member"></asp:Label>
                    <i>(10% off)</i>
                </div>
            </div>
            <div class="row" style="margin: 30px 0">
                <b>
                    <asp:Label ID="totalCostLabel" runat="server"></asp:Label>
                </b>
            </div>
            <div class="row">
                <div class="medium-5 columns">
                    <div class="button-group">
                        <asp:Button ID="calculateButton" runat="server" Text="Calculate" CssClass="button" OnClick="calculateButton_Click" CausesValidation="False" />
                        <asp:Button ID="orderButton" runat="server" Text="Place Order" CssClass="button" OnClick="orderButton_Click" />
                    </div>
                </div>
                <div class="medium-4 columns text-right">
                    <asp:Button ID="clearButton" runat="server" Text="Clear Form" CssClass="button" OnClick="clearButton_Click" CausesValidation="False" />
                </div>
            </div>
        </form>
    </div>

</asp:Content>
