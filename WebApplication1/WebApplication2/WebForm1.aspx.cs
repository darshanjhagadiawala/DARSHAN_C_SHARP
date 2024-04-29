using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Visibility(object sender, EventArgs e)
        {
            Label1.Visible = !Label1.Visible;
        }
        protected void Visibility1(object sender, EventArgs e)
        {
            GridView1.Visible = !GridView1.Visible;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}