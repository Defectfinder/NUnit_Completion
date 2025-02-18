using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Nunit_proj.TestModel;
using Nunit_proj.Pages;
using System.Text.Json;
using Nunit_proj.Utilities;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace Nunit_proj.Tests
{
    public class CertificationNegativeTest : CommonDriver
    {


        CertificationNegativepage NegativecertificationPageObj;
#pragma warning disable
        public CertificationNegativeTest()
        {

            NegativecertificationPageObj = new CertificationNegativepage();
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
        public void TestAddCertification()
        {
            NegativecertificationPageObj.CertificationTabClick();
          

            //read test data from the json file
            List<CertificationTestModel> addNegativeTestData = JsonHelper.ReadTestDataFromJson<CertificationTestModel>("C:\\Aug2024\\onboaring_proj\\Nunit_proj\\JSONFiles\\AddCertificationNegativefile.json");
            Console.WriteLine(addNegativeTestData.ToString());
            foreach (var data in addNegativeTestData)
            {
                string Certificate = data.Certificate;
                Console.WriteLine(Certificate);

                string CertifiedFrom = data.CertifiedFrom;
                Console.WriteLine(CertifiedFrom);

                string Year = data.Year;
                Console.WriteLine(Year);
                NegativecertificationPageObj.AddInvalidCertification(Certificate, CertifiedFrom, Year);




                

            }




        }
        [Test, Order(2)]
        public void TestEditCertification()
        {
            NegativecertificationPageObj.CertificationTabClick();
            Thread.Sleep(1000);

            
            //read test data from the json file
            List<CertificationTestModel> EditCertificationNegative = JsonHelper.ReadTestDataFromJson<CertificationTestModel>("C:\\Aug2024\\onboaring_proj\\Nunit_proj\\JSONFiles\\EditCertificationNegativefile.json");
            Console.WriteLine(EditCertificationNegative.ToString());
            foreach (var data in EditCertificationNegative)
            {
                string Certificate = data.Certificate;
                Console.WriteLine(Certificate);

                string CertifiedFrom = data.CertifiedFrom;
                Console.WriteLine(CertifiedFrom);

                string Year = data.Year;
                Console.WriteLine(Year);

                NegativecertificationPageObj.EditCertification(Certificate, CertifiedFrom, Year);
                


            }

        }
    }

}
