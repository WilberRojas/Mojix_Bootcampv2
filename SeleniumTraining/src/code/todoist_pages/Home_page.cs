using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumTraining.src.code.control;

namespace SeleniumTraining.src.code.todoist_pages
{
    internal class Home_page
    {
        public Button IniciarSesion = new Button(By.XPath("//a[contains(text(), 'Iniciar sesión')]"));        
    }
}
