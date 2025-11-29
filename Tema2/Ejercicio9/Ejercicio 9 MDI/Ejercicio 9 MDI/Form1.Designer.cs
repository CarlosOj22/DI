namespace Ejercicio_9_MDI
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
            menuDeOpciones = new MenuStrip();
            menuDeOpcionesNuevo = new ToolStripMenuItem();
            menuDeOpcionesVentana = new ToolStripMenuItem();
            menuDeOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // menuDeOpciones
            // 
            menuDeOpciones.ImageScalingSize = new Size(24, 24);
            menuDeOpciones.Items.AddRange(new ToolStripItem[] { menuDeOpcionesNuevo, menuDeOpcionesVentana });
            menuDeOpciones.Location = new Point(0, 0);
            menuDeOpciones.Name = "menuDeOpciones";
            menuDeOpciones.Size = new Size(800, 33);
            menuDeOpciones.TabIndex = 1;
            menuDeOpciones.Text = "menuStrip1";
            // 
            // menuDeOpcionesNuevo
            // 
            menuDeOpcionesNuevo.Name = "menuDeOpcionesNuevo";
            menuDeOpcionesNuevo.Size = new Size(80, 29);
            menuDeOpcionesNuevo.Text = "Nuevo";
            menuDeOpcionesNuevo.Click += menuDeOpcionesNuevo_Click;
            // 
            // menuDeOpcionesVentana
            // 
            menuDeOpcionesVentana.Name = "menuDeOpcionesVentana";
            menuDeOpcionesVentana.Size = new Size(91, 29);
            menuDeOpcionesVentana.Text = "Ventana";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuDeOpciones);
            IsMdiContainer = true;
            MainMenuStrip = menuDeOpciones;
            Name = "Form1";
            Text = "Form1";
            menuDeOpciones.ResumeLayout(false);
            menuDeOpciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuDeOpciones;
        private ToolStripMenuItem menuDeOpcionesNuevo;
        private ToolStripMenuItem menuDeOpcionesVentana;
    }
}
