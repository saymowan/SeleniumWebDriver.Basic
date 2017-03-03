using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebDriver.Basics.SeleniumUteis
{
    class SeleniumUteis
    {

        public static String getPathSeleniumDriver()
        {
            // Função para definir o path do diretório
            String strAppDir = Path.GetDirectoryName(
            Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6);
            //String strAppFolderData = Path.Combine(strAppDir, "\\SeleniumComum\\Drivers");

            //Função para reduzir em duas camadas a arvore do path
            var gparent = Directory.GetParent(Directory.GetParent(strAppDir).ToString());

            //Conversão var -> String
            String aux = gparent.ToString();

            //Concatenar Path diretorio + Path Drivers
            String strAppFolderData = String.Concat(aux, "\\Drivers");

            return strAppFolderData; //+ strAppFolderData;
        }



    }
}
