<%@ Page Title="Vending Machine" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VendingMachine._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div id="MachineDiv" style="float: left">
                <asp:Table ID="MachineTable" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="5px" Height="500px" Width="500px">
                    <asp:TableRow HorizontalAlign="Center">
                        <asp:TableCell>
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/gum-blue.jpg" Width="50px" Height="100px" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Table runat="server">
                                <asp:TableRow>
                                    <asp:TableCell  Height="50px">
                                        <asp:Label ID="A1Cost" runat="server" Text="25 Cents"></asp:Label>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell  Height="50px">
                                        <asp:Button ID="A1Button" runat="server" Text="A1" OnClick="ItemButton_Click" />
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/gum-pink.jpg" Width="50px" Height="100px" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Table runat="server">
                                <asp:TableRow>
                                    <asp:TableCell  Height="50px">
                                        <asp:Label ID="A2Cost" runat="server" Text="25 Cents"></asp:Label>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Height="50px">
                                        <asp:Button ID="A2Button" runat="server" Text="A2" OnClick="ItemButton_Click" />
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/gum-green.jpg" Width="50px" Height="100px" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Table runat="server">
                                <asp:TableRow>
                                    <asp:TableCell Height="50px">
                                        <asp:Label ID="A3Cost" runat="server" Text="25 Cents"></asp:Label>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Height="50px">
                                        <asp:Button ID="A3Button" runat="server" Text="A3" OnClick="ItemButton_Click" />
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow HorizontalAlign="Center">
                        <asp:TableCell>
                            <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/chips-plain.jpg" Width="100px" Height="100px" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Table runat="server">
                                <asp:TableRow>
                                    <asp:TableCell Height="50px">
                                        <asp:Label ID="B1Cost" runat="server" Text="25 Cents"></asp:Label>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Height="50px">
                                        <asp:Button ID="B1Button" runat="server" Text="B1" OnClick="ItemButton_Click" />
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Image ID="Image5" runat="server" ImageUrl="~/Images/chips-bbq.jpg" Width="100px" Height="100px" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Table runat="server">
                                <asp:TableRow>
                                    <asp:TableCell Height="50px">
                                        <asp:Label ID="B2Cost" runat="server" Text="25 Cents"></asp:Label>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Height="50px">
                                        <asp:Button ID="B2Button" runat="server" Text="B2" OnClick="ItemButton_Click" />
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Image ID="Image6" runat="server" ImageUrl="~/Images/chips-cheesy.jpg" Width="100px" Height="100px" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Table runat="server">
                                <asp:TableRow>
                                    <asp:TableCell Height="50px">
                                        <asp:Label ID="B3Cost" runat="server" Text="25 Cents"></asp:Label>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Height="50px">
                                        <asp:Button ID="B3Button" runat="server" Text="B3" OnClick="ItemButton_Click" />
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow HorizontalAlign="Center">
                        <asp:TableCell>
                            <asp:Image ID="Image7" runat="server" ImageUrl="~/Images/candybar-chocolate.jpg" Width="75px" Height="150px" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Table runat="server">
                                <asp:TableRow>
                                    <asp:TableCell Height="50px">
                                        <asp:Label ID="C1Cost" runat="server" Text="25 Cents"></asp:Label>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Height="50px">
                                        <asp:Button ID="C1Button" runat="server" Text="C1" OnClick="ItemButton_Click" />
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Image ID="Image8" runat="server" ImageUrl="~/Images/candybar-carmel.jpg" Width="75px" Height="150px" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Table runat="server">
                                <asp:TableRow>
                                    <asp:TableCell Height="50px">
                                        <asp:Label ID="C2Cost" runat="server" Text="25 Cents" ></asp:Label>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell  Height="50px">
                                        <asp:Button ID="C2Button" runat="server" Text="C2" OnClick="ItemButton_Click" />
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Image ID="Image9" runat="server" ImageUrl="~/Images/candybar-nutty.jpg" Width="75px" Height="150px" />
                        </asp:TableCell>
                        <asp:TableCell>
                            <asp:Table runat="server">
                                <asp:TableRow>
                                    <asp:TableCell Height="50px">
                                        <asp:Label ID="C3Cost" runat="server" Text="25 Cents"></asp:Label>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell Height="50px">
                                        <asp:Button ID="C3Button" runat="server" Text="C3" OnClick="ItemButton_Click" />
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>

            </div>
            <div id="DisplayDiv" >
                <asp:Table ID="DisplayTable" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="5px" Height="500px" Width="200px">
                    <asp:TableRow HorizontalAlign="Center">
                        <asp:TableCell ID="DisplayCell" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="5px">
                            <asp:Label ID="DisplayMessage" runat="server" Text="Insert Coins"></asp:Label>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow HorizontalAlign="Center">
                        <asp:TableCell>
                            <asp:Button ID="NickelButton" runat="server" ToolTip="5 Cents"  Text="Insert Nickel" OnClick="CoinButton_Click" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow HorizontalAlign="Center">
                        <asp:TableCell>
                            <asp:Button ID="DimeButton" runat="server" ToolTip="10 Cents"  Text="Insert Dime" OnClick="CoinButton_Click" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow HorizontalAlign="Center">
                        <asp:TableCell>
                            <asp:Button ID="QuarterButton" runat="server" ToolTip="25 Cents" Text="Insert Quarter" OnClick="CoinButton_Click" />
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow HorizontalAlign="Center">
                        <asp:TableCell>
                            <asp:HiddenField ID="hidCredit" runat="server" Value="0"/>
                        </asp:TableCell>
                    </asp:TableRow>
                    <asp:TableRow HorizontalAlign="Center">
                        <asp:TableCell>
                           <asp:Button ID="TakeItemButton" runat="server" ToolTip="Take Item to reset machine" Text="Take Item" OnClick="TakeItemButton_Click" Visible="false" />
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
