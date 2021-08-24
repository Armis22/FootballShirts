using System;


namespace ClassLibrary
{
    public class clsOrder
    {
        private Int32 mOrderID;
        private Int32 mStaffID;
        private int mCustomerNo;
        private string mAddress;
        private DateTime mDate;
        private decimal mPrice;
        private string mShirtColour;
        private bool mAvailability;
        private string mTeamName;








        public Int32 OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }


        }


        public Int32 StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }


        }






        public Int32 CustomerNo
        {
            get
            {
                return mCustomerNo;
            }
            set
            {
                mCustomerNo = value;
            }


        }


        public string TeamName
        {
            get
            {
                return mTeamName;
            }
            set
            {
                mTeamName = value;
            }


        }


        public DateTime Date
        {
            get
            {
                return mDate;
            }
            set
            {
                mDate = value;
            }


        }


        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }


        }


        public decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }


        }






        public string ShirtColour
        {
            get
            {
                return mShirtColour;
            }
            set
            {
                mShirtColour = value;
            }


        }


        public bool Availability
        {
            get
            {
                return mAvailability;
            }
            set
            {
                mAvailability = value;
            }


        }


        public bool Find(int OrderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", OrderID);
            DB.Execute("sproc_tblOrder_FilterByOrderID");


            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mTeamName = Convert.ToString(DB.DataTable.Rows[0]["TeamName"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                mShirtColour = Convert.ToString(DB.DataTable.Rows[0]["ShirtColour"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                return true;
            }
            else
            {
                return false;
            }
        }




        public string Valid(string orderID, string customerNo, string Address, string Date, string Price, string ShirtColour, string TeamName, string staffID)
        {
            String Error = "";
            DateTime DateTemp;
            int CustomerNoTemp;
            Decimal PriceTemp;
            int orderIDTemp;
            int StaffIDTemp;


            if (TeamName.Length < 1)
            {
                Error = Error + "Team Name cannot be blank: ";
            }
            if (TeamName.Length > 20)
            {
                Error = Error + "Team Name cannot exceed 20 chars: ";
            }
            if (Address.Length < 1)
            {
                Error = Error + " Address cannot be blank: ";
            }
            if (Address.Length > 30)
            {
                Error = Error + " Address cannot exceed 30 chars:";
            }
            if (ShirtColour.Length < 3)
            {
                Error = Error + " Colour cannot be less than 3 chars as the shortest colour name is red: ";
            }
            if (ShirtColour.Length > 10)
            {
                Error = Error + " Colour cannot exceed 10 chars:";
            }
            try
            {
                DateTemp = Convert.ToDateTime(Date);
                if (DateTemp <= DateTime.Now.AddYears(-1).AddDays(-1))
                {
                    Error = Error + "Orders older than 1 years cannot be proccessed: ";
                }
                if (DateTemp > DateTime.Now)
                {
                    Error = Error + "Orders cannot be in the future: ";
                }
            }
            catch
            {
                Error = Error + "Invalid data for date: ";
            }
            try
            {
                CustomerNoTemp = Convert.ToInt32(customerNo);
                if (CustomerNoTemp < 1)
                {
                    Error = Error + "Customer Number cannot be 0: ";
                }
                if (CustomerNoTemp > 2000)
                {
                    Error = Error + "Customer Number cannot be more than 2000: ";
                }
            }
            catch
            {
                Error = Error + "Invalid data for Customer Number: ";
            }


            try
            {
                PriceTemp = Convert.ToDecimal(Price);
                if (PriceTemp < 1)
                {
                    Error = Error + " Price cannot be less than 1: ";
                }
                if (PriceTemp > decimal.MaxValue)
                {
                    Error = Error + "Price cannot exceed decimal max value: ";
                }
            }
            catch
            {
                Error = Error + "Invalid data for Price: ";
            }


            try
            {
                orderIDTemp = Convert.ToInt32(orderID);
                if (orderIDTemp < 1)
                {
                    Error = Error + "Order ID cannot be less than 1: ";
                }
                if (orderIDTemp > 200)
                {
                    Error = Error + "Order ID cannot exceed number 200: ";
                }
            }
            catch
            {
                Error = Error + "Invalid data for Order ID:";
            }


            try
            {
                StaffIDTemp = Convert.ToInt32(staffID);
                if (StaffIDTemp < 1)
                {
                    Error = Error + "Staff ID cannot be less than 1: ";
                }
                if (StaffIDTemp > 50)
                {
                    Error = Error + "Staff ID cannot exceed 50: ";
                }
            }
            catch
            {
                Error = Error + "Invalid data for Staff ID:";
            }




            return Error;
        }
    }
}

