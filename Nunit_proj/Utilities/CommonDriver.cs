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

namespace Nunit_proj.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        private ExtentTest test;
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
        
        public void Close()
        {
            driver.Quit();
        }
    }

}
