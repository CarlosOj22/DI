namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuOpciones = new MenuStrip();
            menuOpcionesArchivo = new ToolStripMenuItem();
            menuOpcionesArchivoSalir = new ToolStripMenuItem();
            menuOpcionesOperaciones = new ToolStripMenuItem();
            menuOpcionesOperacionesSuma = new ToolStripMenuItem();
            menuOpcionesOperacionesMultiplicacion = new ToolStripMenuItem();
            menuOpcionesOperacionesResta = new ToolStripMenuItem();
            menuOpcionesOperacionesDivision = new ToolStripMenuItem();
            menuOpcionesAyuda = new ToolStripMenuItem();
            txt1 = new TextBox();
            menuContextual1 = new ContextMenuStrip(components);
            menuContextual1Borrar = new ToolStripMenuItem();
            menuContextual1Iniciar = new ToolStripMenuItem();
            menuContextual1Aleatorio = new ToolStripMenuItem();
            txt2 = new TextBox();
            txtResultado = new TextBox();
            btnOperacion = new Button();
            menuOpciones.SuspendLayout();
            menuContextual1.SuspendLayout();
            SuspendLayout();
            // 
            // menuOpciones
            // 
            menuOpciones.ImageScalingSize = new Size(24, 24);
            menuOpciones.Items.AddRange(new ToolStripItem[] { menuOpcionesArchivo, menuOpcionesOperaciones, menuOpcionesAyuda });
            menuOpciones.Location = new Point(0, 0);
            menuOpciones.Name = "menuOpciones";
            menuOpciones.Size = new Size(800, 33);
            menuOpciones.TabIndex = 0;
            menuOpciones.Text = "menuStrip1";
            // 
            // menuOpcionesArchivo
            // 
            menuOpcionesArchivo.DropDownItems.AddRange(new ToolStripItem[] { menuOpcionesArchivoSalir });
            menuOpcionesArchivo.Name = "menuOpcionesArchivo";
            menuOpcionesArchivo.Size = new Size(88, 29);
            menuOpcionesArchivo.Text = "Archivo";
            // 
            // menuOpcionesArchivoSalir
            // 
            menuOpcionesArchivoSalir.Name = "menuOpcionesArchivoSalir";
            menuOpcionesArchivoSalir.ShortcutKeys = Keys.Control | Keys.Alt | Keys.S;
            menuOpcionesArchivoSalir.Size = new Size(270, 34);
            menuOpcionesArchivoSalir.Text = "Salir";
            menuOpcionesArchivoSalir.Click += menuOpcionesArchivoSalir_Click;
            // 
            // menuOpcionesOperaciones
            // 
            menuOpcionesOperaciones.DropDownItems.AddRange(new ToolStripItem[] { menuOpcionesOperacionesSuma, menuOpcionesOperacionesMultiplicacion, menuOpcionesOperacionesResta, menuOpcionesOperacionesDivision });
            menuOpcionesOperaciones.Name = "menuOpcionesOperaciones";
            menuOpcionesOperaciones.Size = new Size(127, 29);
            menuOpcionesOperaciones.Text = "Operaciones";
            // 
            // menuOpcionesOperacionesSuma
            // 
            menuOpcionesOperacionesSuma.CheckOnClick = true;
            menuOpcionesOperacionesSuma.Name = "menuOpcionesOperacionesSuma";
            menuOpcionesOperacionesSuma.Size = new Size(270, 34);
            menuOpcionesOperacionesSuma.Text = "Suma";
            menuOpcionesOperacionesSuma.Click += menuOpcionesOperacionesSuma_Click;
            // 
            // menuOpcionesOperacionesMultiplicacion
            // 
            menuOpcionesOperacionesMultiplicacion.CheckOnClick = true;
            menuOpcionesOperacionesMultiplicacion.Name = "menuOpcionesOperacionesMultiplicacion";
            menuOpcionesOperacionesMultiplicacion.Size = new Size(270, 34);
            menuOpcionesOperacionesMultiplicacion.Text = "Multiplicación";
            menuOpcionesOperacionesMultiplicacion.Click += menuOpcionesOperacionesMultiplicacion_Click;
            // 
            // menuOpcionesOperacionesResta
            // 
            menuOpcionesOperacionesResta.CheckOnClick = true;
            menuOpcionesOperacionesResta.Name = "menuOpcionesOperacionesResta";
            menuOpcionesOperacionesResta.Size = new Size(270, 34);
            menuOpcionesOperacionesResta.Text = "Resta";
            menuOpcionesOperacionesResta.Click += menuOpcionesOperacionesResta_Click;
            // 
            // menuOpcionesOperacionesDivision
            // 
            menuOpcionesOperacionesDivision.CheckOnClick = true;
            menuOpcionesOperacionesDivision.Name = "menuOpcionesOperacionesDivision";
            menuOpcionesOperacionesDivision.Size = new Size(270, 34);
            menuOpcionesOperacionesDivision.Text = "División";
            menuOpcionesOperacionesDivision.Click += menuOpcionesOperacionesDivision_Click;
            // 
            // menuOpcionesAyuda
            // 
            menuOpcionesAyuda.Name = "menuOpcionesAyuda";
            menuOpcionesAyuda.Size = new Size(79, 29);
            menuOpcionesAyuda.Text = "Ayuda";
            menuOpcionesAyuda.Click += menuOpcionesAyuda_Click;
            // 
            // txt1
            // 
            txt1.ContextMenuStrip = menuContextual1;
            txt1.Location = new Point(51, 135);
            txt1.Name = "txt1";
            txt1.Size = new Size(150, 31);
            txt1.TabIndex = 1;
            txt1.MouseHover += txt1_MouseHover;
            // 
            // menuContextual1
            // 
            menuContextual1.ImageScalingSize = new Size(24, 24);
            menuContextual1.Items.AddRange(new ToolStripItem[] { menuContextual1Borrar, menuContextual1Iniciar, menuContextual1Aleatorio });
            menuContextual1.Name = "menuContextual1";
            menuContextual1.Size = new Size(184, 100);
            // 
            // menuContextual1Borrar
            // 
            menuContextual1Borrar.Name = "menuContextual1Borrar";
            menuContextual1Borrar.Size = new Size(183, 32);
            menuContextual1Borrar.Text = "Borrar";
            menuContextual1Borrar.Click += menuContextual1Borrar_Click;
            // 
            // menuContextual1Iniciar
            // 
            menuContextual1Iniciar.Name = "menuContextual1Iniciar";
            menuContextual1Iniciar.Size = new Size(183, 32);
            menuContextual1Iniciar.Text = "Iniciar a cero";
            menuContextual1Iniciar.Click += menuContextual1Iniciar_Click;
            // 
            // menuContextual1Aleatorio
            // 
            menuContextual1Aleatorio.Name = "menuContextual1Aleatorio";
            menuContextual1Aleatorio.Size = new Size(183, 32);
            menuContextual1Aleatorio.Text = "Aleatorio";
            menuContextual1Aleatorio.Click += menuContextual1Aleatorio_Click;
            // 
            // txt2
            // 
            txt2.ContextMenuStrip = menuContextual1;
            txt2.Location = new Point(51, 264);
            txt2.Name = "txt2";
            txt2.Size = new Size(150, 31);
            txt2.TabIndex = 2;
            txt2.MouseHover += txt2_MouseHover;
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(51, 343);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(150, 31);
            txtResultado.TabIndex = 3;
            // 
            // btnOperacion
            // 
            btnOperacion.Location = new Point(90, 207);
            btnOperacion.Name = "btnOperacion";
            btnOperacion.Size = new Size(60, 26);
            btnOperacion.TabIndex = 4;
            btnOperacion.UseVisualStyleBackColor = true;
            btnOperacion.Visible = false;
            btnOperacion.Click += btnOperacion_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOperacion);
            Controls.Add(txtResultado);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(menuOpciones);
            MainMenuStrip = menuOpciones;
            Name = "Form1";
            Text = "Form1";
            menuOpciones.ResumeLayout(false);
            menuOpciones.PerformLayout();
            menuContextual1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuOpciones;
        private ToolStripMenuItem menuOpcionesArchivo;
        private ToolStripMenuItem menuOpcionesArchivoSalir;
        private ToolStripMenuItem menuOpcionesOperaciones;
        private ToolStripMenuItem menuOpcionesOperacionesSuma;
        private ToolStripMenuItem menuOpcionesOperacionesResta;
        private ToolStripMenuItem menuOpcionesOperacionesMultiplicacion;
        private ToolStripMenuItem menuOpcionesOperacionesDivision;
        private ToolStripMenuItem menuOpcionesAyuda;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txtResultado;
        private Button btnOperacion;
        private ContextMenuStrip menuContextual1;
        private ToolStripMenuItem menuContextual1Borrar;
        private ToolStripMenuItem menuContextual1Iniciar;
        private ToolStripMenuItem menuContextual1Aleatorio;
    }
}
