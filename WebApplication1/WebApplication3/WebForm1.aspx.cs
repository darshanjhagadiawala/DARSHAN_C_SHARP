using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = JINU\\SQLEXPRESS; Database = PRACTICE; Integrated Security = true");
            Sqlcommand cmd = new Sqlcommand("INSERT INTO STUDENT VALUES ('" + TextBox1.text + "','" + TextBox2.text + TextBox3.text + "', con);       
            con.Open();

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Response.Write("Data Inserted.");
            }
            else
            {
                Response.Write("Data not Inserted.");
            }
        }
    }
}