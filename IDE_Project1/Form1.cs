using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Documents;
using System.Security.Policy;

namespace IDE_Project1
{
    public partial class IDE_Project1 : Form
    {
        public IDE_Project1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Se obtiene el numero de filas y columnas
        public void datoEtiquetaTeclado()
        {
            // Obtenemos la Fila 
            int indice = rtb_escribirCodigo.SelectionStart;
            Console.WriteLine(indice);
            int fila = rtb_escribirCodigo.GetLineFromCharIndex(indice);
            // Obtenemos la Columna
            int primerCaracter = rtb_escribirCodigo.GetFirstCharIndexFromLine(fila);
            Console.WriteLine(primerCaracter);
            int columna = indice - primerCaracter;
            Etiqueta etiqueta = new Etiqueta(fila, columna);
            etiqueta.verFilaColumna(label_FilaColumna);
        }
        //Una prueba con el raton
        public void datoEtiquetaRaton(int indice)
        {
            // Obtenemos la Fila 
            //int indice = rtb_escribirCodigo.SelectionStart;
            Console.WriteLine(indice);
            int fila = rtb_escribirCodigo.GetLineFromCharIndex(indice);
            // Obtenemos la Columna
            int primerCaracter = rtb_escribirCodigo.GetFirstCharIndexFromLine(fila);
            Console.WriteLine(primerCaracter);
            int columna = indice - primerCaracter;
            Etiqueta etiquetaRaton = new Etiqueta(fila, columna);
            etiquetaRaton.verFilaColumna(label_FilaColumna);
        }
        /*Con este Método se determina la ETIQUETA donde está el No. de fila y columna
         en la que se encuentra el cursor de Texto al momento de escribir cada caracter*/
        private void rtb_escribirCodigo_TextChanged(object sender, EventArgs e)
        {
            datoEtiquetaTeclado();
        }
        /*Con este Método también se determina la ETIQUETA donde está el No. de fila y columna 
          en la que se encuentra el cursor de Texto pero identificado con las teclas
          up, down, left, rigth */
        private void rtb_escribirCodigo_Key(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                datoEtiquetaTeclado();
            }else if (e.KeyCode == Keys.Down)
            {
                datoEtiquetaTeclado();
            }
            else if (e.KeyCode == Keys.Right)
            {
                datoEtiquetaTeclado();
            }
            else if (e.KeyCode == Keys.Left)
            {
                datoEtiquetaTeclado();
            }
        }
        //Una prueba con el raton
        private void rtb_escribirCodigo_MouseDown(object sender, MouseEventArgs e)
        {
            datoEtiquetaRaton(e.X);
            //label_FilaColumna.Text = "Fila: " + e.X + " Columna: " + e.Y;
        }
    }
}
