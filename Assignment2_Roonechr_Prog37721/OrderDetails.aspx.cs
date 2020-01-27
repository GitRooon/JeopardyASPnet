using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2_Roonechr_Prog37721
{
    public partial class OrderDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpContext currContext = HttpContext.Current;

            //string userName =currContext.Items["userName"].ToString();

            // userLabel.Text = currContext.Items["userName"].ToString();

            
            orderdetailsLabel.Text = Session["orderInfo"].ToString();
            orderTotalabel.Text ="$"+ Session["orderPrice"].ToString();

            double memPrice = Convert.ToDouble(Session["orderPrice"]) * 0.8;

            if (Convert.ToBoolean(Session["validUser"])) 
            {
                userLabel.Text = Session["userName"].ToString();
                memberPriceLabel.Text = "Because you're a member you save 20% new price: $" + memPrice;
            }
        }
    }
}