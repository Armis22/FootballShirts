using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            if (OrderID != -1)
            {
                DisplayOrder();
            }
        }
    }

    private void DisplayOrder()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(OrderID);
        //display data for the record
        txtOrderID.Text = OrderBook.ThisOrder.OrderID.ToString();
        txtCustomerNo.Text = OrderBook.ThisOrder.CustomerNo.ToString();
        txtAddress.Text = OrderBook.ThisOrder.Address;
        txtShirtColour.Text = OrderBook.ThisOrder.ShirtColour;
        txtPrice.Text = OrderBook.ThisOrder.Price.ToString();
        txtDate.Text = OrderBook.ThisOrder.Date.ToString();
        txtTeamName.Text = OrderBook.ThisOrder.TeamName;
        txtStaffID.Text = OrderBook.ThisOrder.StaffID.ToString();
        chkAvailability.Checked = OrderBook.ThisOrder.Availability;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AOrder = new clsOrder();
        string OrderID = txtOrderID.Text;
        string CustomerNo = txtCustomerNo.Text;
        string Address = txtAddress.Text;
        string ShirtColour = txtShirtColour.Text;
        string Price = txtPrice.Text;
        string Date = txtDate.Text;
        string TeamName = txtTeamName.Text;
        string StaffID = txtStaffID.Text;
        string Error = "";

        Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);

        if (Error == "")

        {
            AOrder.OrderID = Convert.ToInt32(OrderID);
            AOrder.CustomerNo = Convert.ToInt32(CustomerNo);
            AOrder.Address = txtAddress.Text;
            AOrder.ShirtColour = txtShirtColour.Text;
            AOrder.Price = Convert.ToDecimal(Price);
            AOrder.Date = Convert.ToDateTime(Date);
            AOrder.TeamName = txtTeamName.Text;
            AOrder.Availability = chkAvailability.Checked;
            AOrder.StaffID = Convert.ToInt32(StaffID);
            clsOrderCollection OrderList = new clsOrderCollection();
            if (this.OrderID == -1)
            {
                OrderList.ThisOrder = AOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(Convert.ToInt32(OrderID));
                OrderList.ThisOrder = AOrder;
                OrderList.Update();

            }
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AOrder = new clsOrder();
        Int32 OrderID;
        Boolean Found = false;
        OrderID = Convert.ToInt32(txtOrderID.Text);
        Found = AOrder.Find(OrderID);
        if (Found == true)
        {
            txtOrderID.Text = AOrder.OrderID.ToString();
            txtCustomerNo.Text = AOrder.CustomerNo.ToString();
            txtAddress.Text = AOrder.Address;
            txtShirtColour.Text = AOrder.ShirtColour;
            txtPrice.Text = AOrder.Price.ToString();
            txtDate.Text = AOrder.Date.ToString();
            txtTeamName.Text = AOrder.TeamName;
            txtStaffID.Text = AOrder.StaffID.ToString();
            chkAvailability.Checked = AOrder.Availability;



        }


    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}