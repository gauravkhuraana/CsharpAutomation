using NUnit.Framework;
using OnlineStore.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumExtras.PageObjects;

namespace OnlineStore.TestCases
{
    class LogInTest
    {
        [Test]
        public void test()
        {

         

            IWebDriver drv = new FirefoxDriver();

            drv.Url = "http://shop.demoqa.com/my-account";
            drv.Manage().Window.Maximize();
            var homepage = new HomePage(drv);

            homepage.loginApp();
            homepage.logoutApp();

             /* Direct way of calling 
             drv.FindElement(By.Id("username")).SendKeys("hello4");
             drv.FindElement(By.Id("password")).SendKeys("hello4@gmail.com");
             drv.FindElement(By.XPath("//*[@name='login']")).Click();
             drv.FindElement(By.XPath("//a[text()='Logout']")).Click();
             */

            drv.Quit();
        }

    }
}
