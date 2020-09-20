using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE_Project1
{
    class Automata
    {
        // 25, 10
        int[,] resumen = new int[26, 10]{
            {1,2,3,4,5,6,7,8,9,0},
            {1,10,3,4,25,25,25,25,25,0},
            {11,12,3,4,25,13,25,25,25,0},
            {11,2,3,4,25,25,25,25,9,0},
            {25,25,14,25,25,25,25,25,25,0},
            {15,16,17,18,9,20,21,22,23,0},
            {25,25,25,25,19,6,25,25,9,0},
            {25,25,25,25,25,25,7,8,9,0},
            {25,25,25,25,25,25,25,8,9,0},
            {25,25,3,25,5,25,25,25,9,0},
            {11,10,3,4,25,25,25,25,25,0},
            {11,25,25,25,25,25,25,25,25,0},
            {11,12,3,4,25,13,25,25,25,0},
            {25,24,25,25,25,13,25,25,25,0},
            {25,25,14,4,25,25,25,25,9,0},
            {15,16,17,18,19,20,21,22,23,0},
            {15,16,17,18,19,20,21,22,23,0},
            {15,16,17,18,19,20,21,22,23,0},
            {15,16,17,18,19,20,21,22,23,0},
            {25,25,25,25,25,25,25,25,19,0},
            {15,16,17,18,19,20,21,22,23,0},
            {15,16,17,18,19,20,21,22,23,0},
            {15,16,17,18,19,20,21,22,23,0},
            {15,16,17,18,19,20,21,22,23,0},
            {25,24,25,25,25,25,25,25,25,0},
            {0,0,0,0,0,0,0,0,0,0}};

        internal void automataActivado(RichTextBox rtb_escribirCodigo)
        {   //Con este for se verifica el numero de linea el cual estamos manejando
            for (int i = 0; i < rtb_escribirCodigo.Lines.Length; i++)
            {
                String linea = rtb_escribirCodigo.Lines[i];
                String[] cadenaLinea = linea.Split(' ');
                //String [] cadenaLinea = rtb_escribirCodigo.Lines[i].Split(' ');
                //En este for verificamos las cadenas que contiene la Linea que se verifica
                for (int a = 0; a < cadenaLinea.Length; a++)
                {
                    String cadena = cadenaLinea[a];
                    //caracterCadena = cadena.ToCharArray();
                    inicio(cadena, rtb_escribirCodigo);
                    //rtb_escribirCodigo.SelectionColor = Color.Red;
                    //rtb_escribirCodigo.SelectionStart = rtb_escribirCodigo.Text.Length;
                }
            }
        }

        private void inicio(String cadena, RichTextBox rtb_escribirCodigo)
        {
            //contador = 0;
            //Z0();
            int i;
            char[] caracterCadena;
            int estado, caracter;
            i = 0;
            estado = 0;
            caracter = 0;
            caracterCadena = cadena.ToCharArray();

            while (i < caracterCadena.Length)
            {
                int codigoAscii = Convert.ToInt32(caracterCadena[i]);
                //Se examina el caracter por medio de ASCII para las letras
                if (codigoAscii == 32 ||(codigoAscii >= 65 && codigoAscii <= 90) || (codigoAscii >= 97 && codigoAscii <= 122))
                {
                    caracter = 5;
                //Se examinan los caracteres por medio de ASCII para los números
                }else if (codigoAscii >= 48 && codigoAscii <= 57)
                {
                    caracter = 2;
                //Se examinan los caracteres por medio de ASCII para los Operadores Aritmeticos
                }else if (codigoAscii == 43 || codigoAscii == 45 || codigoAscii == 42 || codigoAscii == 47)
                {
                    caracter = 1;
                 //Se examinan los caracteres por medio de ASCII para los Operadores Relacionales
                }else if (codigoAscii == 60 || codigoAscii == 62)
                {
                    caracter = 6;
                //Se examinan los caracteres por medio de ASCII para los Operadores Logicos
                } else if (codigoAscii == 124 || codigoAscii == 38 || codigoAscii == 33)
                {
                    caracter = 7;
                //Se examinan los caracteres por medio de ASCII para los Signos de Agrupacion
                }else if (codigoAscii >= 40 && codigoAscii <= 41)
                {
                    caracter = 0;
                //Se examinan los caracteres por medio de ASCII para los Asignacion y Fin de sentencia
                }else if (codigoAscii == 61 || codigoAscii == 59)
                {
                    caracter = 8;
                //Se examina el caracter punto (.)
                }else if (codigoAscii == 46)
                {
                    caracter = 3;
                //Se examina el caracter comillas (")
                }else if (codigoAscii == 34)
                {
                    caracter = 4;
                }
                else
                {
                    caracter = 9;
                }
                Console.WriteLine(estado + " y " + caracter);
                estado = resumen[estado, caracter];
                i++;
            }
            if (estado == 1| estado == 2|| estado == 3 || estado == 6 || estado == 7 || estado == 8 
                || estado == 9 || estado == 10 || estado == 11 || estado == 12 || estado == 13 || estado == 14
                || estado == 19 || estado == 24 || estado == 20)
            {
                MessageBox.Show("Cadena fue aceptada " + cadena);
            }
            else
            {
                MessageBox.Show("No fue aceptada " + cadena);
            }

        }

        public void cadenaPintada(RichTextBox rtb_escribirCodigo)
        {
        }
    }
}
