using Mariam_SauceDemo;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariam_SauceDemo
{
    public class LoginPage : BasePage
    {
        By username = By.Id("user-name");
        By password = By.Id("password");
        By loginbtn = By.Id("login-button");

        public void Login(string url, string user, string pass)
        {
            driver.Url = url;
            Write(username, user);
            Write(password, pass);
            Click(loginbtn);
        }

    }
}
