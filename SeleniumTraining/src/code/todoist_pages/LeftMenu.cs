using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumTraining.src.code.control;

namespace SeleniumTraining.src.code.pages_todoist
{
    internal class LeftMenu
    {
        //public Button Proyectos = new Button(By.LinkText("Proyectos"));
        public Button Addproject = new Button(By.XPath("//button[@aria-label='Añadir proyecto']"));
        public TextBox projectNameTxtBox = new TextBox(By.XPath("//input[@id='edit_project_modal_field_name']"));
        public Button ConfirmAddproject = new Button(By.XPath("//button[span[text()='Añadir']]"));
        public bool ProjectNameIsDisplayed(string nameValue)
        {            
            Label nameProject = new Label(By.XPath($"//ul[@id='projects_list']/li//a[contains(span/text(), '{nameValue}')]"));
            return nameProject.IsControlDisplayed();
        }

        public void ClickMoreActionsButton(string projectName)
        {
            Label nameProject = new Label(By.XPath($"//ul[@id='projects_list']//a[contains(span/text(), '{projectName}')]/following-sibling::div/button[contains(@aria-label, 'Más acciones de proyecto')]"));
            nameProject.Click();
        }

        public Button Menu_EditarProyecto = new Button(By.XPath("//div[contains(@class, 'icon_menu_item__content') and text()='Editar proyecto']"));
        public TextBox EditarProyecto_name = new TextBox(By.Id("edit_project_modal_field_name"));
        public Button EditarProyecto_save = new Button(By.XPath("//button[span[text()='Guardar']]"));

        public Button Menu_EliminarProyecto = new Button(By.XPath("//div[contains(@class, 'icon_menu_item__content') and text()='Eliminar proyecto']"));
        public Button EliminarProyecto_yes = new Button(By.XPath("//button[span[contains(text(), 'Eliminar')]]"));
    }
}
