using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_proj.Pages
{
    public class ProfilePage
    {
        public void NavigateToProfile(IWebDriver driver)
        {
            // Navigate to Profile tab

            IWebElement profileTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
            profileTab.Click();
        }
    }
}
