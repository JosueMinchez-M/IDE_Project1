namespace IDE_Project1
{
    partial class IDE_Project1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IDE_Project1));
            this.rtb_escribirCodigo = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_FilaColumna = new System.Windows.Forms.Label();
            this.rtb_Errores = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_archivoCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_archivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_archivoEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_archivoCerrarProyecto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.label_mostarProyecto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ExportarErrores = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_escribirCodigo
            // 
            this.rtb_escribirCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_escribirCodigo.Location = new System.Drawing.Point(12, 28);
            this.rtb_escribirCodigo.Name = "rtb_escribirCodigo";
            this.rtb_escribirCodigo.Size = new System.Drawing.Size(776, 251);
            this.rtb_escribirCodigo.TabIndex = 1;
            this.rtb_escribirCodigo.Text = "";
            this.rtb_escribirCodigo.TextChanged += new System.EventHandler(this.rtb_escribirCodigo_TextChanged);
            this.rtb_escribirCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtb_escribirCodigo_Key);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(713, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Compilar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_FilaColumna
            // 
            this.label_FilaColumna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_FilaColumna.AutoSize = true;
            this.label_FilaColumna.Location = new System.Drawing.Point(12, 282);
            this.label_FilaColumna.Name = "label_FilaColumna";
            this.label_FilaColumna.Size = new System.Drawing.Size(0, 13);
            this.label_FilaColumna.TabIndex = 3;
            // 
            // rtb_Errores
            // 
            this.rtb_Errores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Errores.Location = new System.Drawing.Point(12, 298);
            this.rtb_Errores.Name = "rtb_Errores";
            this.rtb_Errores.Size = new System.Drawing.Size(776, 92);
            this.rtb_Errores.TabIndex = 4;
            this.rtb_Errores.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_archivoCrear,
            this.mi_archivoAbrir,
            this.mi_archivoEliminar,
            this.toolStripSeparator1,
            this.mi_archivoCerrarProyecto});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mi_archivoCrear
            // 
            this.mi_archivoCrear.Name = "mi_archivoCrear";
            this.mi_archivoCrear.Size = new System.Drawing.Size(180, 22);
            this.mi_archivoCrear.Text = "Crear";
            this.mi_archivoCrear.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // mi_archivoAbrir
            // 
            this.mi_archivoAbrir.Name = "mi_archivoAbrir";
            this.mi_archivoAbrir.Size = new System.Drawing.Size(180, 22);
            this.mi_archivoAbrir.Text = "Abrir";
            this.mi_archivoAbrir.Click += new System.EventHandler(this.abrirToolStripMenuItem1_Click);
            // 
            // mi_archivoEliminar
            // 
            this.mi_archivoEliminar.Name = "mi_archivoEliminar";
            this.mi_archivoEliminar.Size = new System.Drawing.Size(180, 22);
            this.mi_archivoEliminar.Text = "Eliminar";
            this.mi_archivoEliminar.Click += new System.EventHandler(this.mi_archivoEliminar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mi_archivoCerrarProyecto
            // 
            this.mi_archivoCerrarProyecto.Name = "mi_archivoCerrarProyecto";
            this.mi_archivoCerrarProyecto.Size = new System.Drawing.Size(180, 22);
            this.mi_archivoCerrarProyecto.Text = "Cerrar Proyecto";
            this.mi_archivoCerrarProyecto.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem4.Text = "Editar";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem5.Image")));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(41, 20);
            this.toolStripMenuItem5.Text = "  ";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // label_mostarProyecto
            // 
            this.label_mostarProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_mostarProyecto.AutoSize = true;
            this.label_mostarProyecto.Location = new System.Drawing.Point(640, 9);
            this.label_mostarProyecto.Name = "label_mostarProyecto";
            this.label_mostarProyecto.Size = new System.Drawing.Size(0, 13);
            this.label_mostarProyecto.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usando Proyecto:";
            // 
            // btn_ExportarErrores
            // 
            this.btn_ExportarErrores.Location = new System.Drawing.Point(12, 404);
            this.btn_ExportarErrores.Name = "btn_ExportarErrores";
            this.btn_ExportarErrores.Size = new System.Drawing.Size(106, 23);
            this.btn_ExportarErrores.TabIndex = 8;
            this.btn_ExportarErrores.Text = "Exportar Errores";
            this.btn_ExportarErrores.UseVisualStyleBackColor = true;
            this.btn_ExportarErrores.Click += new System.EventHandler(this.btn_ExportarErrores_Click);
            // 
            // IDE_Project1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ExportarErrores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_mostarProyecto);
            this.Controls.Add(this.rtb_Errores);
            this.Controls.Add(this.label_FilaColumna);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtb_escribirCodigo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "IDE_Project1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDE_Project1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtb_escribirCodigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_FilaColumna;
        private System.Windows.Forms.RichTextBox rtb_Errores;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_archivoCrear;
        private System.Windows.Forms.ToolStripMenuItem mi_archivoAbrir;
        private System.Windows.Forms.ToolStripMenuItem mi_archivoEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mi_archivoCerrarProyecto;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Label label_mostarProyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ExportarErrores;
    }
}

