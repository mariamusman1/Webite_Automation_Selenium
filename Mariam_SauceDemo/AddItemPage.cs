using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariam_SauceDemo
{
    public class AddItemPage : BasePage
    {
        By item1 = By.Id("add-to-cart-sauce-labs-backpack");
        By item2 = By.Id("add-to-cart-sauce-labs-bike-light");
        By item3 = By.Id("add-to-cart-sauce-labs-bolt-t-shirt");
        By cart = By.Id("shopping_cart_container");
        public void AddCart()
        {

            Click(item1);
            Click(item2);
            Click(item3);
            Click(cart);

        }
    }
}
