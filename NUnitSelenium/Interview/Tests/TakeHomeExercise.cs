using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnitSelenium.Interview.BaseClass;
using NUnitSelenium.Interview.PageObjects;
using NUnitSelenium.Interview.Utilities;
using OpenQA.Selenium.Support.UI;







namespace Interview.Tests
{
    /// <summary>
    /// 
    /// Please take time to read all instructions carefully before starting.
    /// 
    /// This exercise is intended to test your problem solving skills, knowledge of C#, Selenium, HTML/CSS, and OO principals and design.  Feel free to use
    /// books or internet references to complete this exercise but please do not get help from others in any way or discuss this exercise with others.
    /// 
    /// </summary>


    [TestFixture]
    public class TakeHomeExercise : BaseTest
    {
        /// <summary>
        /// 
        /// Using C# and Selenium, please automate the test steps provided below:
        /// 1. Navigate to the "Request an Insurance Quote" page on our website, https://www.ssfcu.org/insurance/personal/request-a-quote

        /// 2. Assert the title ON the webpage (not driver.Title) using the variable, pageTitle
        /// 3. Fill in ONLY the first name field using the variable, firstName
        /// 4. Check "Auto" under Interest using the variable, interest
        /// 5. Click Submit
        /// 6. Assert that the First Name field does not have an error message
        /// 7. Assert the Last Name field error message using the variable, lastNameErrorMessage
        /// 
        /// Create a page object for the quote form page linked above that provides the functionality needed to complete this scenario
        /// using the variables provided. Please do not use PageFactory.
        /// 
        /// Your finished script should compile and run successfully using the Chrome browser.
        ///
        /// NOTE: Please run Build > Clean Solution before zipping your project and emailing it back. Thanks!
        /// 
        /// </summary>


        [Test, Category("Smoke Testing")]
        public void TakeHomeExercise1()
        {
            string firstName = "Security";
            string interest = "Auto";
            string lastNameErrorMessage = "Response required";
            string pageTitle = "Get a Quote";



            PageClass pObj = new PageClass();
            CommonMethods comObj = new CommonMethods();


            string ActualTitle = pObj.PageTitle.Text;
            Console.WriteLine("Actual Title: " + ActualTitle);
            Console.Read();

            Assert.True(ActualTitle.Contains(pageTitle));


            //driverTitle
            //Console.WriteLine("driver title: " + driver.Title);
            //Console.Read();

            comObj.ScrollTillElement(pObj.FirstName);
            comObj.SendText(pObj.FirstName, firstName);

            comObj.Wait(5);

            comObj.ScrollTillElement(pObj.AutoCheckBox);
            string actualAuto=pObj.AutoCheckBox.Text;
            Console.WriteLine("Actual Auto:" + actualAuto);
            Console.ReadLine();
            if (!pObj.AutoCheckBox.Selected && actualAuto.Equals(interest))
            {
                pObj.AutoCheckBox.Click();

            }

            comObj.ScrollDownByPixel();

          
            pObj.SubmitButton.Click();


            comObj.ScrollTillElement(pObj.FirstName);
            comObj.Wait(5);
            try
            {
                if (!pObj.FirstNameError.Displayed)
                {
                    Assert.Pass("Error message is not displayed");
                    Assert.False(pObj.FirstNameError.Displayed);
                    Console.WriteLine("Error message is not displayed");
                    Console.Read();
                }
                else
                {
                    string errorMessage = pObj.FirstNameError.Text;
                    Assert.Fail("Error Message is displayed: " + errorMessage);

                }
                


            }catch (Exception e)
            {
                Console.WriteLine(e);
                

            }

           String ActualLastNameErrorMessage= pObj.LastNameError.Text;
         //   Assert.AreEqual(ActualLastNameErrorMessage, lastNameErrorMessage);

            Assert.IsTrue(ActualLastNameErrorMessage.Equals(lastNameErrorMessage));
        }
    }
}