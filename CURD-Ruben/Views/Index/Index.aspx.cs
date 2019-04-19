using System;

namespace CURD_Ruben.Views.Index
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string stEmail = string.Empty;
            if (!IsPostBack)
            {
                if (Request.QueryString["stEmail"] != null) stEmail = Request.QueryString["stEmail"].ToString();
                //@"~\tmp\
                imgCuenta.ImageUrl = @"~\tmp\" + Session["sessionEmail"].ToString() + ".jpg";




            }
        }
    }
}