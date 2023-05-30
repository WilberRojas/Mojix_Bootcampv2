using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumTraining.src.code.page;

namespace SeleniumTraining.src.code.test
{
    [TestClass]
    public class TC1 : TestBase
    {
        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        LeftSite leftSite = new LeftSite();
        //Random random = new Random();

        [TestMethod]
        public void VerifyCRUDProject()
        {
            mainPage.loginButton.Click();
            loginSection.Login("wilber.rojas.fernandez@gmail.com", "KNcvF57FENujH6F");

            leftSite.addNewProjectButton.Click();
            //int randomNumber = random.Next(1000000, 9999999); // Genera un número aleatorio de 7 dígitos
            string testNumber = "Project Mojix Mod1";// + randomNumber.ToString();
            leftSite.projectNameTxtBox.SetText(testNumber);
            leftSite.addButton.Click();

            // add verificacion
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed(testNumber), "ERROR!The project was not created");
            Thread.Sleep(1000);
        }
    }
}
