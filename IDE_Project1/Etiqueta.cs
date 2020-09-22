using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IDE_Project1
{
    class Etiqueta
    {
        public Etiqueta(int Fila, int Columna)
        {
            this.Fila = Fila;
            this.Columna = Columna;
        } 
        public int Fila { get; set; }
        public int Columna { get; set; }
        //Se muestran los valores de la fila y columna en la que nos encontramos en la etiqueta
        internal void verFilaColumna(Label label_FilaColumna)
        {
            label_FilaColumna.Text = "Fila: " + this.Fila + " Columna: " + this.Columna;
        }
    }
}
