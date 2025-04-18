using WebullAppWatch;
using Xunit.Abstractions;
using CsvFileUtilities;

namespace AppWatchTest;
public class AppWatchTestO : IClassFixture<AppWatchO>
{
    private readonly AppWatchO _appWatch;
    private readonly ITestOutputHelper _testOutputHelper;
    public AppWatchTestO(AppWatchO _appWatch, ITestOutputHelper _testOutputHelper)
    {
        this._appWatch = _appWatch;
        this._testOutputHelper = _testOutputHelper;
    }

    CsvFileUtilitiesO csvFileUtility = new CsvFileUtilitiesO();

    [Fact]
    public void TestName4()
    {
        string nasdaqFilePath = _appWatch.GetNasdaqDailyStockReportCsvFile();
        Thread.Sleep(3000);
        string[] lines = File.ReadAllLines(nasdaqFilePath);
        string nasdaqOpeningPrice = csvFileUtility.SearchCsvFileCells(nasdaqFilePath, "US/Eastern"); 
        //the most recent Nasdaq opening price is next to the cell "US/Eastern", this method locates that record
        Console.WriteLine(nasdaqOpeningPrice);
    }

    // [Fact]
    //  public void TestName5()
    // {
    //     _appWatch.navigateWatchlists();
    // }
}
