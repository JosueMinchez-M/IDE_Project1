using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace IDE_Project1
{
    class Cadena
    {
        String[] boleanos = {"verdadero", "falso"};
        String[] palabraReservada = { "SI", "SINO_SI", "MIENTRAS", "HACER", "DESDE", "HASTA", "INCREMENTO", };
        internal void caracterCadena(System.Windows.Forms.RichTextBox rtb_escribirCodigo)
        {
            for (int i = 0; i < rtb_escribirCodigo.Text.Length; i++)
            {
                char[] caracterTexto = rtb_escribirCodigo.Text.ToCharArray();
                int index = i;
                int length = caracterTexto.Length;
                rtb_escribirCodigo.Select(index, length);
                char caracterExaminar = caracterTexto[i];
                //MessageBox.Show(Convert.ToString(caracterExaminar));
                colorCaracter(rtb_escribirCodigo, caracterExaminar);
                colorearCadenaEspecificada(rtb_escribirCodigo, "\"", Color.Gray);
                colorearCadenaEspecificada(rtb_escribirCodigo, "==", Color.DarkBlue);
                colorearCadenaEspecificada(rtb_escribirCodigo, ">=", Color.DarkBlue);
                colorearCadenaEspecificada(rtb_escribirCodigo, "<=", Color.DarkBlue);
                colorearCadenaEspecificada(rtb_escribirCodigo, "!=", Color.DarkBlue);
                colorearCadenaEspecificada(rtb_escribirCodigo, "//", Color.Red);
                colorearCadenaEspecificada(rtb_escribirCodigo, "/*", Color.Red);
                colorearCadenaEspecificada(rtb_escribirCodigo, "*/", Color.Red);

            }
            pintarPalabrasReservadas(rtb_escribirCodigo);
            colorearBooleanos(rtb_escribirCodigo);
        }

        public void colorCaracter(System.Windows.Forms.RichTextBox rtb_escribirCodigo, char caracterTexto)
        {
            int codigoAscii = Convert.ToInt32(caracterTexto);
            rtb_escribirCodigo.SelectionColor = Color.Black;
            //Se examina el caracter por medio de ASCII para las letras
            if ((codigoAscii >= 65 && codigoAscii <= 90) || (codigoAscii >= 97 && codigoAscii <= 122))
            {
                //MessageBox.Show(Convert.ToString(caracterTexto));
                rtb_escribirCodigo.SelectionColor = Color.Gray;
            //Se examinan los caracteres por medio de ASCII para los números
            }else if (codigoAscii >= 48 && codigoAscii <= 57)
            {
                //rtb_escribirCodigo.Select(index, length);
                rtb_escribirCodigo.SelectionColor = Color.Purple;
            //Se examinan los caracteres por medio de ASCII para los Operadores Aritmeticos
            }
            else if (codigoAscii == 43 || codigoAscii == 45 || codigoAscii == 42 || codigoAscii == 47)
            {
                //rtb_escribirCodigo.Select(index, length);
                rtb_escribirCodigo.SelectionColor = Color.DarkBlue;
            //Se examinan los caracteres por medio de ASCII para los Operadores Relacionales
            }
            else if (codigoAscii == 60 || codigoAscii == 62)
            {
                //rtb_escribirCodigo.Select(index, length);
                rtb_escribirCodigo.SelectionColor = Color.DarkBlue;
            //Se examinan los caracteres por medio de ASCII para los Operadores Logicos
            }
            else if (codigoAscii == 124 || codigoAscii == 38 || codigoAscii == 33)
            {
                //rtb_escribirCodigo.Select(index, length);
                rtb_escribirCodigo.SelectionColor = Color.DarkBlue;
            //Se examinan los caracteres por medio de ASCII para los Signos de Agrupacion
            }
            else if (codigoAscii >= 40 && codigoAscii <= 41)
            {
                //rtb_escribirCodigo.Select(index, length);
                rtb_escribirCodigo.SelectionColor = Color.DarkBlue;
            //Se examinan los caracteres por medio de ASCII para los Asignacion y Fin de sentencia
            }
            else if (codigoAscii == 61 || codigoAscii == 59)
            {
                //rtb_escribirCodigo.Select(index, length);
                //MessageBox.Show(Convert.ToString(caracterTexto));
                rtb_escribirCodigo.SelectionColor = Color.Pink;
                //Se examina el caracter punto (.)
            }
            else if (codigoAscii == 46)
            {
                //rtb_escribirCodigo.Select(index, length);
                rtb_escribirCodigo.SelectionColor = Color.LightBlue;
                //Se examina el caracter comillas (")
            }
            else if (codigoAscii == 34)
            {
                //rtb_escribirCodigo.Select(index, length);
                rtb_escribirCodigo.SelectionColor = Color.Gray;
            }
        }

        public void colorearCadenaEspecificada(System.Windows.Forms.RichTextBox rtb_escribirCodigo, string phrase, Color color)
        {
            int pos = rtb_escribirCodigo.SelectionStart;
            string s = rtb_escribirCodigo.Text;
            for (int ix = 0; ;)
            {
                int jx = s.IndexOf(phrase, ix);
                if (jx < 0) break;
                rtb_escribirCodigo.SelectionStart = jx;
                rtb_escribirCodigo.SelectionLength = phrase.Length;
                rtb_escribirCodigo.SelectionColor = color;
                ix = jx + 1;
            }
            rtb_escribirCodigo.SelectionStart = pos;
            rtb_escribirCodigo.SelectionLength = 0;
        }
        public void pintarPalabrasReservadas(System.Windows.Forms.RichTextBox rtb_escribirCodigo)
        {
            for (int i = 0; i < palabraReservada.Length; i++)
            {
                colorearCadenaEspecificada(rtb_escribirCodigo, palabraReservada[i], Color.Green);
            }
        }

        public void colorearBooleanos(System.Windows.Forms.RichTextBox rtb_escribirCodigo)
        {
            for (int i = 0; i < boleanos.Length; i++)
            {
                colorearCadenaEspecificada(rtb_escribirCodigo, boleanos[i], Color.Orange);
            }
        }
    }
}
