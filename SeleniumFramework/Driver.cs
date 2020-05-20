using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFramework
{
    public static class Driver
    {
        public static IWebDriver webDriver { get; set; }

        public static void SetupBrowser(string browserType)
        {
            switch (browserType.Trim().ToLower())
            {
                case "chrome":
                    webDriver = new ChromeDriver();
                    break;
            }
        }
    }
}
