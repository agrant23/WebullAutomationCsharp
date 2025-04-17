using LoginPortal;
using Xunit.Abstractions;


namespace LoginTest;
public class WebullLoginTest : IClassFixture<LoginPortalO>
{
    private readonly LoginPortalO _loginPortal;
    private readonly ITestOutputHelper _testOutputHelper;

    public WebullLoginTest(LoginPortalO _loginPortal, ITestOutputHelper _testOutputHelper)
    {
        this._loginPortal = _loginPortal;
        this._testOutputHelper = _testOutputHelper;
    }

    [Fact]
    public void LoginPortalTest()
    {
        _loginPortal.Login();
    }
    // [Fact]
    //  public void est2()
    // {
    // }
}
