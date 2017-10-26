using System;
using System.Collections.Generic;

namespace ConverterLibrary
{
    interface IConverter
    {
        String  Convert(int digit);
        void    Initialize();
    }

    public class Converter : IConverter
    {
        protected Dictionary<int, String> dico = new Dictionary<int, String>();

        public Converter() {}

        public string Convert(int digit)
        {
            return dico[digit];
        }

        public virtual void Initialize() {}
    }

    public class ASCIIConverter : Converter
    {
        public ASCIIConverter()
        {
            Initialize();
        }

        public override void Initialize()
        {
            dico.Add(48, "0");
            dico.Add(65, "A");
            dico.Add(97, "a");
        }
    }

    public class RomanConverter : Converter
    {
        public RomanConverter()
        {
            Initialize();
        }

        public void Initialize()
        {
            dico.Add(0, "0");
            dico.Add(1, "I");
            dico.Add(2, "II");
            dico.Add(3, "III");
            dico.Add(4, "IV");
            dico.Add(5, "V");
            dico.Add(6, "VI");
            dico.Add(7, "VII");
            dico.Add(8, "VIII");
            dico.Add(9, "IX");
            dico.Add(10, "X");
            dico.Add(11, "XI");
            dico.Add(12, "XII");
        }
    }
}
