namespace Ejercicio6Form
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
            texto = new Label();
            lista = new ListBox();
            botonAgregar = new Button();
            botonEliminar = new Button();
            botonContar = new Button();
            botonVerNombres = new Button();
            SuspendLayout();
            // 
            // texto
            // 
            texto.AutoSize = true;
            texto.Location = new Point(216, 35);
            texto.Name = "texto";
            texto.Size = new Size(278, 50);
            texto.TabIndex = 0;
            texto.Text = "Ingenieros forestales acreditados \r\npara trabajar en la empresa\r\n";
            texto.Click += label1_Click;
            // 
            // lista
            // 
            lista.FormattingEnabled = true;
            lista.ItemHeight = 25;
            lista.Location = new Point(232, 106);
            lista.Name = "lista";
            lista.Size = new Size(225, 179);
            lista.TabIndex = 1;
            // 
            // botonAgregar
            // 
            botonAgregar.Location = new Point(232, 313);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(112, 34);
            botonAgregar.TabIndex = 2;
            botonAgregar.Text = "Agregar";
            botonAgregar.UseVisualStyleBackColor = true;
            botonAgregar.Click += botonAgregar_Click;
            // 
            // botonEliminar
            // 
            botonEliminar.Location = new Point(350, 313);
            botonEliminar.Name = "botonEliminar";
            botonEliminar.Size = new Size(107, 34);
            botonEliminar.TabIndex = 3;
            botonEliminar.Text = "Eliminar";
            botonEliminar.UseVisualStyleBackColor = true;
            botonEliminar.Click += botonEliminar_Click;
            // 
            // botonContar
            // 
            botonContar.Location = new Point(232, 365);
            botonContar.Name = "botonContar";
            botonContar.Size = new Size(96, 34);
            botonContar.TabIndex = 4;
            botonContar.Text = "Contar";
            botonContar.UseVisualStyleBackColor = true;
            botonContar.Click += botonContar_Click;
            // 
            // botonVerNombres
            // 
            botonVerNombres.Location = new Point(334, 365);
            botonVerNombres.Name = "botonVerNombres";
            botonVerNombres.Size = new Size(123, 34);
            botonVerNombres.TabIndex = 5;
            botonVerNombres.Text = "Ver nombres";
            botonVerNombres.UseVisualStyleBackColor = true;
            botonVerNombres.Click += botonVerNombres_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botonVerNombres);
            Controls.Add(botonContar);
            Controls.Add(botonEliminar);
            Controls.Add(botonAgregar);
            Controls.Add(lista);
            Controls.Add(texto);
            Name = "Form1";
            Text = "Ingenieros Forestales";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label texto;
        private ListBox lista;
        private Button botonAgregar;
        private Button botonEliminar;
        private Button botonContar;
        private Button botonVerNombres;
    }
}
