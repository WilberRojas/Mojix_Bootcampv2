using OpenQA.Selenium;
using SeleniumTraining.src.code.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.test
{
    [TestClass]
    public class ProjectTest : TestBase
    {

        MainPage mainPage = new MainPage();
        LoginSection loginSection = new LoginSection();
        LeftSite leftSite = new LeftSite();
        Random random = new Random();
        


        [TestMethod]
        public void VerifyCRUDProject()
        {
            mainPage.loginButton.Click();
            loginSection.Login("wilber.rojas.fernandez@gmail.com", "KNcvF57FENujH6F");

            leftSite.addNewProjectButton.Click();
            int randomNumber = random.Next(1000000, 9999999); // Genera un número aleatorio de 7 dígitos
            string testNumber = "Test " + randomNumber.ToString();
            leftSite.projectNameTxtBox.SetText("testNumber");
            leftSite.addButton.Click();

            // add verificacion
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("Mojix909090"), "ERROR!The project was not created");
            Thread.Sleep(1000);
            leftSite.ClickProjectName("Mojix909090");
            leftSite.subMenuIcon.Click();
            leftSite.editButton.Click();
            leftSite.projectNameEditTxtBox.SetText("MojixUpdateddddd");
            leftSite.saveButton.Click();

            // add verificacion
            Assert.IsTrue(leftSite.ProjectNameIsDisplayed("MojixUpdateddddd"), "ERROR!The project was not updated");
            Thread.Sleep(1000);

            leftSite.ClickProjectName("MojixUpdateddddd");
            leftSite.subMenuIcon.Click();
            leftSite.deleteButton.Click();

             Thread.Sleep(1000);
            session.Session.Instance().GetBrowser().SwitchTo().Alert().Accept();
             Thread.Sleep(1000);
            // add verificacion
            Assert.IsFalse(leftSite.ProjectNameIsDisplayed("MojixUpdateddddd"), "ERROR!The project was not deleted");


        }

    }
}
