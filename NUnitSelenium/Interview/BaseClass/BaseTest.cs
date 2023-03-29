using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using NUnitSelenium.Interview.Utilities;



namespace NUnitSelenium.Interview.BaseClass
   
{
    public class BaseTest
    {

        //public static IWebDriver driver = new ChromeDriver();
        public static IWebDriver driver;
       // private static ScreenShot ss;

        [SetUp]
        public static void Open()
        {
            // when chrome will be updated, then this code will update my chrome
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            //mac
            driver.Manage().Window.Maximize();
            //windows
            //driver.Manage().Window.FullScreen();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Url = "https://www.ssfcu.org/insurance/personal/request-a-quote";



        }


        [TearDown]
        public static void Close()
        {
            
            if (driver != null)
            {
               // CommonMethods.TakeScreenshot(driver, DateTime.Now.ToShortDateString());
                driver.Quit();
            }
            
        }
    }
}