using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Nunit_proj.Pages;

namespace Nunit_proj.Utilities
{
    
    public class Hooks : CommonDriver
    {

        [SetUp]
        public void Setup()
        {
            BrowserSetup();
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
