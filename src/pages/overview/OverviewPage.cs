using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using PlaywrightTests.Pages.Overview;

namespace PlaywrightTests.Pages.HomePage;

public class HomePage
{
    private readonly IPage _page;
    private readonly OverviewLocators _locators;

    public HomePage(IPage page)
    {
        _page = page;
        _locators = new OverviewLocators(page);
    }

    public async Task NavigateHomePage(string baseUrl)
    {
        await _page.GotoAsync(baseUrl);
    }

    public async Task AssertWaitlistIsVisible()
    {
        await Expect(_locators.joinWaitlist).ToBeVisibleAsync();
    }
}
