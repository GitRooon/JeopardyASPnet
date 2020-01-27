using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Assignment2_Roonechr_Prog37721
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            Boolean validUserName = false;
            string userName = userNameTbox.Text;
            string password = passwordTbox.Text;
            string lastName = lastNameTbox.Text;

            using (SqlConnection conn
              = new SqlConnection("Server=localhost; Database=Assignment2; User Id=Roonechr; Password=123"))
            {

                SqlCommand cmd = conn.CreateCommand();
                string query = "Select password from Users Where firstName='" + userName+"'" ;

                cmd.CommandText = query;

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    validUserName = true;
                }
                else
                {
                    AcctCreated.Text = userName + " Already Taken";
                }
                conn.Close();
                if (validUserName)
                {

                    query = "insert into Users Values('" + userName + "','" + password + "','" + lastName + "')";
                    conn.Open();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();

                    AcctCreated.Text = userName + " Account created!";
                }

            }
        }

        protected void returnButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}