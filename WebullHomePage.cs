using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebullHomePage;

public class WebullHomePageO : IDisposable
{
    public IWebDriver Driver;
    public WebullHomePageO()  
    {
        Driver = new ChromeDriver("C:\\Repos\\Csharp testing beginning\\driver\\chromedriver-win32\\chromedriver-win32");
    }
    public void Home()
    {
        Driver.Navigate().GoToUrl("https://www.webull.com");
    }

    public void LoginButton()
    {
         IWebElement logInAccount = Driver.FindElement(By.XPath("//div[@id='app']//button/*[contains(text(),'Log in')]"));
         logInAccount.Click();
    }

    public void Dispose()
    {
        Driver.Quit();
        Driver.Dispose();
    }   
}
