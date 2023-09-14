using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class WebDriverSingleton
{
    private static IWebDriver _driver;

    private WebDriverSingleton() { }

    public static IWebDriver Instance
    {
        get
        {
            if (_driver == null)
            {
                _driver = new ChromeDriver();
            }
            return _driver;
        }
    }

    public static void Quit()
    {
        if (_driver != null)
        {
            _driver.Quit();
            _driver = null;
        }
    }
}
