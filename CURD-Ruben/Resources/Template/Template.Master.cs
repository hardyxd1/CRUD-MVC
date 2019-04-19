using System;

namespace CURD_Ruben.Resources.Template
{
    public partial class Template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] stEmail = null;
                if (Session["sessionEmail"] != null)
                {
                    stEmail = Session["sessionEmail"].ToString().Split('@');
                    lbl_usuario.Text = stEmail[0];
                }
                else Response.Redirect("~/Views/Login/Login.aspx");
                //@"~\tmp\

               // imgCuenta.ImageUrl = "~/tmp/ " + Session["sessionEmail"].ToString() + ".jpg";
            }
        }


        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("~/Views/Login/Login.aspx");
        }
    }
}