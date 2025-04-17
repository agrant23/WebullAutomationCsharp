using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebullAccount;

public class WebullAccountO : IDisposable
{
    public IWebDriver Driver;
    public WebullAccountO()  
    {
        Driver = new ChromeDriver("C:\\Repos\\Csharp testing beginning\\driver\\chromedriver-win32\\chromedriver-win32");
    }

    // public string NasdaqApiFileCsv(){
    //     return //string pathAndFileName;
    // }
    public void Dispose()
    {
        Driver.Quit();
        Driver.Dispose();
    }   
}

