using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();




        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;


            }
        }


        public clsOrderCollection()
        {
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }




        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                //later
            }
        }










        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }



        }


        public void FilterByAddress(string Address)
        {
            //Filters the records based on a full or partial Address
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the OrderID parameter to the database
            DB.AddParameter("@Address", Address);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByAddress");
            //populate the array list with the data table
            PopulateArray(DB);
        }




        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                clsOrder AOrder = new clsOrder();
                AOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AOrder.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AOrder.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AOrder.ShirtColour = Convert.ToString(DB.DataTable.Rows[Index]["ShirtColour"]);
                AOrder.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AOrder.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                AOrder.TeamName = Convert.ToString(DB.DataTable.Rows[Index]["TeamName"]);
                AOrder.Availability = true;
                mOrderList.Add(AOrder);
                Index++;
            }
        }


        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisOrder.StaffID);
            DB.AddParameter("@CustomerNo", mThisOrder.CustomerNo);
            DB.AddParameter("@Address", mThisOrder.Address);
            DB.AddParameter("@ShirtColour", mThisOrder.ShirtColour);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@Availability", mThisOrder.Availability);
            DB.AddParameter("@TeamName", mThisOrder.TeamName);
            DB.AddParameter("@Date", mThisOrder.Date);
            return DB.Execute("sproc_tblOrder_Insert");
        }


        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@StaffID", mThisOrder.StaffID);
            DB.AddParameter("@CustomerNo", mThisOrder.CustomerNo);
            DB.AddParameter("@Address", mThisOrder.Address);
            DB.AddParameter("@ShirtColour", mThisOrder.ShirtColour);
            DB.AddParameter("@Price", mThisOrder.Price);
            DB.AddParameter("@Availability", mThisOrder.Availability);
            DB.AddParameter("@TeamName", mThisOrder.TeamName);
            DB.AddParameter("@Date", mThisOrder.Date);
            DB.Execute("sproc_tblOrder_Update");
        }


        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.Execute("sproc_tblOrder_Delete");
        }
    }


}

