using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariam_SauceDemo
{
    public class CheckPrices : BasePage
    {
        public void Pricesmethod()
        {
            //By username = By.XPath("//div[contains(@class, 'inventory_item_price')]");
            var priceElement = driver.FindElement(By.XPath("//div[contains(@class, 'inventory_item_price')]"));
            string price = priceElement.Text;
            Console.WriteLine("The price of the product is: " + price);
        }
    }
}
