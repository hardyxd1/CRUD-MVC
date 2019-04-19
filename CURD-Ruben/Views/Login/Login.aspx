<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CURD_Ruben.Views.Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />

    <title>Login</title>
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

</head>
<body class="bg-dark">

    <div class="container">
        <div class="card card-login mx-auto mt-5">
            <div class="card-header">Login</div>
            <div class="card-body">
                <form id="form1" runat="server">
                    <div class="form-group">
                        <div class="form-label-group">
                            <asp:Label ID="LblEmail" runat="server" Text="Email"></asp:Label>
                            <asp:TextBox ID="txt_Email" runat="server" CssClass="form-control"></asp:TextBox>

                        </div>
                    </div>
                    <div class="form-group">
                        <div class="form-label-group">
                            <asp:Label ID="Lblpassword" runat="server" Text="Password"></asp:Label>
                            <asp:TextBox ID="txt_password" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>

                        </div>
                    </div>
                    <div class="form-group">
                        <div class="checkbox">
                            <label class="form-check-label" />
                            <asp:CheckBox ID="chk_remeberpassword" runat="server" Text="Remeber Password" />
                        </div>
                    </div>
                    <asp:Button ID="btnAceptar" runat="server" CssClass="btn btn-primary btn-block" Text="Login" OnClick="btnAceptar_Click" />
                </form>
                <div class="text-center">
                    <a class="d-block small mt-3" href="../Register/Register.aspx">Register an Account</a>
                    <a class="d-block small" href="../Forgot-Password/Forgot_Password.aspx">Forgot Password?</a>
                </div>
            </div>
        </div>
    </div>



</body>
</html>
