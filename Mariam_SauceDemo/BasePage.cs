using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using Mariam_SauceDemo;

namespace Mariam_SauceDemo
{
    public class BasePage : ExtentReport
    {


        static public void SeleniumInitilization(string browser)
        {
            driver = new ChromeDriver();

        }
        static public void Maximize()
        {
            driver.Manage().Window.Maximize();
        }

        static public void SeleniumClose()
        {
            driver.Close();
        }

        static public void Write(By by, string text)
        {
            try
            {
                driver.FindElement(by).SendKeys(text);
                TakeScreenshot(Status.Pass, "Enter ");
            }

            catch (Exception ex)
            {
                TakeScreenshot(Status.Fail, "Enter Failed" + ex);
            }
        }

        static public void Click(By by)
        {
            try
            {
                driver.FindElement(by).Click();
                TakeScreenshot(Status.Pass, "Click");
            }
            catch (Exception ex)
            {
                TakeScreenshot(Status.Fail, "Click Failed " + ex);
            }

        }

        public void Clear(By by)
        {
            driver.FindElement(by).Clear();
        }

    }
}
