using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace IDE_Project1
{
    class Archivo
    {
        String path; //Path de crear archivo y general
        Boolean esAbrir = false;
        internal void crearArchivo(System.Windows.Forms.RichTextBox rtb_escribirCodigo, System.Windows.Forms.Label label_mostarProyecto)
        {
            esAbrir = false;
            rtb_escribirCodigo.ReadOnly = false;
            path = "";
            System.Windows.Forms.SaveFileDialog guardarArchivo = new System.Windows.Forms.SaveFileDialog();
            guardarArchivo.Filter = "gt files (*.gt)|*.gt"; //Text|*.txt|All|*.*
            if (guardarArchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = guardarArchivo.FileName;
                mostrarNombreProyecto(path, label_mostarProyecto);
                escribirArchivo(rtb_escribirCodigo);
            }
            rtb_escribirCodigo.Text = "";
        }
        //Este metodo se usa para la imagen de guardar, al momento de presionarlo
        //Se ejecuta este metodo que guardara los datos en el archivo en el que estamos
        internal void guardarArchivo(System.Windows.Forms.RichTextBox rtb_escribirCodigo)
        {
            escribirArchivo(rtb_escribirCodigo);
        }
        internal void abrirArchivo(System.Windows.Forms.RichTextBox rtb_escribirCodigo, System.Windows.Forms.Label label_mostarProyecto)
        {
            rtb_escribirCodigo.ReadOnly = true;
            rtb_escribirCodigo.Text = "";
            String pathAbrirArchivo;
            System.Windows.Forms.OpenFileDialog abrirArchivo = new System.Windows.Forms.OpenFileDialog();
            abrirArchivo.Filter = "gt files (*.gt)|*.gt"; //Text|*.txt|All|*.*
            if (abrirArchivo.ShowDialog() == DialogResult.OK)
            {
                //Se obtiene el path especifico 
                pathAbrirArchivo = abrirArchivo.FileName;
                path = pathAbrirArchivo;
                //Con este metodo mostramos el nombre del proyecto en pantalla
                mostrarNombreProyecto(pathAbrirArchivo, label_mostarProyecto);
                //Lee el contenido del archivo dentro del programa
                var fileStream = abrirArchivo.OpenFile();
                using (StreamReader leerArchivo = new StreamReader(fileStream))
                {
                    rtb_escribirCodigo.Text = leerArchivo.ReadToEnd();
                }
            }
            esAbrir = true;
        }
        //Con este metodo mostramos el nombre del proyecto en pantalla
        private void mostrarNombreProyecto(String path, System.Windows.Forms.Label label_mostarProyecto)
        {
            FileInfo fi = new FileInfo(path);
            String nombreArchivo = Path.GetFileNameWithoutExtension(fi.Name);
            label_mostarProyecto.Text = nombreArchivo;
        }

        internal void cerrarProyecto(System.Windows.Forms.RichTextBox rtb_escribirCodigo, System.Windows.Forms.Label label_mostarProyecto)
        {
            rtb_escribirCodigo.Text = "";
            label_mostarProyecto.Text = "";
            path = "";
            MessageBox.Show("El proyecto se ha cerrado con éxito");
            rtb_escribirCodigo.ReadOnly = true;
            esAbrir = false;
        }

        private void escribirArchivo(System.Windows.Forms.RichTextBox rtb_escribirCodigo)
        {
            try
            {
                StreamWriter sw = new StreamWriter(File.Create(path));
                sw.WriteLine(rtb_escribirCodigo.Text);
                sw.Dispose();
                MessageBox.Show("Cambios Guardados con Exito");
            }
            catch
            {
                MessageBox.Show("No es posible Guardar por el momento");
            }
        }

        internal void editarProyecto(System.Windows.Forms.RichTextBox rtb_escribirCodigo)
        {
            if (esAbrir == true)
            {
                rtb_escribirCodigo.ReadOnly = false;
                MessageBox.Show("Ya puedes editar tu proyecto");
            }
            else
            {
                MessageBox.Show("No es posible editar, no has abierto ningún Proyecto");
            }
        }
    }
}
