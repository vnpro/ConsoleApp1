using ConverterLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertisseurConsole
{
    class UIConsoleConverter
    {
        void DisplayMenu()
        {
            Console.WriteLine("1 - RomanConverter");
            Console.WriteLine("2 - ASCIIConverter");
        }

        // Display the menu, return the converter
        public Converter GetConverter()
        {
            DisplayMenu();

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    return new RomanConverter();
                    break;
                case "2":
                    return new ASCIIConverter();
                    break;
                default:
                    return GetConverter();
                    break;
            }
        }
    }
}
