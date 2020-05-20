using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SeleniumFramework
{
    public static class Driver
    {
        public static IWebDriver webDriver;

        public static void SetupBrowser(string browserType, double timeoutInSeconds = 30)
        {
            switch (browserType.Trim().ToLower())
            {
                case "chrome":
                    webDriver = new ChromeDriver();
                    break;
                case "ie":
                    webDriver = new InternetExplorerDriver();
                    break;
                case "firefox":
                    FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
                    service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
                    webDriver = new FirefoxDriver(service);
                    break;
                default:
                    throw new Exception("Unhandled browser name : " + browserType);
            }
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeoutInSeconds);
            webDriver.Manage().Window.Maximize();
        }
    }
}
