using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.pages_todoist
{
    internal class login
    {
        public TextBox emailTxtBox = new TextBox(By.XPath("//input[@id=\"element-0\"]"));
        public TextBox pwdTxtBox = new TextBox(By.XPath("//input[@id=\"element-3\"]"));
        public Button loginButton = new Button(By.XPath("//button[@data-gtm-id=\"start-email-login\"]"));        

        public void Login(String user, String pwd)
        {
            emailTxtBox.SetText(user);
            pwdTxtBox.SetText(pwd);
            loginButton.Click();
        }
    }
}
//wilber.rojas.fernandez@gmail.com
//123w456r789