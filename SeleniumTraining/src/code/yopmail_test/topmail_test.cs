using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumTraining.src.code.pages_todoist;
using SeleniumTraining.src.code.yopmail_pages;


namespace SeleniumTraining.src.code.yopmail_test
{
    [TestClass]
    public class topmail_test :yopmail_base
    {
        Homepage homePage = new Homepage();
        Buzon buzon = new Buzon();
        Random random = new Random(); // Para que el subject del mensaje sea unico

        [TestMethod]
        public void VerifyCRUDProject()
        {
            int randomNumber = random.Next(100000, 999999); // Genera un número aleatorio de 6 dígitos
            String MailName = "wil@yopmail.com";
            String MailSubject = "Mensaje " + randomNumber.ToString();
            String MailMessage = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum congue vel eros sed blandit. Ut bibendum ligula et scelerisque fermentum. Donec nec pharetra magna. Duis at lorem dignissim, dictum nisi id, mattis tellus. Nunc vel consequat lorem. Nullam porta scelerisque purus, pretium eleifend nulla volutpat in.";

            homePage.EmailName.SetText(MailName);
            homePage.NextPage.Click();

            // add verificacion
            Assert.IsTrue(buzon.EmailIsDisplayed(MailName), "ERROR!The Email name is not correct");

            buzon.newEmail.Click();

            Thread.Sleep(1000);

            // Cambiando a iframe
            string frameNameOrId = "ifmail"; 
            session.Session.Instance().GetBrowser().SwitchTo().Frame(frameNameOrId);

            buzon.emailTo.SetText(MailName);            
            buzon.emailSubject.SetText(MailSubject);           
            buzon.emailMessage.SetText(MailMessage);
            buzon.sendMessage.Click();

            // Volviendo al frame original
            session.Session.Instance().GetBrowser().SwitchTo().DefaultContent();
            Thread.Sleep(1000);
            buzon.RefreshBuzon.Click();

            // Cambiando a iframe
            frameNameOrId = "ifinbox";
            session.Session.Instance().GetBrowser().SwitchTo().Frame(frameNameOrId);
            // add verificacion
            Assert.IsTrue(buzon.IsEmailSubjectDisplayed(MailSubject), "ERROR!The Email was not send");

            // Cambiando a iframe
            session.Session.Instance().GetBrowser().SwitchTo().DefaultContent();
            frameNameOrId = "ifmail";
            session.Session.Instance().GetBrowser().SwitchTo().Frame(frameNameOrId);
            // add verificacion
            Assert.IsTrue(buzon.IsButtonStatePass(), "ERROR!The Email message is wrong");


        }
    }
}
