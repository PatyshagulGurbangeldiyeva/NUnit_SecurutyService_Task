using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnitSelenium.Interview.BaseClass;
using NUnitSelenium.Interview.PageObjects;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using WebDriverManager.Helpers;
using System.IO;
using System.Drawing;


namespace NUnitSelenium.Interview.Utilities
{
	public class CommonMethods:BaseTest
	{
        
    

        

        IJavaScriptExecutor js;
       public static Screenshot ss;

        public  static string TakeScreenshot(IWebDriver driver, string screenshotName)
        {
            ss = ((ITakesScreenshot)driver).GetScreenshot();
            string uniqueString = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            uniqueString = uniqueString.Replace("/", "");
            uniqueString = uniqueString.Replace(":", "");
            string path = Directory.GetCurrentDirectory() + "_" + screenshotName + "_" + uniqueString + ".png";
            ss.SaveAsFile(path);
            return path;
        }

        public void Wait(int sec)
        {
            try
            {
                Thread.Sleep(sec * 1000);
            }
            catch (WebDriverException e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }
            
           
            
        }
        public  void ScrollTillElement(IWebElement element)
		{
            js = (IJavaScriptExecutor)BaseTest.driver;
			js.ExecuteScript("arguments[0].scrollIntoView();", element);

		}

        public void ScrollDownByPixel()
        {
            js = (IJavaScriptExecutor)BaseTest.driver;
            js.ExecuteScript("window.scrollBy(0,750);");
            Wait(5);


        }
        public void SendText(IWebElement element, String text)
        {
            element.Clear();
            Wait(5);
            element.SendKeys(text);

        }
	}
}

