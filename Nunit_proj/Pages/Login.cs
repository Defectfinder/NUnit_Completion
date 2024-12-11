using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_proj.Pages
{
    public class Login
    {
         public void LoginActions(IWebDriver driver)
            {

                //Login to the URL
                driver.Navigate().GoToUrl("http://localhost:5000/");
                driver.Manage().Window.Maximize();

                //Click on the SignIn
                IWebElement signInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
                signInButton.Click();
                Thread.Sleep(3000);

                //Identify the Username textbox 
                IWebElement usernameTexbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                usernameTexbox.SendKeys("mkalpana705@gmail.com");
                Thread.Sleep(3000);

                //Identify the Password textbox
                IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                passwordTextbox.SendKeys("UjZhU@Z!N8DY*wh7");

                // Identify the Login button
                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                loginButton.Click();
                Thread.Sleep(5000);

            }
        
    }
}
