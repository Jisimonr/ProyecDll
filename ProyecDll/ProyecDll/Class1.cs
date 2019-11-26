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
    }
}
