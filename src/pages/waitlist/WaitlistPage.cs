using Microsoft.Playwright;
using static Microsoft.Playwright.Assertions;
using PlaywrightTests.Pages.Waitlist;

namespace PlaywrightTests.Pages.WaitlistForm;

public class WaitlistPage
{
    private readonly IPage _page;
    private readonly WaitlistLocators _locators;

    public WaitlistPage(IPage page)
    {
        _page = page;
        _locators = new WaitlistLocators(page);
    }

    public async Task ClickWaitlistButtonInHeader()
    {
        await _locators.joinWaitlist.ClickAsync();
    }

    public async Task InputFirstName(string firstName)
    {
        await _locators.firstNameInput.FillAsync(firstName);
    }

    public async Task InputLastName(string lastName)
    {
        await _locators.lastNameInput.FillAsync(lastName);
    }
    
    public async Task InputEmail(string email)
    {
        await _locators.emailInput.FillAsync(email);
    }

    public async Task NextButton()
    {
        await _locators.nextButton.ClickAsync();
    }

    public async Task ImInAcademiaButton()
    {
       await _locators.imInAcademiaButton.ClickAsync();
    }

    public async Task ImAStudent()
    {
        await _page.GetByLabel("Please specify your role:").SelectOptionAsync("Student");
    }

    public async Task InputUniversityName(string university)
    {
        await _locators.universityName.FillAsync(university);
    }

     public async Task SelectFieldOfStudy()
    {
        await _page.GetByLabel("Field of Study").SelectOptionAsync("Software / Systems Engineering");
    }

    

     public async Task SelectProgrammingExperience()
    {
        await _page.GetByLabel("Programming Experience").SelectOptionAsync("Intermediate (built small projects)");
    }

    public async Task InputRelevantUseCase(string usecase)
    {
        await _locators.relevantUseCaseTextField.FillAsync(usecase);
    }

    public async Task<bool> AssertCheckboxForCommunicationsIsChecked()
    {
        return await (_locators.checkboxForCommunications).IsCheckedAsync();
    }

    public async Task<bool> AssertCheckboxForEmailAndPrivacyPolicyIsChecked()
    {
        return await (_locators.checkboxForEmailAndPrivacyPolicy).IsCheckedAsync();
    }

    public async Task<bool> ClickJoinWaitlistButton()
    {
        await _locators.joinWaitlistButton.IsDisabledAsync();
        return true;
    }

}
