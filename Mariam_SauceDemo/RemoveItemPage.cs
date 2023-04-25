using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariam_SauceDemo
{
    public class RemoveItemPage : BasePage
    {
        
        By itemRemove = By.Id("remove-sauce-labs-bolt-t-shirt");

        
        public void RemoveCart()
        {

           
            Click(itemRemove);
            

        }
    }
}
