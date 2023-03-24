using CSharpSelFramework.utilities;
using OpenQA.Selenium;

namespace CSharpSelFramework.test
{
    public class Tests : Base
    {


        [Test]
        public void Test1()
        {
            driver.FindElement(By.Id("UserName")).SendKeys("akshay.kulkarni");
            driver.FindElement(By.XPath("//input[@name=\"Password\"]")).SendKeys("@Kshay123");
            driver.FindElement(By.Id("LogonButton")).Click();

            Assert.Pass();
        }
    }
}