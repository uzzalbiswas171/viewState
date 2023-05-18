using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String name = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitbutto_Click(object sender, EventArgs e)
        {
           name=nametextbox.Text;
           addresstextbox.Text = name;
            ViewState["name"] = name;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           showtextbox.Text= ViewState["name"].ToString();
        }
    }
}