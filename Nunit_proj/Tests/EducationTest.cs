
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Nunit_proj.Pages;
using Nunit_proj.TestModel;
using System.Text.Json;
using Nunit_proj.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;


namespace Nunit_proj.Tests
{
    [TestFixture]
    public class EducationTest : CommonDriver
    {


        EducationTab educationPageObj;

#pragma warning disable
        public EducationTest()
        {

            educationPageObj = new EducationTab();
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
        public void TestAddEducation()

        {

            
            Thread.Sleep(2000);


            //read test data from the json file
            List<EducationTestModel> AddEducationfile = JsonHelper.ReadTestDataFromJson<EducationTestModel>("C:\\Aug2024\\onboaring_proj\\Nunit_proj\\JSONFiles\\AddEducationfile.json");
            Console.WriteLine(AddEducationfile.ToString());
            foreach (var data in AddEducationfile)
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



                educationPageObj.AddEducation(University, Country, Title, Degree, Year);
               



            }





        }
        [Test, Order(2)]
        public void TestEditEducation()
        {
            
            TestAddEducation();
            //read test data from the json file
            List<EducationTestModel> editEducationTestData = JsonHelper.ReadTestDataFromJson<EducationTestModel>("C:\\Aug2024\\onboaring_proj\\Nunit_proj\\JSONFiles\\EditEducationfile.json");
            foreach (var data in editEducationTestData)
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
                educationPageObj.EditEducation(University, Country, Title, Degree, Year);
                



            }


        }
        [Test, Order(3)]
        public void TestDeleteEducation()
        {
            TestAddEducation();
            educationPageObj.DeleteEducation();

            //read test data from the json file
            List<EducationTestModel> deleteEducationTestData = JsonHelper.ReadTestDataFromJson<EducationTestModel>("C:\\Aug2024\\onboaring_proj\\Nunit_proj\\JSONFiles\\DeleteEducationfile.json");


        }


    }
}
