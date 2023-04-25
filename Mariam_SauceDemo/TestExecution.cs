using Mariam_SauceDemo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariam_SauceDemo
{
    [TestClass]
    public class TestExecution : ExtentReport
    {

        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
            LogReport("TestReport");
        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
            extentReports.Flush();
        }

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {

        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {

        }

        [TestInitialize]
        public void TestInitialization()
        {   // Add Method into Report (test context sy jo current test execute horaha hota ha oskae method ka naam pata chal jata ha)
            exParentTest = extentReports.CreateTest(TestContext.TestName);// ak extent report crate kar rahy hain or osmae method ka naam bhjdiya ha

            BasePage.SeleniumInitilization("Chrome");
            BasePage.Maximize();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            BasePage.SeleniumClose();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.XML", "valid_LoginTC", DataAccessMethod.Sequential)]
        public void valid_LoginTC()
        {
            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();

            // Add Login Step inside Test Method
            exChildTest = ExtentReport.exParentTest.CreateNode("Login");

            LoginPage loginPage = new LoginPage();
            loginPage.Login(url, user, pass);

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.XML", "FilterationTC", DataAccessMethod.Sequential)]
        public void FilterationTC()
        {
            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();

            // Add Login Step inside Test Method
            exChildTest = ExtentReport.exParentTest.CreateNode("Login");

            LoginPage loginPage = new LoginPage();
            loginPage.Login(url, user, pass);
            
            exChildTest = ExtentReport.exParentTest.CreateNode("Filteration");
            Filteration filteration = new Filteration();
            filteration.Filtermethod();

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.XML", "invalid_LoginTC", DataAccessMethod.Sequential)]
        public void invalid_LoginTC()
        {
            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();

            // Add Login Step inside Test Method
            exChildTest = ExtentReport.exParentTest.CreateNode("invalid_Login");

            LoginPage loginPage = new LoginPage();
            loginPage.Login(url, user, pass);

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.XML", "AddCartTC", DataAccessMethod.Sequential)]
        public void AddCartTC()
        {
            #region Initialization
            LoginPage loginPage = new LoginPage();
            AddItemPage cartpage = new AddItemPage();
            #endregion

            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            

            #region Scenario/Steps

            
            exChildTest = ExtentReport.exParentTest.CreateNode("Login");
            loginPage.Login(url, user, pass);

            
            exChildTest = ExtentReport.exParentTest.CreateNode("AddCartTC");
            cartpage.AddCart();

            #endregion
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.XML", "RemoveCartTC", DataAccessMethod.Sequential)]
        public void RemoveCartTC()
        {
            #region Initialization
            LoginPage loginPage = new LoginPage();
            AddItemPage additem = new AddItemPage();
            RemoveItemPage removeitem = new RemoveItemPage();
            #endregion

            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();


            #region Scenario/Steps


            exChildTest = ExtentReport.exParentTest.CreateNode("Login");
            loginPage.Login(url, user, pass);

            exChildTest = ExtentReport.exParentTest.CreateNode("Add Item");
            additem.AddCart();

            exChildTest = ExtentReport.exParentTest.CreateNode("Remove Item");
            removeitem.RemoveCart();

            #endregion
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.XML", "CheckOutTC", DataAccessMethod.Sequential)]
        public void CheckOutTC()
        {
            #region Initialization
            LoginPage loginPage = new LoginPage();
            AddItemPage additemPage = new AddItemPage();
            RemoveItemPage removeitemPage = new RemoveItemPage();
            CheckoutPage checkoutPage = new CheckoutPage();
            #endregion

            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();
            string fname = TestContext.DataRow["firstname"].ToString();
            string lname = TestContext.DataRow["lastname"].ToString();
            string code = TestContext.DataRow["postalcode"].ToString();


            #region Scenario/Steps


            exChildTest = ExtentReport.exParentTest.CreateNode("Login");
            loginPage.Login(url, user, pass);

            exChildTest = ExtentReport.exParentTest.CreateNode("Add Item");
            additemPage.AddCart();

            exChildTest = ExtentReport.exParentTest.CreateNode("Remove Item");
            removeitemPage.RemoveCart();

            exChildTest = ExtentReport.exParentTest.CreateNode("Checkout");
            checkoutPage.Checkout(fname,lname,code);

            #endregion
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.XML", "CheckPriceTC", DataAccessMethod.Sequential)]
        public void CheckPriceTC()
        {
            #region Initialization
            LoginPage loginPage = new LoginPage();
            AddItemPage additem = new AddItemPage();
            RemoveItemPage removeitem = new RemoveItemPage();
            CheckPrices checkPrices = new CheckPrices();

            #endregion

            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();


            #region Scenario/Steps


            exChildTest = ExtentReport.exParentTest.CreateNode("Login");
            loginPage.Login(url, user, pass);

            exChildTest = ExtentReport.exParentTest.CreateNode("Add Item");
            additem.AddCart();

            exChildTest = ExtentReport.exParentTest.CreateNode("Remove Item");
            removeitem.RemoveCart();

            exChildTest = ExtentReport.exParentTest.CreateNode("Check Prices");
            checkPrices.Pricesmethod();

            #endregion
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.XML", "logoutTC", DataAccessMethod.Sequential)]
        public void logoutTC()
        {
            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();

            // Add Login Step inside Test Method
            exChildTest = ExtentReport.exParentTest.CreateNode("Login");

            LoginPage loginPage = new LoginPage();
            loginPage.Login(url, user, pass);
            exChildTest = ExtentReport.exParentTest.CreateNode("Logout");

            LogoutPage logoutPage = new LogoutPage();
            logoutPage.Logout();



        }


    }
}
