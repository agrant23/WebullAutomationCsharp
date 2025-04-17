using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebullHomePage;

namespace LoginPortal;

public class LoginPortalO : IDisposable
{
    public IWebDriver Driver;
    
    public LoginPortalO()  
    {
        Driver = new ChromeDriver("C:\\Repos\\Csharp testing beginning\\driver\\chromedriver-win32\\chromedriver-win32");
    }

    public void Login(bool loginStartInd = true)
    {
        string logInEmail = "grantanthony852@gmail.com";
        string logInPassword = "Mark589!";
        if (loginStartInd) {
             Driver.Navigate().GoToUrl("https://www.webull.com");
        }
        //Thread.Sleep(1500);
        IWebElement logInAccount = Driver.FindElement(By.XPath("//div[@id='app']//button/*[contains(text(),'Log in')]"));
        logInAccount.Click();
        IWebElement emailLoginButton = Driver.FindElement(By.XPath("//div[@id='app']//*[contains(text(),'Email Login')]"));
        emailLoginButton.Click();
        IWebElement emailLoginField = Driver.FindElement(By.XPath("//div[@id='app']//following-sibling::*//input[@type='text']"));
        emailLoginField.SendKeys(logInEmail);
        IWebElement passwordLoginField = Driver.FindElement(By.XPath("//div[@id='app']//following-sibling::*//input[@type='password']"));
        passwordLoginField.SendKeys(logInPassword);
        IWebElement logInButton = Driver.FindElement(By.XPath("//div[@id='app']//following-sibling::*//button/*[text()='Log In']"));
        logInButton.Click();
    }
    public void Dispose()
    {
        Driver.Quit();
        Driver.Dispose();
    }   
}
