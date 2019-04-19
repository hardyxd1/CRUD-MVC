<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CURD_Ruben.Views.Register.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Register</title>
    <!-- Bootstrap core CSS-->
    <link href="../../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom fonts for this template-->
    <link href="../../vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">

    <!-- Page level plugin CSS-->
    <link href="../../vendor/datatables/dataTables.bootstrap4.css" rel="stylesheet">

    <!-- Custom styles for this template-->
    <link href="../../css/sb-admin.css" rel="stylesheet">
    <!-- Bootstrap core JavaScript-->
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>

    <!-- Page level plugin JavaScript-->
    <script src="../../vendor/chart.js/Chart.min.js"></script>
    <script src="../../vendor/datatables/jquery.dataTables.js"></script>
    <script src="../../vendor/datatables/dataTables.bootstrap4.js"></script>

    <!-- Custom scripts for all pages-->
    <script src="../../js/sb-admin.min.js"></script>

    <!-- Demo scripts for this page-->
    <script src="../../js/demo/datatables-demo.js"></script>
    <script src="../../js/demo/chart-area-demo.js"></script>
    <!-- Sweet alerts-->
    <link href="../../css/sweetalert.css" rel="stylesheet" type="text/css" />
    <script src="../../js/sweetalert.min.js"></script>

</head>
<body class="bg-dark">

    <div class="container">
        <div class="card card-register mx-auto mt-5">
            <div class="card-header">Register an Account</div>
            <div class="card-body">
                <form id="form1" runat="server">

                    <div class="form-group">
                        <div class="form-label-group">
                            <asp:Label ID="Lblemail" runat="server" Text="Email address"></asp:Label>
                            <asp:TextBox ID="txt_email" runat="server" TextMode="Email" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfv_email" runat="server" ErrorMessage="*" ControlToValidate="txt_email" ValidationGroup="Validar login"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-6">
                                <div class="form-label-group">
                                    <asp:Label ID="Lblpassword" runat="server" Text="Password"></asp:Label>
                                    <asp:TextBox ID="txt_password" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfv_password" runat="server" ErrorMessage="*" ControlToValidate="txt_password" ForeColor="Red" ValidationGroup="Validar login"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="form-label-group">
                                    <asp:Label ID="Lblconfirmpassword" runat="server" Text=" Confirm Password"></asp:Label>
                                    <asp:TextBox ID="txt_confirmpassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfv_confirmpassword" runat="server" ErrorMessage="*" ControlToValidate="txt_confirmpassword" ForeColor="Red" ValidationGroup="Validar login"></asp:RequiredFieldValidator>
                                    <asp:CompareValidator ID="cv_ConfirmPassword" runat="server" ErrorMessage="Passwords do not match" ControlToValidate="txt_confirmpassword" ControlToCompare="txt_password" ForeColor="Red"></asp:CompareValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-row">
                            <div class="col-md-6">
                                <div class="form-label-group">
                                    <asp:Label ID="lblimagen" runat="server" Text="upload image"></asp:Label>
                                    <asp:FileUpload runat="server" ID="fuimage" CssClass="form-control" />
                                    <asp:RequiredFieldValidator ID="rfv_image" runat="server" ErrorMessage="*" ControlToValidate="fuimage" ForeColor="Red" ValidationGroup="Validar login"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>
                    </div>
                    <asp:Button ID="btn_register" runat="server" CssClass="btn btn-primary btn-block" Text="Register" OnClick="btn_register_Click" ValidationGroup="Validar login" />
                </form>
                <div class="text-center">
                    <a class="d-block small mt-3" href="../Login/Login.aspx">Login Page</a>
                    <a class="d-block small" href="../Forgot-Password/Forgot_Password.aspx">Forgot Password?</a>
                </div>
            </div>
        </div>
    </div>


</body>

</html>
