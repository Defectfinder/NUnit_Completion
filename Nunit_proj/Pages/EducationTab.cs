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
    public class EducationTab : CommonDriver
    {
        private static IWebElement educationTab => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
        private static IWebElement addEducationButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        private static IWebElement collegeTextbox => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
        private static IWebElement countryDropdown => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
        private static IWebElement optionSelect => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[66]"));
        private static IWebElement titleDropdown => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
        private static IWebElement optionTitleSelect => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[6]"));
        private static IWebElement degreeText => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
        private static IWebElement yearDropdown => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
        //private static IWebElement yearSelect => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[15]"));
        private static IWebElement addButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
        private static IWebElement newEducationfile => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
        private static IWebElement editButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));

        private static IWebElement editedUniversity => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));
        private static IWebElement editedCountry => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[2]/select"));
        private static IWebElement editedTitle => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[1]/select"));
        private static IWebElement editedDegree => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));
        private static IWebElement editedYear => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[3]/select"));

        private static IWebElement updateButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));
        private static IWebElement deleteButton => driver.FindElement(By.XPath("//tbody/tr[1]/td[6]/span[2]"));
        public void  AddEducation(string University, string Country, string Title, string Degree, string Year)
        {
            
            
            educationTab.Click();
            Thread.Sleep(4000);
            addEducationButton.Click();

            collegeTextbox.SendKeys(University);
            Thread.Sleep(3000);
            collegeTextbox.Click();
            countryDropdown.Click();
            countryDropdown.SendKeys(Country);
            

            optionSelect.Click();
            titleDropdown.Click();
            titleDropdown.SendKeys(Title);
            Thread.Sleep(2000);

            
            optionTitleSelect.Click();
            Thread.Sleep(3000);

            
            degreeText.SendKeys(Degree);
            Thread.Sleep(10000);

            yearDropdown.Click();
            Thread.Sleep(2000);
            yearDropdown.SendKeys(Year);
            //yearSelect.Click();
            Thread.Sleep(2000);

            
            addButton.Click();

        }

        public string getnewEducationfile()
        {
            Thread.Sleep(2000);
            return newEducationfile.Text;
        }

        //Edit university from the list
        public void EditEducation(string University, string Country, string Title, string Degree, string Year) 
        {
            //Click On Edit button

            Thread.Sleep(1000);
            editButton.Click();

            //Edit university

            editedUniversity.Clear();
            editedUniversity.SendKeys(University);

            // Edit Country
            editedCountry.Click();
            editedCountry.SendKeys(Country);

            //Edit Title
            editedTitle.Click();
            editedTitle.SendKeys(Title);

            //Edit Degree
            editedDegree.Clear();
            editedDegree.SendKeys(Degree);

            //Edit Year
            editedYear.Click();
            editedYear.SendKeys(Year);



            //Click on update button
            updateButton.Click();
            Thread.Sleep(2000);


            IWebElement Messagebox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

            //WaitUtilitie.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 100);

            string actualMessage = Messagebox.Text;
            Console.WriteLine(actualMessage);
            string expectedMessage1 = "Education as been updated";
            string expectedMessage2 = "Please enter all the fields";
            string expectedMessage3 = "This information is already exist.";

            Assert.That(actualMessage, Is.EqualTo(expectedMessage2).Or.EqualTo(expectedMessage1).Or.EqualTo(expectedMessage3));

        }

        //Deleting a Education
        public void DeleteEducation()
        {
            Thread.Sleep(1000);

            deleteButton.Click();
        }
    }
}
