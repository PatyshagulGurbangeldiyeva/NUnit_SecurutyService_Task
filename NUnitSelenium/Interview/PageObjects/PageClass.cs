using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using NUnitSelenium.Interview.BaseClass;
using WebDriverManager;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Drawing;




using SeleniumExtras.PageObjects;


namespace NUnitSelenium.Interview.PageObjects
{
	public class PageClass:BaseTest
	{

        
        //page factory should not be used
        public PageClass()
        {
           
            PageFactory.InitElements(BaseTest.driver, this);
        }


        [FindsBy(How = How.CssSelector, Using = "h1[class='Title']")]
        public IWebElement PageTitle;

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement FirstName;


        [FindsBy(How = How.Id, Using = "FirstName-error")]
        public IWebElement FirstNameError;

        [FindsBy(How = How.CssSelector, Using = "label[for='Interests_0_']")]
        public IWebElement AutoCheckBox;

        [FindsBy(How = How.CssSelector, Using = "button[class='btn btn-warning btn-block']")]
        public IWebElement SubmitButton;

        [FindsBy(How = How.CssSelector, Using = "span[id='LastName-error']")]
        public IWebElement LastNameError;



        //IWebDriver driver = new ChromeDriver();

        //public IWebElement PageTitle = BaseTest.driver.FindElement(By.CssSelector("h1[class='Title']"));
        //public IWebElement FirstName = BaseTest.driver.FindElement(By.CssSelector("input[id='FirstName'][type='text']"));
        //public IWebElement FirstNameError = BaseTest.driver.FindElement(By.Id("FirstName-error"));
        //public IWebElement AutoCheckBox = BaseTest.driver.FindElement(By.CssSelector("label[for='Interests_0_']"));
        //public IWebElement SubmitButton = BaseTest.driver.FindElement(By.CssSelector("button[class='btn btn-warning btn-block']"));
        //public IWebElement LastNameError = BaseTest.driver.FindElement(By.CssSelector("span[id='LastName-error']"));


    }
}

