using System.Net;
using System.Text.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Conversions; 

namespace WebullAppWatch;

public class AppWatchO : IDisposable
{
    public IWebDriver Driver;
    ConversionsO conversions = new ConversionsO();
    //LoginPortalO _login = new LoginPortalO();

    public AppWatchO()
    {
        Driver = new ChromeDriver("C:\\Repos\\Csharp testing beginning\\driver\\chromedriver-win32\\chromedriver-win32");
    }
    string QUERY_URL = "https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol=IBM&interval=5min&apikey=P4E20MFFDE363Q5R";
    string fileName = $"NASDAQ-{DateTime.Now.ToFileTime()}.csv";
    string csvPath = Directory.GetCurrentDirectory();
    string csvPathDel = "\\bin\\Debug\\net9.0";  //removing this saves the file in the WebullHomePage directory of this repository on your device
    
    //method get's the endpoint from alphavantage, downloads a json file that has yesterday's NASDAQ opening price
    //this file is eventually converted to a csv file that is saved to your PC in this repo's WebullHomePage directory
    public string GetNasdaqDailyStockReportCsvFile()
    {
            Uri queryUri = new Uri(QUERY_URL);
            using (WebClient client = new WebClient())    //Selenium is not engineered for API testing, the Driver above is for UI testing shown below
            {
                dynamic NasdaqAPIjson = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(client.DownloadString(queryUri));
                string jsonString = JsonSerializer.Serialize(NasdaqAPIjson);
                string cleanCsvPath = csvPath.Remove(csvPath.IndexOf(csvPathDel),csvPathDel.Length);
                conversions.saveCsvFileFromJsonString(jsonString, cleanCsvPath, fileName);
                string filePath = String.Concat(cleanCsvPath, "\\" ,fileName);
        return filePath;
        }
    }

    public void Dispose()
    {
        Driver.Quit();
        Driver.Dispose();
    }   
}
