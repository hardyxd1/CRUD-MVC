<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="PosiblesClientes.aspx.cs" Inherits="CURD_Ruben.Views.Posibles_Clientes.PosiblesClientes" %>


<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
    <!-- Sweet alerts-->
    <link href="../../css/sweetalert.css" rel="stylesheet" type="text/css" />
    <script src="../../js/sweetalert.min.js"></script>
    <div class="mx-auto mt-5">
        <!--css/sb-admin.css -->
        <!-- Bootstrap core CSS-->
        <link href="../../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />

        <!-- Custom fonts for this template-->
        <link href="../../vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css" />

        <!-- Custom styles for this template-->
        <link href="../../css/sb-admin.css" rel="stylesheet" />
        <!-- Bootstrap core JavaScript-->
        <script src="../..vendor/jquery/jquery.min.js"></script>

        <script src="../..vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

        <script src="../..vendor/jquery-easing/jquery.easing.min.js"></script>
        <!-- Sweet alerts-->
        <link href="../../css/sweetalert.css" rel="stylesheet" type="text/css" />
        <script src="../../js/sweetalert.min.js"></script>
       
        <%--Primera Seccion--%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <h3>
                        <b>Posibles Clientes</b>
                        <asp:Label runat="server" ID="lbl_opc" Visible="false"></asp:Label>
                    </h3>

                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-3">
                    <asp:Label ID="lbl_Identificacion" runat="server" Text="Identificacion"></asp:Label>
                    <asp:TextBox ID="txt_Identificacion" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label ID="lbl_Empresa" runat="server" Text="Empresa"></asp:Label>
                    <asp:TextBox ID="txt_Empresa" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label ID="lbl_PrimerNombre" runat="server" Text="Primer Nombre"></asp:Label>
                    <asp:TextBox ID="txt_PNombre" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label ID="lbl_SegundoNombre" runat="server" Text="Segundo Nombre"></asp:Label>
                    <asp:TextBox ID="txt_SNombre" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <%--Segunda Seccion--%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-3">
                    <asp:Label ID="lbl_PrimerApellido" runat="server" Text="Primer Apellido"></asp:Label>
                    <asp:TextBox ID="txt_PA" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label ID="lbl_SegundoApellido" runat="server" Text="Segundo Apellido"></asp:Label>
                    <asp:TextBox ID="txt_SA" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label ID="lbl_Dirreccion" runat="server" Text="Dirreccion"></asp:Label>
                    <asp:TextBox ID="txt_dir" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label ID="lbl_Telefono" runat="server" Text="Telefono"></asp:Label>
                    <asp:TextBox ID="txt_telefono" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <%--Tercer Seccion--%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <asp:Label ID="lbl_Email" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox ID="txt_email" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        </div>
        <%--Cuarta Seccion--%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <asp:Button runat="server" ID="btn_Guardad" Text="Guardar" CssClass="btn btn-primary" OnClick="btn_Guardad_Click" />
                    <asp:Button runat="server" ID="btn_Cancelar" Text="Cancelar" CssClass="btn btn-primary" OnClick="btn_Cancelar_Click" />
                </div>
            </div>
        </div>
        <%--Quinta Seccion--%>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <asp:Label runat="server" ID="lbl_Subtitulo" Text="Resultado" />

                </div>
            </div>
        </div>
        <div class="form-group">
            <div class="form-row">
                <div class="col-md-12">
                    <asp:GridView runat="server" ID="gv_datos"
                        Width="100%"
                        AutoGenerateColumns="false"
                        EmptyDataText="No se encontraron registros"
                        OnRowCommand="gvDatos_RowCommand">
                        <Columns>
                            <%--Representacion de datos en controles web--%>
                            <asp:TemplateField HeaderText="Idenfticicacion">
                                <ItemTemplate>
                                    <asp:Label runat="server" ID="lblIdentificacion" Text='<%# Bind("Identificacion")%>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <%--Representacion de datos en celdas --%>
                            <asp:BoundField HeaderText="Empresa" DataField="Empresa" />
                            <asp:BoundField HeaderText="Primero Nombre" DataField="Primero_Nombre" />
                            <asp:BoundField HeaderText="Segundo Nombre" DataField="Segundo_Nombre" />
                            <asp:BoundField HeaderText="Primero Apellido" DataField="Primero_Apellido" />
                            <asp:BoundField HeaderText="Segundo Apellido" DataField="Segundo_Apellido" />
                            <asp:BoundField HeaderText="Telefono" DataField="Telefono" />
                            <asp:BoundField HeaderText="Dirrecion" DataField="Dirreccion" />
                            <asp:BoundField HeaderText="Correo" DataField="Email" />
                            <%--Editar--%>
                            <asp:TemplateField HeaderText="Editar">
                                <ItemTemplate>
                                    <asp:ImageButton runat="server" ID="btn_Editar" ImageUrl="~/img/editar.png" Width="36px"
                                        CommandName="Editar" CommandArgument='<%#((GridViewRow)Container).RowIndex%>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <%--Eliminar--%>
                            <asp:TemplateField HeaderText="Eliminar">
                                <ItemTemplate>
                                    <asp:ImageButton runat="server" ID="btn_Eliminar" ImageUrl="~/img/eliminar.png" Width="36px"
                                        CommandName="Eliminar" CommandArgument='<%#((GridViewRow)Container).RowIndex%>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
