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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            Boolean validUser = false;
           using (SqlConnection conn 
                = new SqlConnection("Server=localhost; Database=Assignment2; User Id=Roonechr; Password=123"))
            {

                SqlCommand cmd = conn.CreateCommand();

                string userNameEntered = userNameTbox.Text;
                string query = "Select password from Users Where firstName='"+userNameEntered+"'";

                cmd.CommandText = query;

               conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (passwordTbox.Text.Equals(reader.GetString(0)))
                        {
                            validUser = true;
                        }
                        System.Diagnostics.Debug.WriteLine(reader.GetString(0));
                        System.Diagnostics.Debug.WriteLine(validUser);
                    }
                }

                if (validUser)
                {
                    if (userNameEntered == "Admin")
                    {
                        Response.Redirect("adminPage.aspx");
                    }


                    Session["userName"] = userNameEntered;
                    Session["validUser"] = true;
                    


                    //HttpContext currContext = HttpContext.Current;
                    //currContext.Items.Add("userName", userNameEntered);
                    //currContext.Items.Add("validUser", "true");
                   // Server.Transfer("Order.aspx");
                    Response.Redirect("Order.aspx");
                }
                
            }
        }

        protected void makeacctButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void skipLoginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Order.aspx");
        }
    }
}