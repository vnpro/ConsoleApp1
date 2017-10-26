using ConverterLibrary;
using System;

namespace ConvertisseurConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            UIConsoleConverter ui = new UIConsoleConverter();

            Converter converter = ui.GetConverter();

            var input = "";

            while (!input.Equals("q"))
            {
                Console.WriteLine("digit ? - q to quit -");
                input = Console.ReadLine();
                if (input.Equals("q")) { return; }
                Console.WriteLine("Converted : " + converter.Convert(Int32.Parse(input)));
            }

        }
    }
}
