using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.yopmail_pages
{
    public class Homepage
    {
        public TextBox EmailName = new TextBox(By.ClassName("ycptinput"));

        public Button NextPage = new Button(By.CssSelector("button[title='Revisa el correo @yopmail.com']"));

    }
}
