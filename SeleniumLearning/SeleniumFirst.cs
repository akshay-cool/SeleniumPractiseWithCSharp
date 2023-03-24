using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumLearning
{
    public class SeleniumFirst

    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            TestContext.Progress.WriteLine("Start the browser");
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }


        [Test]
        public void launchURL()
        {
            TestContext.Progress.WriteLine("This is used to launch URL");
            driver.Manage().Window.Maximize();
            driver.Url = "https://rahulshettyacademy.com/";
        }

        [TearDown]
        public void CloseBrowser()
        {
            TestContext.Progress.WriteLine("tear down method");
        }


    }
}