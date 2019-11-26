using System;

namespace ProyecDll
{
    public class Class1
    {
        public int ContarPalabras(string texto)
        {
            return texto.Split(' ').Length;
        }

        public string Dametexto(int posicion, string texto)
        {
            string tomatexto = texto.Substring(posicion);
            return "";
        }

        public static bool StartsWithUpper(String str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return false;

            Char ch = str[0];
            return Char.IsUpper(ch);
        }
    }
}
