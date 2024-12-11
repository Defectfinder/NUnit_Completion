using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nunit_proj.Pages;
using Nunit_proj.Utilities;

namespace Nunit_proj.Tests
{
    [TestFixture]
    public class LoginTest : CommonDriver
    {
        [SetUp]
        public void SetUpSteps()
        {

            driver = new ChromeDriver();

            // Login page object initialization and definition
            Login loginPageObj = new Login();
            loginPageObj.LoginActions(driver);

            // Profile page object intialization and definition
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.NavigateToProfile(driver);
        }
        [Test]
       public void AddEducation_Test() 
        {
            EducationTab educationPageObj = new EducationTab();
            educationPageObj.AddEducation(driver);




        }
        
       
    }
}
