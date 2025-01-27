using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nunit_proj.Utilities;

namespace Nunit_proj.Pages
{
    public class ProfilePage : CommonDriver

    {
        private static IWebElement educationTab => driver.FindElement(By.XPath("//a[text()='Education']"));
        private static IWebElement certificationTab => driver.FindElement(By.XPath("//a[text()='Certifications']"));

        public void NavigateToProfile(IWebDriver driver)
        {
            // Navigate to Profile tab

            IWebElement profileTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
            profileTab.Click();
        }
        public void NavigateToEducationPanel()
        {
            
            educationTab.Click();
            Thread.Sleep(3000);
        }
        public void NavigateToCerticationPanel()
        {
           
            certificationTab.Click();
            Thread.Sleep(3000);
        }
        public void ClearCertData()
        {
            try
            {
                var delButton = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));
                foreach (var button in delButton)
                {
                    Thread.Sleep(100);
                    button.Click();
                }
                Thread.Sleep(100);
            }

            catch (StaleElementReferenceException e)
            {
                var delButton = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[2]/i"));
                foreach (var button1 in delButton)
                {
                    Thread.Sleep(100);
                    button1.Click();
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Nothing to delete");
            }
        }
    }
}
