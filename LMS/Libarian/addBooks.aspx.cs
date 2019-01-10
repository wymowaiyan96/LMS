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
    public partial class addBooks : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Coding\ASP.Net\Library Management\LibraryMS\LMS\LMS\App_Data\LMS.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        protected void btnPayment_Click(object sender, EventArgs e)
        {
            string path="";
            f1.SaveAs(Request.PhysicalApplicationPath + "/Libarian/book_images/" + f1.FileName.ToString());
            path = "book_images/" + f1.FileName.ToString();


            SqlCommand cmd = new SqlCommand("INSERT INTO books VALUES ('" + tbxBookTitle.Text + "','"+path.ToString()+"','"+tbxAuthor.Text+"','"+tbxISBN.Text+"','"+tbxQty.Text+"') ", con);
            cmd.ExecuteNonQuery();            
            info.Style.Add("display", "block");

            tbxQty.Text = "";
            tbxISBN.Text = "";
            tbxBookTitle.Text = "";
            tbxAuthor.Text = "";
        }
    }
}