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
        String path;
        internal void crearArchivo(System.Windows.Forms.RichTextBox rtb_escribirCodigo, System.Windows.Forms.Label label_mostarProyecto)
        {
            rtb_escribirCodigo.ReadOnly = false;
            path = "";
            System.Windows.Forms.SaveFileDialog guardarArchivo = new System.Windows.Forms.SaveFileDialog();
            guardarArchivo.Filter = "gt files (*.gt)|*.gt"; //Text|*.txt|All|*.*
            if (guardarArchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = guardarArchivo.FileName;
                mostrarNombreProyecto(path, label_mostarProyecto);
                StreamWriter sw = new StreamWriter(File.Create(path));
                sw.WriteLine(rtb_escribirCodigo.Text);
                sw.Dispose();
            }
            rtb_escribirCodigo.Text = "";
        }
        //Este metodo se usa para la imagen de guardar, al momento de presionarlo
        //Se ejecuta este metodo que guardara los datos en el archivo en el que estamos
        internal void guardarArchivo(System.Windows.Forms.RichTextBox rtb_escribirCodigo)
        {
            StreamWriter sw = new StreamWriter(File.Create(path));
            sw.WriteLine(rtb_escribirCodigo.Text);
            sw.Dispose();
        }
        internal void abrirArchivo(System.Windows.Forms.RichTextBox rtb_escribirCodigo, System.Windows.Forms.Label label_mostarProyecto)
        {
            rtb_escribirCodigo.ReadOnly = true;
            rtb_escribirCodigo.Text = "";
            String pathArchivo;
            System.Windows.Forms.OpenFileDialog abrirArchivo = new System.Windows.Forms.OpenFileDialog();
            abrirArchivo.Filter = "gt files (*.gt)|*.gt"; //Text|*.txt|All|*.*
            if (abrirArchivo.ShowDialog() == DialogResult.OK)
            {
                //rtb_escribirCodigo.Text = (abrirArchivo.SafeFileName);
                //Se obtiene el path especifico 
                pathArchivo = abrirArchivo.FileName;
                //Con este metodo mostramos el nombre del proyecto en pantalla
                mostrarNombreProyecto(pathArchivo, label_mostarProyecto);
                //Lee el contenido del archivo dentro del programa
                var fileStream = abrirArchivo.OpenFile();
                using (StreamReader leerArchivo = new StreamReader(fileStream))
                {
                    rtb_escribirCodigo.Text = leerArchivo.ReadToEnd();
                }
            }
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
        }
    }
}
