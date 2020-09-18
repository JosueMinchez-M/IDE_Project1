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
using Microsoft.Win32;
using System.Windows.Media.Animation;
using System.IO;
namespace IDE_Project1
{
    public partial class IDE_Project1 : Form
    {
        Archivo archivo = new Archivo();
        Automata automata = new Automata();
        public IDE_Project1()
        {
            InitializeComponent();
            
            rtb_escribirCodigo.ReadOnly = true;
            mi_archivoCerrarProyecto.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //automata.automataActivado(rtb_escribirCodigo);
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
        //public void datoEtiquetaRaton(int indice)
        //{
        //    // Obtenemos la Fila 
        //    //int indice = rtb_escribirCodigo.SelectionStart;
        //    Console.WriteLine(indice);
        //    int fila = rtb_escribirCodigo.GetLineFromCharIndex(indice);
        //    // Obtenemos la Columna
        //    int primerCaracter = rtb_escribirCodigo.GetFirstCharIndexFromLine(fila);
        //    Console.WriteLine(primerCaracter);
        //    int columna = indice - primerCaracter;
        //    Etiqueta etiquetaRaton = new Etiqueta(fila, columna);
        //    etiquetaRaton.verFilaColumna(label_FilaColumna);
        //}
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

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mi_archivoAbrir.Enabled = false;
            mi_archivoCrear.Enabled = false;
            mi_archivoCerrarProyecto.Enabled = true;
            archivo.crearArchivo(rtb_escribirCodigo, label_mostarProyecto);
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mi_archivoAbrir.Enabled = false;
            mi_archivoCrear.Enabled = false;
            mi_archivoCerrarProyecto.Enabled = true;
            archivo.abrirArchivo(rtb_escribirCodigo, label_mostarProyecto);
            MessageBox.Show("******************" + rtb_escribirCodigo.Lines.Length + "********************");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            archivo.guardarArchivo(rtb_escribirCodigo);
        }
        //Método del item CERRAR PROYECTO
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            mi_archivoAbrir.Enabled = true;
            mi_archivoCrear.Enabled = true;
            archivo.guardarArchivo(rtb_escribirCodigo);
            archivo.cerrarProyecto(rtb_escribirCodigo, label_mostarProyecto);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            archivo.editarProyecto(rtb_escribirCodigo);
        }

        private void mi_archivoEliminar_Click(object sender, EventArgs e)
        {
            mi_archivoAbrir.Enabled = true;
            mi_archivoCrear.Enabled = true;
            mi_archivoCerrarProyecto.Enabled = false;
            archivo.eliminarArchivo(rtb_escribirCodigo, label_mostarProyecto);
        }
        //Una prueba con el raton
        //private void rtb_escribirCodigo_MouseDown(object sender, MouseEventArgs e)
        //{
        //  datoEtiquetaRaton(e.X);
        //label_FilaColumna.Text = "Fila: " + e.X + " Columna: " + e.Y;
        //}
    }
}
