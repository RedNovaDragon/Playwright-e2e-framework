//This should've been named the 'Home Page', I don't know what I was thinking
using Microsoft.Playwright;
namespace PlaywrightTests.Pages.Overview;

public class OverviewLocators
{
    private readonly IPage _page;

    public OverviewLocators(IPage page)
    {
        _page = page;
    }

    public ILocator joinWaitlist =>
     _page.Locator(".nav-cta-wrapper a[href='/#waitlist-form']");

    public ILocator waitlistNotVisibleError =>
        _page.GetByTestId("Waitlist button not found");
}