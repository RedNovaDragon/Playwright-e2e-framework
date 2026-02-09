using Microsoft.Playwright;
using PlaywrightTests.Config;
namespace PlaywrightTests.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public abstract class BaseTest
{
    protected IPlaywright Playwright = null!;
    protected IBrowser Browser = null!;
    protected IBrowserContext Context = null!;
    protected IPage Page = null!;

     protected string BaseUrl = null!;

    [TestInitialize]
    public async Task Setup()
    {
        Playwright = await Microsoft.Playwright.Playwright.CreateAsync();

       
       // the headless part of this can and should be moved to a config file, I just don't know how
        Browser = await Playwright.Chromium.LaunchAsync(new()
        {
            Headless = false
        });

         var config = ConfigLoader.Load();
        BaseUrl = config.BaseUrl;
        Context = await Browser.NewContextAsync();
        Page = await Context.NewPageAsync();
    }

    [TestCleanup]
    public async Task TearDown()
    {
        await Context.CloseAsync();
        await Browser.CloseAsync();
        Playwright.Dispose();
    }
}
