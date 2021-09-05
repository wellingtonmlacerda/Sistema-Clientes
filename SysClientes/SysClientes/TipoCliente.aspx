<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TipoCliente.aspx.cs" Inherits="SysClientes.TipoClienteCrud" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1">
        <div style="width: 100%;" align="center">
            <fieldset style="width: 60%;">
                <legend>CRUD Tipo de Cliente</legend>
                <table class="table">
                    <tr>
                        <td>Tipo</td>
                        <td>
                            <asp:TextBox ID="txtTipo" runat="server" class="form-control"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Razão Socieal</td>
                        <td>
                            <asp:TextBox ID="txtDescricao" runat="server" class="form-control"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td class="style1">
                            <asp:Button ID="btnSubmit" runat="server" Text="Salvar" OnClick="btnSubmit_Click" class="btn btn-success"/>
                            <asp:Button ID="btnCancel" runat="server" Text="Cancelar" OnClick="btnCancel_Click" class="btn btn-danger"/>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="lblStatus" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:GridView ID="grdWcfTest" runat="server" AutoGenerateColumns="False" DataKeyNames="TICL_PK_ID"
                                CellPadding="5" Width="100%">
                                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                <Columns>
                                    <asp:TemplateField HeaderText="ID">
                                        <ItemTemplate>
                                            <asp:Label ID="lblId" runat="server" Text='<%#Eval("TICL_PK_ID")%>' class="form-label">  
                                            </asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField><asp:TemplateField HeaderText="Tipo">
                                        <ItemTemplate>
                                            <asp:Label ID="lblName" runat="server" Text='<%# Eval("TICL_TIPO")%>' class="form-label">  
                                            </asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Descrição">
                                        <ItemTemplate>
                                            <asp:Label ID="lblNascimento" runat="server" Text='<%#Eval("TICL_DESCRICAO") %>'>  
                                            </asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Editar">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" Text="Editar" CausesValidation="false"
                                                CommandArgument=' <%#Eval("TICL_PK_ID") %>' OnCommand="lnkEdit_Command" ToolTip="Edit" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Excluir">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkDelete" runat="server" Text="Excluir" CausesValidation="false"
                                                CommandArgument='  
                                                <%#Eval("TICL_PK_ID") %>'
                                                CommandName="Delete" OnCommand="lnkDelete_Command"
                                                OnClientClick="return confirm('Você tem certeza que deseja excluir esse registro?')" ToolTip="Delete" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </fieldset>
        </div>
    </form>
</asp:Content>
