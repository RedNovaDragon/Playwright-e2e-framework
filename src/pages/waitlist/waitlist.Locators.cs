using Microsoft.Playwright;
namespace PlaywrightTests.Pages.Waitlist;

public class WaitlistLocators
{
    private readonly IPage _page;

    public WaitlistLocators(IPage page)
    {
        _page = page;
    }

    public ILocator joinWaitlist =>
     _page.Locator(".nav-cta-wrapper a[href='/#waitlist-form']");

    public ILocator firstNameInput =>
        _page.GetByLabel("First Name");

    public ILocator lastNameInput =>
        _page.GetByLabel("Last Name");    

    public ILocator emailInput =>
        _page.GetByRole(AriaRole.Textbox, new() { Name = "Email" });

    public ILocator nextButton =>
        _page.Locator("#Next-form");

     public ILocator imInAcademiaButton =>
        _page.GetByText ("I Am In academia");   


      public ILocator universityName =>
         _page.GetByPlaceholder("Enter your university name");


    public ILocator relevantUseCaseTextField =>
        _page.GetByPlaceholder("Tell us briefly about your recent project or coursework");    


    public ILocator checkboxForCommunications =>
        _page.GetByLabel("Academia Form", new() { Exact = true }).GetByText("I agree to receive updates");        

    public ILocator checkboxForEmailAndPrivacyPolicy =>
          _page.GetByLabel("Academia Form", new() { Exact = true }).GetByText("I agree to receive updates"); 

    public ILocator joinWaitlistButton =>
        
        _page.GetByLabel("Academia Form", new() { Exact = true }).GetByRole(AriaRole.Button, new() { Name = "JOIN THE WISHLIST" });      

      
    public ILocator joinedWaitlistsuccessfully =>
        _page.GetByText("Thank you.");

       
}