using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _18_uzduotis
{
    public class Class1
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement inputName = driver.FindElement(By.XPath("//*[@id=\"userName\"]"));
            inputName.SendKeys("Gerda");

            IWebElement inputEmail = driver.FindElement(By.XPath("//*[@id=\"userEmail\"]"));
            inputEmail.SendKeys("varanaviciute.gerda@gmail.com");

            IWebElement inputCurrentAddress = driver.FindElement(By.XPath("//*[@id=\"currentAddress\"]"));
            inputCurrentAddress.SendKeys("Vilnius");

            IWebElement inputPernamentAddress = driver.FindElement(By.XPath("//*[@id=\"permanentAddress\"]"));
            inputPernamentAddress.SendKeys("Zarasai");

            IWebElement buttonSubmit = driver.FindElement(By.XPath("//*[@id=\"submit\"]"));
            buttonSubmit.Click();


        }

    }
}
