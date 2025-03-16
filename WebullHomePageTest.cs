using WebullHomePage;
using Xunit.Abstractions;


namespace HomePageTest;
public class HomePageTest : IClassFixture<WebullHomePageO>
{
    private readonly WebullHomePageO _homePage;
    private readonly ITestOutputHelper _testOutputHelper;

    public HomePageTest(WebullHomePageO _homePage, ITestOutputHelper _testOutputHelper)
    {
        this._homePage = _homePage;
        this._testOutputHelper = _testOutputHelper;
    }

    [Fact]
    public void TestName2()
    {
        Console.WriteLine("Console 1");
        _homePage.Home();
    }
    // [Fact]
    //  public void est2()
    // {
    // }
}
