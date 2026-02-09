//I tried to rename this Test Class to something logical but it broke everything,and VS Code has shitty history and I was barely able to revert it to a functioning name

using PlaywrightTests.Pages.HomePage;
using PlaywrightTests.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PlaywrightTests;

[TestClass]
public sealed class openHomePage : BaseTest
{
    
    [TestMethod]
    public async Task HomePage()
    {
        var homePage = new HomePage(Page);
        await homePage.NavigateHomePage(BaseUrl);
        await homePage.AssertWaitlistIsVisible();
    }



}
