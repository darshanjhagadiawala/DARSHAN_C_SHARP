using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void page_load(object sender, eventargs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = JINU\\SQLEXPRESS; Database = PRACTICE; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("INSERTINTOREGISTER", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EID", int.Parse(TextBox1.Text));
            cmd.Parameters.AddWithValue("@ENAME", TextBox2.Text);
            cmd.Parameters.AddWithValue("@EMAIL", TextBox3.Text);
            cmd.Parameters.AddWithValue("@MOBILE_NO", TextBox4.Text);
            con.Open();

            int RowsAffected = cmd.ExecuteNonQuery();

            if (RowsAffected > 0)
            {
                Response.Write("Data Inserted Successfully");
            }
            else
            {
                Response.Write("Data is not Inserted.");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = JINU\\SQLEXPRESS; Database = PRACTICE; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("UPDATEINTOREGISTER", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EID", int.Parse(TextBox1.Text));
            cmd.Parameters.AddWithValue("@ENAME", (TextBox2.Text));
            cmd.Parameters.AddWithValue("@EMAIL", (TextBox3.Text));
            cmd.Parameters.AddWithValue("@MOBILE_NO", (TextBox4.Text));
            con.Open();

            int RowsAffected = cmd.ExecuteNonQuery();

            if(RowsAffected > 0)
            {
                Response.Write("Data Updated Successfully.");
            }
            else
            {
                Response.Write("Data is not Updated.");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = JINU\\SQLEXPRESS; Database = PRACTICE; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("DELETEINTOREGISTER", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EID", int.Parse(TextBox1.Text));
            cmd.Parameters.AddWithValue("@ENAME", (TextBox2.Text));
            cmd.Parameters.AddWithValue("@EMAIL", (TextBox3.Text));
            cmd.Parameters.AddWithValue("@MOBILE_NO", (TextBox4.Text));
            con.Open();

            int RowsAffected = cmd.ExecuteNonQuery();

            if(RowsAffected > 0)
            {
                Response.Write("Data Deleted Successfully.");
            }
            else
            {
                Response.Write("Data is not Deleted.");
            }
        //}
    }
}