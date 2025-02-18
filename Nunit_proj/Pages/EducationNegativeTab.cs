using NUnit.Framework;
using Nunit_proj.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_proj.Pages
{

    public class EducationNegativeTab : CommonDriver
    {
        private static IWebElement selectEduTab => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
        private static IWebElement buttonAddNew => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        private static IWebElement universityText => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
        private static IWebElement countryDrop => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
        private static IWebElement titleDropDown => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
        private static IWebElement degreeTextBox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
        private static IWebElement yearDrop => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
        private static IWebElement selectAdd => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
        private static IWebElement editIconEducation => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td[6]/span[1]/i"));
        private static IWebElement editUniversity => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td/div[1]/div[1]/input"));
        private static IWebElement editCountry => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td/div[1]/div[2]/select"));
        private static IWebElement editTitle => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td/div[2]/div[1]/select"));
        private static IWebElement editdegree => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td/div[2]/div[2]/input"));
        private static IWebElement edityear => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td/div[2]/div[3]/select"));
        private static IWebElement updateButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[2]/tr/td/div[3]/input[1]"));

        public void AddNegativeEducation(string University, string Country, string Title, string Degree, string Year) 
        {
            selectEduTab.Click();
            Thread.Sleep(3000);
            buttonAddNew.Click();
            universityText.Click();
            universityText.SendKeys(University);

            Thread.Sleep(2000);
            countryDrop.Click();
            countryDrop.SendKeys(Country);

            Thread.Sleep(1000);
            titleDropDown.Click();
            titleDropDown.SendKeys(Title);

            // Enter the Degree
            degreeTextBox.Click();
            degreeTextBox.SendKeys(Degree);
            // Enter the year
            Thread.Sleep(2000);
            yearDrop.Click();
            yearDrop.SendKeys(Year);

            selectAdd.Click();

            
        }

        public void EditNegEducation(string University, string Country, string Title, string Degree, string Year) 
        {

            selectEduTab.Click();
            Thread.Sleep(3000);
            // Select the Edit Icon
            editIconEducation.Click();
            //Edit the University
            editUniversity.Click();
            editUniversity.Clear();
            editUniversity.SendKeys(University);

            Thread.Sleep(2000);
            //Edit the Country
            editCountry.Click();
            editCountry.SendKeys(Country);
            Thread.Sleep(1000);
            //Edit the Title
            editTitle.Click();
            editTitle.SendKeys(Title);

            editdegree.Click();
            editdegree.Clear();
            editdegree.SendKeys(Degree);

            Thread.Sleep(2000);
            // Edit the year
            edityear.Click();
            edityear.SendKeys(Year);

            //Select the update button
            updateButton.Click();

        }
    }
}
