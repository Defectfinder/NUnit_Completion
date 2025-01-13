using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nunit_proj.Utilities;
using Newtonsoft.Json;

namespace Nunit_proj.Pages
{
    public class CertificationTab : CommonDriver
    {
        private static IWebElement certificationTabSelect => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
        private static IWebElement cerAddButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private static IWebElement addCertificationTitle => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
        private static IWebElement addFrom => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
        private static IWebElement selectYear => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
        private static IWebElement addCertification => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));

        private static IWebElement neweditCertificationfile => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
        private static IWebElement cerEditIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[2]/tr/td[4]/span[1]/i"));
        private static IWebElement editCertificateTitle => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[2]/tr/td/div/div/div[1]/input"));
        private static IWebElement editCertificateFrom => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[2]/tr/td/div/div/div[2]/input"));
        private static IWebElement editYear => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[2]/tr/td/div/div/div[3]/select"));
        private static IWebElement updateButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[2]/tr/td/div/span/input[1]"));
        private static IWebElement certificationTabs => driver.FindElement(By.XPath("//a[contains(text(),'Certifications')]"));

        private static IWebElement deleteCertificate => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[4]/span[2]/i"));

        public void CertificationTabClick()
        {

            certificationTabs.Click();
            // clearExistingdata();
            Thread.Sleep(2000);
        }
        // Add Certification

        public void AddCertification(string award, string crtfrom, string crtyear)
        {
            //Selecting the Certification tab
            certificationTabSelect.Click();
            Thread.Sleep(3000);
            // Adding the Certification
            cerAddButton.Click();
            // Enter the Award
            addCertificationTitle.SendKeys(award);
            addCertificationTitle.Click();
            
            // Enter the from textbox
            addFrom.SendKeys(crtfrom);
            addFrom.Click();
      
            // Selecting the year
            selectYear.SendKeys(crtyear);
            selectYear.Click();
            Thread.Sleep(4000);

            addCertification.Click();

        }

        public void EditCertification(string Certification, string CertifiedFrom, string Year) 
        {
            certificationTabSelect.Click();
            //Click on editbutton
            Thread.Sleep(1000);

            cerEditIcon.Click();
            //Edit Certification
            editCertificateTitle.Clear();

            editCertificateTitle.SendKeys(Certification);
            //Edit CertificationFrom
            editCertificateFrom.Clear();
            editCertificateFrom.SendKeys(CertifiedFrom);
            //Edit year
            editYear.Click();
            editYear.SendKeys(Year);
            editYear.Click();
            Thread.Sleep(2000);

            updateButton.Click();

        }

        public string geteditCertificatefile()
        {
            Thread.Sleep(2000);
            return neweditCertificationfile.Text;
        }

        public void DeleteCertification() 
        {
            Thread.Sleep(1000);
            deleteCertificate.Click();

        }
    }
}




