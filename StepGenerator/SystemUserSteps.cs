using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace OrangeHRMJune2020.StepGenerator
{
   
 //   [Binding]
    public class SystemUserSteps
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"I  login to Orange Hrm page administration")]
        public void GivenILoginToOrangeHrmPageAdministration()
        {
            var loginPage = new LoginPage(driver);
            loginPage.LoginSuccess();
        }
        
        [Given(@"I have navigated to System User page")]
        public void GivenIHaveNavigatedToSystemUserPage()
        {
            var dashboardPage = new DashBoardPage(driver);
            //dashboardPage.ClickUsers();
        }
        
        [Then(@"I should be able to add new user successfiully\.")]
        [Obsolete]
        public void ThenIShouldBeAbleToAddNewUserSuccessfiully_()
        {
            var systemUsersPage = new SystemUsersPage(driver);
            systemUsersPage.ClickAdd();
            systemUsersPage.AddAndSaveUser();
            systemUsersPage.VerifyUser();
        }
    }
}
