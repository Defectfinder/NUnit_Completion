using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nunit_proj.Utilities;
using Nunit_proj.Pages;
using Nunit_proj.TestModel;
using OpenQA.Selenium.BiDi.Modules.Script;
using System.Text.Json;

namespace Nunit_proj.Tests
{
    [TestFixture]
    public class CertificationTests : CommonDriver
    {
        CertificationTab certificationPageObj;

        public CertificationTests()
        {

            certificationPageObj = new CertificationTab();
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
        [Test,Order(1)]
        public void AddCertification()
        {
           

            string award = string.Empty;
            string crtfrom = string.Empty;
            string crtyear = string.Empty;

           


            List<CertificationTestModel> AddCertificationfile = JsonHelper.ReadTestDataFromJson<CertificationTestModel>("C:\\Aug2024\\onboaring_proj\\Nunit_proj\\JSONFiles\\TestCERT.json");


            foreach (var data in AddCertificationfile)
            {
                award = data.Certificate;
                Console.WriteLine(award);

                crtfrom = data.CertifiedFrom;
                Console.WriteLine(crtfrom);

                crtyear = data.Year;
                Console.WriteLine(crtyear);

                

            }


            CertificationTab certificationPageObj = new CertificationTab();
            certificationPageObj.AddCertification(award, crtfrom, crtyear);
        }
        
        [Test,Order(2)]
       
        public void EditCertification()
        {
            //certificationPageObj.EditCertification(string Certificate, string CertifiedFrom, string Year);

            Thread.Sleep(1000);
            AddCertification();

            //read test data from the json file
            List<CertificationTestModel> editCertificationTestData = JsonHelper.ReadTestDataFromJson<CertificationTestModel>("C:\\Aug2024\\onboaring_proj\\Nunit_proj\\JSONFiles\\EditCertificationfile.json");
            Console.WriteLine(editCertificationTestData.ToString());
            foreach (var data in editCertificationTestData)
            {
                string Certificate = data.Certificate;
                Console.WriteLine(Certificate);

                string CertifiedFrom = data.CertifiedFrom;
                Console.WriteLine(CertifiedFrom);

                string Year = data.Year;
                Console.WriteLine(Year);

                certificationPageObj.EditCertification(Certificate, CertifiedFrom, Year);
                string neweditCertificationfile = certificationPageObj.geteditCertificatefile();

                if (Certificate == neweditCertificationfile)
                {
                    Assert.That(Certificate, Is.EqualTo(neweditCertificationfile));
                }
                else
                {
                    Console.WriteLine("Check error");


                }

            }

        }

        [Test, Order(3)]
        public void DeleteCertification() 
        {
            Thread.Sleep(1000);
            CertificationTab certificationPageObj = new CertificationTab();
            certificationPageObj.DeleteCertification();
            List<CertificationTestModel> editCertificationTestData = JsonHelper.ReadTestDataFromJson<CertificationTestModel>("C:\\Aug2024\\onboaring_proj\\Nunit_proj\\JSONFiles\\DeleteCertificationfile.json");

        }

    }
}


