using OpenQA.Selenium;
using SeleniumTraining.src.code.pages_todoist;
using SeleniumTraining.src.code.todoist_pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.test_todoist
{
    [TestClass]
    public class todoist_test : todoist_base
    {
        login login_1 = new login();
        LeftMenu leftMenu = new LeftMenu();
        Home_page homepage = new Home_page();
        

        [TestMethod]
        public void VerifyCRUDProject()
        {
            String name_proyect = "Mojix909090";
            String name_edited_proyect = "MojixUpdateddddd";

            homepage.IniciarSesion.Click();

            login_1.Login("wilber.rojas.fernandez@gmail.com", "123w456r789");
            
            leftMenu.Addproject.Click();
            leftMenu.projectNameTxtBox.SetText(name_proyect);
            leftMenu.ConfirmAddproject.Click();

            // add verificacion
            Assert.IsTrue(leftMenu.ProjectNameIsDisplayed(name_proyect), "ERROR!The project was not created");
            Thread.Sleep(1000); //Para las pruebas, comentar luego

            leftMenu.ClickMoreActionsButton(name_proyect);
            leftMenu.Menu_EditarProyecto.Click();
            leftMenu.EditarProyecto_name.SetText(name_edited_proyect);
            leftMenu.EditarProyecto_save.Click();

            // add verificacion
            Assert.IsTrue(leftMenu.ProjectNameIsDisplayed(name_edited_proyect), "ERROR!The project was not updated");
            Thread.Sleep(1000); //Para las pruebas, comentar luego

            leftMenu.ClickMoreActionsButton(name_edited_proyect);
            leftMenu.Menu_EliminarProyecto.Click();
            leftMenu.EliminarProyecto_yes.Click();
            Assert.IsFalse(leftMenu.ProjectNameIsDisplayed(name_edited_proyect), "ERROR!The project was not deleted");
            Thread.Sleep(1000); //Para las pruebas, comentar luego

        }

    }

}
