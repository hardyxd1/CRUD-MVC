<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="Tareas.aspx.cs" Inherits="CURD_Ruben.Views.Tareas.Tareas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="contenedor" runat="server">
    <!-- Sweet alerts-->
    <link href="../../css/sweetalert.css" rel="stylesheet" type="text/css" />
    <script src="../../js/sweetalert.min.js"></script>
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
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div class="container">
        <div class="card mx-auto mt-5">
            <div class="card-header">Crear Tareas </div>
            <div class="card-body">
                <%--Fila 1--%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-12">
                            <h1>
                                <b>Informacion sobre la tarea</b>
                                <asp:Label runat="server" ID="lbl_opc" Visible="false"></asp:Label>
                            </h1>
                        </div>
                    </div>

                </div>
                <%--Fila 2--%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lbl_titularTarea" Text="Titular Tarea"></asp:Label>
                            <asp:TextBox runat="server" ID="txt_titulartarea" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbwt_TitularTarea" runat="server"
                                TargetControlID="txt_titulartarea"
                                WatermarkText="Titular Tarea"
                                WatermarkCssClass="watermarked" />
                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lbl_Asunto" Text="Asunto"></asp:Label>
                            <asp:TextBox runat="server" ID="txt_Asunto" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbwt_Asunto" runat="server"
                                TargetControlID="txt_Asunto"
                                WatermarkText="Asunto"
                                WatermarkCssClass="watermarked" />
                        </div>
                    </div>
                </div>
                <%--Fila 3--%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lbl_FechaVencimiento" Text="Fecha de Vencimiento"></asp:Label>
                            <asp:TextBox runat="server" ID="txt_FechaVencimiento" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbwe_FechaVencimiento" runat="server"
                                TargetControlID="txt_FechaVencimiento"
                                WatermarkText="Fecha de Vencimiento"
                                WatermarkCssClass="watermarked" />
                            <ajaxToolkit:CalendarExtender runat="server" ID="aC_FechaVencimiento"
                                TargetControlID="txt_FechaVencimiento" Format="yyyy-MM-dd" />
                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lbl_Contacto" Text="Contacto"></asp:Label>
                            <asp:TextBox runat="server" ID="txt_Contacto" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbwe_Contacto" runat="server"
                                TargetControlID="txt_Contacto"
                                WatermarkText="Contacto"
                                WatermarkCssClass="watermarked" />
                        </div>
                    </div>
                </div>
                <%--Fila 4--%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="Lbl_Cuenta" Text="Cuenta"></asp:Label>
                            <asp:TextBox runat="server" ID="txt_Cuenta" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="twm_Cuenta" runat="server"
                                TargetControlID="txt_Cuenta"
                                WatermarkText="Cuenta"
                                WatermarkCssClass="watermarked" />

                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lbl_Estado" Text="Estado"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddl_Estado" CssClass="form-control"></asp:DropDownList>

                        </div>
                    </div>
                </div>
                <%--Fila 5--%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lbl_Prioridad" Text="Prioridad"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddl_Prioridad" CssClass="form-control"></asp:DropDownList>


                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lbl_EnviarMensajes" Text="Enviar Mensaje"></asp:Label>
                            <asp:CheckBox runat="server" ID="chb_EnviarMnesje" CssClass="form-control"></asp:CheckBox>

                        </div>
                    </div>
                </div>
                <%--Fila 6--%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lbl_Repetir" Text="Repetir"></asp:Label>
                            <asp:CheckBox runat="server" ID="chb_Repetir" CssClass="form-control"></asp:CheckBox>


                        </div>
                        <div class="col-md-6">
                            <asp:Label runat="server" ID="lbl_Descripcion" Text="Descripcion"></asp:Label>
                            <asp:TextBox runat="server" ID="txt_descripcion" CssClass="form-control"></asp:TextBox>
                            <ajaxToolkit:TextBoxWatermarkExtender ID="tbwe_descripcion" runat="server"
                                TargetControlID="txt_descripcion"
                                WatermarkText="Descripcion"
                                WatermarkCssClass="watermarked" />

                        </div>
                    </div>
                </div>
                <%-- Fila 7--%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-12">
                            <asp:Button runat="server" ID="btn_Guardad" Text="Guardar" CssClass="btn btn-primary" OnClick="btn_Guardad_Click" />
                            <asp:Button runat="server" ID="btn_Cancelar" Text="Cancelar" CssClass="btn btn-primary" OnClick="btn_Cancelar_Click" />
                        </div>
                    </div>
                </div>
                <%--Fila 8--%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-12">
                            <asp:Label runat="server" ID="lbl_Subtitulo" Text="Resultado" />

                        </div>
                    </div>
                </div>
                <%--Fila 9--%>
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-12">
                            <asp:GridView runat="server" ID="gdv_Datos"  AutoGenerateColumns="false" EmptyDataText="No se encontraron resultados">
                                <Columns>
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:Label runat="server" ID="lbl_Codigo" Text='<%# Bind("incodTarea")%>'></asp:Label>
                                        </ItemTemplate>                                        
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Titular" DataField="sttareaTitular"/>
                                    <asp:BoundField HeaderText="Asunto" DataField="sttareaAsunto" />
                                   <asp:BoundField HeaderText="Fecha de Vencimiento" DataField="sttareaFechaVencimiento" />
                                    <asp:BoundField HeaderText="Contacto" DataField="sttareaContacto" />
                                    <asp:BoundField HeaderText="Cuenta" DataField="sttareaCuenta" />
                                    <asp:BoundField HeaderText="Estado Tarea" DataField="sttareaContacto" />
                                </Columns>
                            </asp:GridView>
                        
                            </div>

                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
