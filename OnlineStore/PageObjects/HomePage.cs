using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;


namespace OnlineStore.PageObjects
{
    public class HomePage
    {

        private IWebDriver drv;
        [FindsBy(How=How.Id, Using ="username")][CacheLookup]
        private IWebElement UserName { get; set; }


        [FindsBy(How=How.Id,Using ="password")][CacheLookup]
        private IWebElement password { get; set; }


        [FindsBy(How=How.XPath,Using= "//*[@name='login']")][CacheLookup]
        private IWebElement login { get; set; }
     //   [FindBy(How = How., Using = "your_xpath_here")] public IWebElement contactBox { get; set; }


        [FindsBy(How = How.XPath, Using = "//a[text()='Logout']")]
        private IWebElement logout { get; set; }

        public HomePage(IWebDriver drv)
        {
            this.drv=drv;
            PageFactory.InitElements(drv, this);
        }

        public void loginApp()
        {
            UserName.SendKeys("hello4");
            password.SendKeys("hello4@gmail.com");
            login.Click();
        }

        public void logoutApp()
        {
            logout.Click();

        }
    }

}
