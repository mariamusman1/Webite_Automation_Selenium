using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariam_SauceDemo
{
    public class Filteration : BasePage
    {
      
        public void Filtermethod()
        {

            var element = driver.FindElement(By.ClassName("product_sort_container"));
            var filter = new SelectElement(element);
            filter.SelectByValue("az");
        }
    }
}
