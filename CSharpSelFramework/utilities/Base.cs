using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V108.Debugger;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace CSharpSelFramework.utilities
{
    public class Base
    {
        public IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            //String browserName = ConfigurationManager.AppSettings["browser"];
            // InitBrowser(browserName);
            //TestContext.Progress.WriteLine("Start the browser");

            //InitBrowser("Chrome");
            string USERNAME = "akshaykulkarni_BuwWCn";
            string AUTOMATE_KEY = "2QDSqvBdN4Kqay3YhubQ";

            OpenQA.Selenium.Chrome.ChromeOptions capability = new OpenQA.Selenium.Chrome.ChromeOptions();

            // for Firefox
            // OpenQA.Selenium.Firefox.FirefoxOptions capability = new OpenQA.Selenium.Firefox.FirefoxOptions();

            // for Safari
            // OpenQA.Selenium.Safari.SafariOptions capability = new OpenQA.Selenium.Safari.SafariOptions();

            ChromeOptions capabilities = new ChromeOptions();
            capabilities.BrowserVersion = "latest";
            Dictionary<string, object> browserstackOptions = new Dictionary<string, object>();
            browserstackOptions.Add("userName", USERNAME);
            browserstackOptions.Add("accessKey", AUTOMATE_KEY);
            browserstackOptions.Add("os", "Windows");
            browserstackOptions.Add("osVersion", "11");
            browserstackOptions.Add("projectName", "Sample sandbox project");
            browserstackOptions.Add("buildName", "Build #1");
            browserstackOptions.Add("sessionName", "My First Test");
            capabilities.AddAdditionalOption("bstack:options", browserstackOptions);
            capabilities.AddAdditionalOption("browserstack.idleTimeout", "300");

            //IWebDriver driver;
            driver = new RemoteWebDriver(
              new Uri("https://hub-cloud.browserstack.com/wd/hub/"), capabilities
            );

            driver.Manage().Window.Maximize();

            driver.Url = "https://qa.setflow.com/Account/Login";
            
        }

       /* public void InitBrowser(string browserName)
        {
           
            switch (browserName)
            {
                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;

                case "Chrome":
                      new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();

                    break;

                case "Edge":
                    driver = new EdgeDriver();
                    break;

            }
        }
       */
        [TearDown]
        public void AfterTest()
        {
            driver.Quit();
        }
    }
}
