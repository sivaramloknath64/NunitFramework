using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumNunit
{
    class SeleniumFirst
    {

        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
           
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            //driver = new EdgeDriver();
            //new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            //  driver = new FirefoxDriver();
        }

        [Test]
        public void First()
        {
            driver.Url = "https://Google.com";
            TestContext.Progress.WriteLine(driver.Title);
            TestContext.Progress.WriteLine(driver.Url);
            driver.Close();

        }
    }
}
