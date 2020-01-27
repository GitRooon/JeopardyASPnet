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
    public partial class adminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(userNameList.SelectedValue.ToString());
            System.Diagnostics.Debug.WriteLine(userNameList.SelectedValue);
            using (SqlConnection conn
               = new SqlConnection("Server=localhost; Database=Assignment2; User Id=Roonechr; Password=123"))
            {
                string uNameSelected = userNameList.SelectedValue;
                SqlCommand cmd = conn.CreateCommand();

                string userNameEntered = userNameTbox.Text;
                string query = "Select * from Users Where firstName='" + uNameSelected + "'";

                cmd.CommandText = query;

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // userNameTbox.Text = reader.GetString(0);
                        //passwordTbox.Text = reader.GetString(2);
                        //lastNameTbox.Text = reader.GetString(3);

                        System.Diagnostics.Debug.WriteLine(reader.GetString(1));
                        System.Diagnostics.Debug.WriteLine(reader.GetString(2));

                        userNameTbox.Text = reader.GetString(1);
                        passwordTbox.Text = reader.GetString(2);
                        lastNameTbox.Text = reader.GetString(3);
                    }
                }
            }
        }

        protected void loadButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(userNameList.SelectedValue.ToString());
            System.Diagnostics.Debug.WriteLine(userNameList.SelectedValue);
            using (SqlConnection conn
               = new SqlConnection("Server=localhost; Database=Assignment2; User Id=Roonechr; Password=123"))
            {

                SqlCommand cmd = conn.CreateCommand();

                string userNameEntered = userNameTbox.Text;
                string query = "Select * from Users Where firstName='" + userNameList.SelectedValue + "'";

                cmd.CommandText = query;

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // userNameTbox.Text = reader.GetString(0);
                        //passwordTbox.Text = reader.GetString(2);
                        //lastNameTbox.Text = reader.GetString(3);
                        System.Diagnostics.Debug.WriteLine(reader.GetString(1));
                        System.Diagnostics.Debug.WriteLine(reader.GetString(1));
                        System.Diagnostics.Debug.WriteLine(reader.GetString(1));
                        System.Diagnostics.Debug.WriteLine(reader.GetString(2));

                        userNameTbox.Text = reader.GetString(1);
                        passwordTbox.Text = reader.GetString(2);
                        lastNameTbox.Text = reader.GetString(3);
                    }
                    conn.Close();
                }
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn
               = new SqlConnection("Server=localhost; Database=Assignment2; User Id=Roonechr; Password=123"))
            {
                conn.Open();
                string uName = userNameTbox.Text;
                string password = passwordTbox.Text;
                string lastName = lastNameTbox.Text;
                string selected = userNameList.SelectedValue;

                SqlCommand cmd = conn.CreateCommand();
                string query = "Update Users Set firstName='" + uName + "', Password='" + password + "', lastName='" + lastName + "' where firstName ='" + selected + "';";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                conn.Close();
            }


        }

        protected void deleteButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn
             = new SqlConnection("Server=localhost; Database=Assignment2; User Id=Roonechr; Password=123"))
            {
                conn.Open();
                string uName = userNameTbox.Text;
                string password = passwordTbox.Text;
                string lastName = lastNameTbox.Text;
                string selected = userNameList.SelectedValue;

                SqlCommand cmd = conn.CreateCommand();
                string query = "Delete from Users where firstName='"+selected+"'";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        protected void refreshButton_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}