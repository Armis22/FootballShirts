using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Testing3
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        string TeamName = "Roma";
        string CustomerNo = "36";
        string Date = DateTime.Now.Date.ToString();
        string ShirtColour = "red";
        string Address = "45  Street";
        string Price = "20";
        string OrderID = "99";
        string StaffID = "13";




        [TestMethod]
        public void TeamNameOK()
        {
            clsOrder AOrder = new clsOrder();
            string TestData = "Random";
            AOrder.TeamName = TestData;
            Assert.AreEqual(AOrder.TeamName, TestData);
        }


        [TestMethod]


        public void AvailabilityOK()


        {
            clsOrder AOrder = new clsOrder();
            Boolean TestData = true;
            AOrder.Availability = TestData;
            Assert.AreEqual(AOrder.Availability, TestData);
        }


        [TestMethod]


        public void DateOK()


        {
            clsOrder AOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AOrder.Date = TestData;
            Assert.AreEqual(AOrder.Date, TestData);
        }


        [TestMethod]


        public void AddressOK()


        {
            clsOrder AOrder = new clsOrder();
            String TestData = "Delivery Address";
            AOrder.Address = TestData;
            Assert.AreEqual(AOrder.Address, TestData);
        }


        [TestMethod]


        public void CustomerNoOK()


        {
            clsOrder AOrder = new clsOrder();
            int TestData = 121;
            AOrder.CustomerNo = TestData;
            Assert.AreEqual(AOrder.CustomerNo, TestData);
        }


        [TestMethod]


        public void OrderIdOK()


        {
            clsOrder AOrder = new clsOrder();
            int TestData = 134;
            AOrder.OrderID = TestData;
            Assert.AreEqual(AOrder.OrderID, TestData);
        }


        [TestMethod]


        public void StaffIdOK()


        {
            clsOrder AOrder = new clsOrder();
            int TestData = 14;
            AOrder.StaffID = TestData;
            Assert.AreEqual(AOrder.StaffID, TestData);
        }




        [TestMethod]


        public void PriceOk()


        {
            clsOrder AOrder = new clsOrder();
            decimal TestData = 35;
            AOrder.Price = TestData;
            Assert.AreEqual(AOrder.Price, TestData);
        }


        [TestMethod]
        public void ShirtColourOk()
        {
            clsOrder AOrder = new clsOrder();
            string TestData = "blue";
            AOrder.ShirtColour = TestData;
            Assert.AreEqual(AOrder.ShirtColour, TestData);


        }




        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }




        [TestMethod]
        public void TeamNameMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string TeamName = "";
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void TeamNameMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string TeamName = "a";
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void TeamNameMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string TeamName = "";
            TeamName = TeamName.PadRight(10, 'a');
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void TeamNameMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string TeamName = "";
            TeamName = TeamName.PadRight(20, 'a');
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void TeamNameMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string TeamName = "";
            TeamName = TeamName.PadRight(21, 'a');
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }




        [TestMethod]
        public void TeamNameExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string TeamName = "";
            TeamName = TeamName.PadRight(201, 'a');
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void AddressMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string Address = "";
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void AddressMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string Address = "a";
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void AddressMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string Address = "";
            Address = Address.PadRight(15, 'a');
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void AddressMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string Address = "";
            Address = Address.PadRight(30, 'a');
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string Address = "";
            Address = Address.PadRight(31, 'a');
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }




        [TestMethod]
        public void AddressExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string Address = "";
            Address = Address.PadRight(301, 'a');
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }




        [TestMethod]
        public void ShirtColourMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ShirtColour = "aa";
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void ShirtColourMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ShirtColour = "red";
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void ShirtColourMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ShirtColour = "";
            ShirtColour = ShirtColour.PadRight(5, 'a');
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void ShirtColourMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ShirtColour = "";
            ShirtColour = ShirtColour.PadRight(10, 'a');
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void ShirtColourMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ShirtColour = "";
            ShirtColour = ShirtColour.PadRight(11, 'a');
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }




        [TestMethod]
        public void ShirtColourExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string ShirtColour = "";
            ShirtColour = ShirtColour.PadRight(101, 'a');
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void DateExtremeMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-10);
            string Date = TestDate.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void DateMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1).AddDays(-1);
            string Date = TestDate.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void DateMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string Date = TestDate.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void DateMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddMonths(-6);
            string Date = TestDate.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void DateMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string Date = TestDate.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void DateMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string Date = TestDate.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void DateExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string Date = TestDate.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void DateInvalidData()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string Date = "Not valid date";
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void CustomerNoExtremeMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = -1000;
            string CustomerNo = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void CustomerNoMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 0;
            string CustomerNo = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void CustomerNoMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 1;
            string CustomerNo = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void CustomerNoMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 1000;
            string CustomerNo = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void CustomerNoMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 2000;
            string CustomerNo = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void CustomerNoMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 2001;
            string CustomerNo = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");




        }


        [TestMethod]
        public void CustomerNoExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 200001;
            string CustomerNo = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");




        }


        [TestMethod]
        public void CustomerNoInvalidData()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string CustomerNo = "Not valid data";
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void PriceExtremeMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Decimal TestData;
            TestData = -1000;
            string Price = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void PriceMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Decimal TestData;
            TestData = 0;
            string Price = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void PriceMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Decimal TestData;
            TestData = 1;
            string Price = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void PriceMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Decimal TestData;
            TestData = decimal.MaxValue / 2;
            string Price = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void PriceMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Decimal TestData;
            TestData = decimal.MaxValue;
            string Price = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }




        [TestMethod]
        public void PriceInvalidData()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string Price = "Not valid data";
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderIdExtremeMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int TestData;
            TestData = -1000;
            string OrderID = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void OrderIdMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 0;
            string OrderID = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void OrderIdMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 1;
            string OrderID = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void OrderIdMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 100;
            string OrderID = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void OrderIdMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 200;
            string OrderID = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void OrderIdMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 201;
            string OrderID = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }




        [TestMethod]
        public void OrderIdInvalidData()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string OrderID = "Not valid data";
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");
        }






        [TestMethod]
        public void StaffIdExtremeMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            int TestData;
            TestData = -1000;
            string StaffID = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void StaffIdMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 0;
            string StaffID = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void StaffIdMin()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 1;
            string StaffID = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void StaffIdMid()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 25;
            string StaffID = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void StaffIdMax()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 50;
            string StaffID = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreEqual(Error, "");


        }


        [TestMethod]
        public void StaffIdMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            Int32 TestData;
            TestData = 51;
            string StaffID = TestData.ToString();
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");


        }




        [TestMethod]
        public void StaffIdInvalidData()
        {
            clsOrder AOrder = new clsOrder();
            string Error = "";
            string StaffID = "Not valid data";
            Error = AOrder.Valid(OrderID, CustomerNo, Address, Date, Price, ShirtColour, TeamName, StaffID);
            Assert.AreNotEqual(Error, "");
        }






        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            int OrderID = 1;
            Found = AOrder.Find(OrderID);
            Assert.IsTrue(Found);
        }


        [TestMethod]
        public void TestOrderIdFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            int OrderID = 1;
            Found = AOrder.Find(OrderID);
            if (AOrder.OrderID != 1)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void TestCustomerNoFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            int OrderID = 1;
            Found = AOrder.Find(OrderID);
            if (AOrder.CustomerNo != 23)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }




        [TestMethod]
        public void TestDateFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            int OrderID = 1;
            Found = AOrder.Find(OrderID);
            if (AOrder.Date != Convert.ToDateTime("18/07/2021"))
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void TestAvailabilityFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            int OrderID = 1;
            Found = AOrder.Find(OrderID);
            if (AOrder.Availability != true)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void TestAddressFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            int OrderID = 1;
            Found = AOrder.Find(OrderID);
            if (AOrder.Address != "le12pq")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void TestShirtColourFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            int OrderID = 1;
            Found = AOrder.Find(OrderID);
            if (AOrder.ShirtColour != "Red")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }


        [TestMethod]
        public void TestPriceFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            int OrderID = 1;
            Found = AOrder.Find(OrderID);
            if (AOrder.Price != 55)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }




        [TestMethod]
        public void TestTeamNameFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean Ok = true;
            int OrderID = 1;
            Found = AOrder.Find(OrderID);
            if (AOrder.TeamName != "Roma")
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }
    }
}

