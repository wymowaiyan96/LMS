using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace LMS.Libarian
{
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Coding\ASP.Net\Library Management\LibraryMS\LMS\LMS\App_Data\LMS.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = new SqlCommand("SELECT * from libarian_registration WHERE username='"+tbxUsername.Text+"' and password='"+tbxPassword.Text+"'",con );
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dA = new SqlDataAdapter(cmd);
            dA.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString()); //return how many rows is found

            if (i>0)
            {
                Response.Redirect("demo.aspx");
            }
            else
            {
                
               error.Style.Add("display", "block");
             
                
            }
        }
    }
}