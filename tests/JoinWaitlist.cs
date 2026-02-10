using PlaywrightTests.Pages.HomePage;
using PlaywrightTests.Tests;
using PlaywrightTests.Pages.WaitlistForm;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PlaywrightTests;

[TestClass]
public sealed class JoinWaitlist : BaseTest
{


    [TestMethod]

    //The purpose of this test is to check if one is able to sign up for the Waitlist via automation. The expected behavior is no 
    public async Task JoinWaitlistTest()
    {
        
        var homePage = new HomePage(Page);

        //navigate to Home Page
        await homePage.NavigateHomePage(BaseUrl);

        //check that Waitlist in the header is visible
        await homePage.AssertWaitlistIsVisible();
        var waitlistPage = new WaitlistPage(Page);

        //we click on the Waitlist button in the header
        await waitlistPage.ClickWaitlistButtonInHeader();

        //input first name, last name and email
        await waitlistPage.InputFirstName("Jane");
        await waitlistPage.InputLastName("Doe");
        await waitlistPage.InputEmail("jane.doe@abv.bg");
        
        //hit next
        await waitlistPage.NextButton();

        //select I'm an Academic from the menu
        await waitlistPage.ImInAcademiaButton();

        //select Student from the dropdown
        await waitlistPage.ImAStudent();

        //input university name
        await waitlistPage.InputUniversityName("Technical University of Sofia");

        //select field of study
        await waitlistPage.SelectFieldOfStudy();

        //select Programming Experience with 'Intermediate' for this test
        await waitlistPage.SelectProgrammingExperience();

        //fill in the optional use-case field
        await waitlistPage.InputRelevantUseCase("I'm really passionate about software development and AI and I want to learn more about your product!");

        //check the state of the two checkboxes - they should be checked
        Assert.IsTrue(await waitlistPage.AssertCheckboxForCommunicationsIsChecked());
        Assert.IsTrue(await waitlistPage.AssertCheckboxForEmailAndPrivacyPolicyIsChecked());

        //attempt to click on Join Waitlist button - it should be disabled
        Assert.IsTrue(await waitlistPage.ClickJoinWaitlistButton());
          

    }  


}
