using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2_Roonechr_Prog37721
{
    public partial class Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            
            int geTicketsNum =System.Convert.ToInt32(geTickets.Text);
            int seniorTicketsNum = System.Convert.ToInt32(SeniorTickets.Text);
            int tsTicketsNum = System.Convert.ToInt32(tuesdaySpecialTickets.Text);

            string orderinfo = "You have purchased " + geTicketsNum + " general admission tickets at $15.00, " + seniorTicketsNum + " Senior Tickets at $5.00, and "
                + tsTicketsNum + " Tuesday Special tickets at $5.00 for the movie " + movieList.SelectedValue;

            double totalPrice = (geTicketsNum * 15 + seniorTicketsNum * 5 + tsTicketsNum * 5) * 1.13;

            Session["orderPrice"] = totalPrice;
            Session["orderInfo"] = orderinfo;

           // HttpContext currContext = HttpContext.Current;


             
            //currContext.Items.Add("userName",currContext.Items["userName"]);
            //currContext.Items.Add("order", orderinfo);
            //currContext.Items.Add("totalPrice", totalPrice);

            //Server.Transfer("OrderDetails.aspx");
           Response.Redirect("OrderDetails.aspx");

        }

        protected void returnButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
    }
