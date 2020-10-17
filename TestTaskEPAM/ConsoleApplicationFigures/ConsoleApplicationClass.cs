using System;

namespace ConsoleApplicationFigures
{
    class ConsoleApplicationClass
    {
        private static void Main()
        {
            ConsoleMenu consoleMenu = new ConsoleMenu();

            do
            {
                consoleMenu.ShowGlobalMenu();
                consoleMenu.Choice = Convert.ToInt32(Console.ReadLine());
                consoleMenu.UpdateGlobalMenu();
            } while (consoleMenu.Choice != 0);
        }
    }
}
