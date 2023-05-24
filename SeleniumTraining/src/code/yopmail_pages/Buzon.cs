using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using SeleniumTraining.src.code.control;

namespace SeleniumTraining.src.code.yopmail_pages
{
    internal class Buzon
    {
        public bool EmailIsDisplayed(string emailValue)
        {
            Label emailLabel = new Label(By.XPath($"//div[@class='ycptalias']//div[@class='bname'][text()='{emailValue}']"));
            return emailLabel.IsControlDisplayed();
        }

        //iframe localizadores
        public Button newEmail = new Button(By.Id("newmail"));
        public TextBox emailTo = new TextBox(By.Id("msgto"));
        public TextBox emailSubject = new TextBox(By.Id("msgsubject"));
        public TextBox emailMessage = new TextBox(By.Id("msgbody"));
        public Button sendMessage = new Button(By.Id("msgsend"));
        //END iframe localizadores  

        public Button RefreshBuzon = new Button(By.Id("refresh"));

        public bool IsEmailSubjectDisplayed(string email_subject)
        {
            Label subjectlabel = new Label(By.XPath($"//div[@class='lms' and text()='{email_subject}']"));
            return subjectlabel.IsControlDisplayed();
        }

        public bool IsButtonStatePass()
        {
            Label buttonpass = new Label(By.CssSelector("button#icodeliverability[state='pass']"));
            return buttonpass.IsControlDisplayed();
        }

    }
}
