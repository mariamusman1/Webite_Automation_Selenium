using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariam_SauceDemo
{
    public class CheckoutPage :  BasePage
    {
        By checkout = By.Id("checkout");
        By firstname = By.Id("first-name");
        By lastname = By.Id("last-name");
        By postalcode = By.Id("postal-code");
        By continuebtn = By.Id("continue");
        By finishbtn = By.Id("finish");

        public void Checkout(string fname, string lname, string code)
        {
            Click(checkout);
            Write(firstname, fname);
            Write(lastname, lname);
            Write(postalcode, code);
            Click(continuebtn);
            Click(finishbtn);
        }
        
    }
}
