using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE_Project1
{
    class Automata
    {
        String[] N = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "-1", "-2", "-3", "-4", "-5", "-6", "-7", "-8", "-9"};
        String[] OA = {"+", "-", "*", "/", "++", "--"};
        internal void automataActivado(RichTextBox rtb_escribirCodigo)
        {   //Con este for se verifica el numero de linea el cual estamos manejando
            for (int i = 0; i < rtb_escribirCodigo.Lines.Length - 1; i++)
            {
                String linea = rtb_escribirCodigo.Lines[i];
                String[] cadenaLinea = linea.Split(' ');
                //String [] cadenaLinea = rtb_escribirCodigo.Lines[i].Split(' ');
                //En este for verificamos las cadenas que contiene la Linea que se verifica
                for (int a = 0; a < cadenaLinea.Length; a++)
                {
                    String cadena = cadenaLinea[a];
                    for (int b = 0; b < cadena.Length; b++)
                    {
                        char caracter = cadena[b];
                        
                    }
                }
            }
        }
    }
}
