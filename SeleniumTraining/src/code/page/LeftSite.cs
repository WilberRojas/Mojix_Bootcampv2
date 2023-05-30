using OpenQA.Selenium;
using SeleniumTraining.src.code.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTraining.src.code.page
{
    public class LeftSite
    {
        public Button addNewProjectButton = new Button(By.XPath("//td[text()='Add New Project']"));
        public TextBox projectNameTxtBox = new TextBox(By.Id("NewProjNameInput"));
        public Button addButton = new Button(By.Id("NewProjNameButton"));

        public Button subMenuIcon = new Button(By.XPath("//div[contains(@style,'block')]/img"));
        public Button editButton = new Button(By.XPath("//ul[contains(@style,'block')]//a[text()='Edit']"));
        public TextBox projectNameEditTxtBox = new TextBox(By.XPath("//td/div/input[@id='ItemEditTextbox']"));
        public Button saveButton = new Button(By.XPath("//td/div/img[@id='ItemEditSubmit']"));

        public Button deleteButton = new Button(By.Id("ProjShareMenuDel"));
        public Boolean ProjectNameIsDisplayed(String nameValue) 
        {
            Label nameProject = new Label(By.XPath("(//ul[@id=\"mainProjectList\"]/li//td[text()='"+ nameValue + "'])[last()]"));
            return nameProject.IsControlDisplayed();
        }

        public void ClickProjectName(String nameValue)
        {
            Label nameProject = new Label(By.XPath("(//ul[@id=\"mainProjectList\"]/li//td[text()='" + nameValue + "'])[last()]"));
            nameProject.Click();
        }

        //Estos se deben mover:
        public TextBox Newtask_TextBox = new TextBox(By.Id("NewItemContentInput"));
        public Button Newtask_Button = new Button(By.Id("NewItemAddButton"));        
        public Button Newtask_CheckBoxButton = new Button(By.XPath("//input[@type='checkbox' and @class='ItemCheckBox' and ancestor::div[contains(text(), 'Project Mojix Mod1')]]"));


        public TextBox task_TextBox = new TextBox(By.XPath("//div[contains(text(), 'Project Mojix Mod1')]"));
        public Button Options_task = new Button(By.CssSelector("td.ItemIndicator img.ItemMenu[src='/Images/dropdown.png']"));
        public Button Prioridad_maxima_color = new Button(By.CssSelector("span.PrioFrame[iconid='1']"));
        public Button icono_favorito = new Button(By.CssSelector("span.IconFrame[iconid='6']"));
        
        

    }
}
