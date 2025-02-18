using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Nunit_proj.Utilities;
using Nunit_proj.Pages;
using OpenQA.Selenium.Chrome;
using Nunit_proj.TestModel;
using OpenQA.Selenium;

namespace Nunit_proj.Tests
{

    [TestFixture]
    public class EducationInvalidTest : CommonDriver
    {
        EducationNegativeTab educNegPageObj;
        
        public EducationInvalidTest() 
        {
            educNegPageObj = new EducationNegativeTab();
        }
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
        [Test, Order(1)]
        public void AddInvalidEducation()
        {
            //read test data from the json file
            List<EducationTestModel> AddEducationNegative = JsonHelper.ReadTestDataFromJson<EducationTestModel>("C:\\Aug2024\\onboaring_proj\\Nunit_proj\\JSONFiles\\AddEducationNegative.json");
            Console.WriteLine(AddEducationNegative.ToString());
            foreach (var data in AddEducationNegative)
            {
                string University = data.University;
                Console.WriteLine(University);

                string Country = data.Country;
                Console.WriteLine(Country);

                string Title = data.Title;
                Console.WriteLine(Title);

                string Degree = data.Degree;
                Console.WriteLine(Degree);

                string Year = data.Year;
                Console.WriteLine(Year);
                educNegPageObj.AddNegativeEducation(University, Country, Title, Degree, Year);
                
                

            }
        }
        [Test, Order(2)]
        public void EditInvalidEducation()
        {
            List<EducationTestModel> EditEduNegative = JsonHelper.ReadTestDataFromJson<EducationTestModel>("C:\\Aug2024\\onboaring_proj\\Nunit_proj\\JSONFiles\\EditEducationNegativefile.json");
            Console.WriteLine(EditEduNegative.ToString());
            foreach (var data in EditEduNegative)
            {
                string University = data.University;
                Console.WriteLine(University);

                string Country = data.Country;
                Console.WriteLine(Country);

                string Title = data.Title;
                Console.WriteLine(Title);

                string Degree = data.Degree;
                Console.WriteLine(Degree);

                string Year = data.Year;
                Console.WriteLine(Year);
                educNegPageObj.EditNegEducation(University, Country, Title, Degree, Year);
            }
        }

    }
}
