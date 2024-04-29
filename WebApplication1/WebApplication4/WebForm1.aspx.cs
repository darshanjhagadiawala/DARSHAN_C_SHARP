using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = JINU\\SQLEXPRESS; Database = PRACTICE; Integrated Security = true");
            SqlCommand cmd = new SqlCommand(cmdText: "INSERT INTO STUDENT VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')", con);
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

        protected void Button2_Click1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = JINU\\SQLEXPRESS; Database = PRACTICE; Integrated Security = true");
            SqlCommand cmd = new SqlCommand(cmdText: "UPDATE STUDENT SET [LOCATION] = ('" + TextBox3.Text + "') WHERE FIRST_NAME = ('" + TextBox1.Text + "')", con);
            con.Open();

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Response.Write("Update Successfully.");
            }
            else
            {
                Response.Write("Not Updated.");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = JINU\\SQLEXPRESS; Database = PRACTICE; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("DELETE FROM STUDENT WHERE Location = '" + TextBox3.Text + "'", con);
            con.Open();

            int rowsAffected = cmd.ExecuteNonQuery();

            if(rowsAffected > 0)
            {
                Response.Write("Record Deleted Successfully.");
            }
            else
            {
                Response.Write("Record not Deleted.");
            }
        }
    }
}