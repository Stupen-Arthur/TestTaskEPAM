using System;
using System.Collections.Generic;

namespace ConsoleApplicationFigures
{
    class ConsoleApplicationClass
    {
        private static void Main()
        {
            FigureInterface figureInterface = new FigureInterface();
            ConsoleMenu consoleMenu = new ConsoleMenu();
            
            do
            {
                consoleMenu.ShowGlobalMenu();
                consoleMenu.Choice = Convert.ToInt32(Console.ReadLine());
                consoleMenu.UpdateGlobalMenu();
            } 
            while (consoleMenu.Choice != 0);

        }
    }
}
