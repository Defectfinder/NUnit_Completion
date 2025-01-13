using Nunit_proj.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_proj.Pages
{
    public class CertificationNegativepage : CommonDriver
    {
        private static IWebElement certificationTab => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
        private static IWebElement AddNewButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private static IWebElement CertificateTextBox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));

        private static IWebElement CertifiedFromTextBox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));

        private static IWebElement YearDropDown => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
        private static IWebElement AddButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
        private static IWebElement editButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[4]/span[1]/i"));
        private static IWebElement editCertificate => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[1]/input"));
        private static IWebElement editCertifiedFrom => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[2]/input"));
        private static IWebElement editYear => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/div/div[3]/select"));
        private static IWebElement updateButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
        

        public void CertificationTabClick()
        {

            certificationTab.Click();
        }
        public void AddInvalidCertification(string Certificate, string CertificateFrom, string Year)
        {
            // Click on AddNew button
            AddNewButton.Click();

            //Add certification that needs to be 
            CertificateTextBox.SendKeys(Certificate);

            //Enter  CertifiedFrom
            CertifiedFromTextBox.SendKeys(CertificateFrom);

            //Enter year
           // WaitUtilitie.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select", 1);
            YearDropDown.Click();
            YearDropDown.SendKeys(Year);

            // click addnew button
            AddButton.Click();
            Thread.Sleep(1000);


           
        }
        public void EditCertification(string Certification, string CertifiedFrom, string Year)
        {
            //Click on editbutton
            Thread.Sleep(1000);

            editButton.Click();
            //Edit Certification
            editCertificate.Clear();

            editCertificate.SendKeys(Certification);
            //Edit CertificationFrom
            editCertifiedFrom.Clear();
            editCertifiedFrom.SendKeys(CertifiedFrom);
            //Edit year
            editYear.Click();
            editYear.SendKeys(Year);




            //Click On UpdateButton
            updateButton.Click();
            Thread.Sleep(2000);


            


        }
    }
}

