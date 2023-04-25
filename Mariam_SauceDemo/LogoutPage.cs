using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariam_SauceDemo
{
    public class LogoutPage : BasePage
    {
        By menubar = By.Id("react-burger-menu-btn");
        By logout = By.Id("logout_sidebar_link");
        public void Logout()
        {
            Click(menubar);
            Click(logout);


        }
    }
}
