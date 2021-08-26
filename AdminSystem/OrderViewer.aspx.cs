using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AOrder = new clsOrder();
        AOrder = (clsOrder)Session["AOrder"];
        Response.Write("OrderID: " + AOrder.OrderID + "<br/>");
        Response.Write("CustomerNo: " + AOrder.CustomerNo + "<br/>");
        Response.Write("Address: " + AOrder.Address + "<br/>");
        Response.Write("ShirtColour: " + AOrder.ShirtColour + "<br/>");
        Response.Write("Price: " + AOrder.Price + "<br/>");
        Response.Write("Date: " + AOrder.Date + "<br/>");
        Response.Write("TeamName: " + AOrder.TeamName + "<br/>");
        Response.Write("StaffID: " + AOrder.StaffID + "<br/>");
    }
}