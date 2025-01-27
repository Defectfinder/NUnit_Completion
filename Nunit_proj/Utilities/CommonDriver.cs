using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using Nunit_proj.Pages;
using OpenQA.Selenium.Chrome;

namespace Nunit_proj.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        private ExtentTest test;
        public static ProfilePage profileHomePageObj;
        public void BrowserSetup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


        }
        [TearDown]
        public void TearDownActions()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
            {
                test.Log(Status.Pass, "Test Passed");
            }
            else
            {
                test.Log(Status.Fail, $"Test Failed: {TestContext.CurrentContext.Result.Message}");
            }
            
            Close();
        }
        public void CleanUp()
        {
            profileHomePageObj = new ProfilePage();
            profileHomePageObj.NavigateToEducationPanel();
            profileHomePageObj.ClearData();
            profileHomePageObj.NavigateToCerticationPanel();
            profileHomePageObj.ClearCertData();
        }
        public void ClearData()
        {
            try
            {
                var delEButton = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));
                foreach (var button in delEButton)
                {
                    Thread.Sleep(100);
                    button.Click();
                }
                Thread.Sleep(100);
            }

            catch (StaleElementReferenceException e)
            {
                var delButton = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));
                foreach (var button in delButton)
                {
                    Thread.Sleep(100);
                    button.Click();
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Nothing to delete");
            }
        }


        public void Close()
        {
            driver.Quit();
        }
    }

}
