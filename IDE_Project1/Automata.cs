using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IDE_Project1
{
    class Estado
    {
        public void estadosNumeros(String cadena)
        {
            for (int i = 0; i < cadena.Length; i++)
            {

            }
        }
        public void estadoB(String cadena)
        {
            //B es estado de Aceptación
            //Tokens: Secuencia de caracteres que tienen un significado
            String[] B = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "-1", "-2", "-3", "-4", "-5", "-6", "-7", "-8", "-9"," "};
            //Aqui se examina los caracteres que contiene la cadena
            for (int i = 0; i < cadena.Length; i++)
            {
                char caracter = cadena[i];
                //Aqui se examina cada caracter de la cadena con el array de números
                for (int a = 0; a < B.Length; a++)
                {
                    if (B[a].Equals(caracter))
                    {
                        //Se acepta el caracter porque se encuentra en el conjunto de posibilidades
                        if (a == B.Length - 1)
                        {
                            Color morado = Color.Purple;
                        }
                    }
                    else
                    {
                        //No se acepta el caracter porque no se encuentra en el conjunto de posibilidades
                        //usamos el metodo estadoErrores()

                    }
                }
            }
        }
        public void estadoErrores()
        {

        }
    }
}
