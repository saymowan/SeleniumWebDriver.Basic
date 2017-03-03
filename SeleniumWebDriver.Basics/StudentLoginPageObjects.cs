using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumWebDriver.Basics
{
    //modificador de acesso public
    public class StudentLoginPageObjects : WebDriver
    {
        //Tela mapeada: https://testmoz.com/1

        //Método construtor para inicializar os elementos
        public StudentLoginPageObjects()
        {
            PageFactory.InitElements(WebDriver.driver, this);
        }
        
        /// <summary>
        /// Método para mapear um elemento
        /// How: indica o tipo de elemento conforme encontrado na página web
        /// Using: o valor do elemento na tela
        /// IWebElement: elemento novo criado a partir de um mapeamento na tela
        /// </summary>
        [FindsBy(How = How.Id,Using = "id_student-name")]
        public IWebElement inputYourName { get; set; }

        //Mapeamento do botão da tela
        [FindsBy(How = How.Name, Using = "student")]
        public IWebElement btnContinue { get; set; }



    }
}
