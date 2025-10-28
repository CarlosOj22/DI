namespace Ejercicio6Form
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textoNombre = new Label();
            textoPrimerApel = new Label();
            textoSegundoApel = new Label();
            textoTel = new Label();
            cajaNombre = new TextBox();
            cajaPrimerApel = new TextBox();
            cajaSegundoApel = new TextBox();
            cajaTel = new TextBox();
            botonAgregar = new Button();
            botonCancelar = new Button();
            SuspendLayout();
            // 
            // textoNombre
            // 
            textoNombre.AutoSize = true;
            textoNombre.Location = new Point(69, 68);
            textoNombre.Name = "textoNombre";
            textoNombre.Size = new Size(82, 25);
            textoNombre.TabIndex = 0;
            textoNombre.Text = "Nombre:";
            textoNombre.Click += label1_Click;
            // 
            // textoPrimerApel
            // 
            textoPrimerApel.AutoSize = true;
            textoPrimerApel.Location = new Point(69, 108);
            textoPrimerApel.Name = "textoPrimerApel";
            textoPrimerApel.Size = new Size(138, 25);
            textoPrimerApel.TabIndex = 1;
            textoPrimerApel.Text = "Primer Apellido:";
            textoPrimerApel.Click += label2_Click;
            // 
            // textoSegundoApel
            // 
            textoSegundoApel.AutoSize = true;
            textoSegundoApel.Location = new Point(69, 152);
            textoSegundoApel.Name = "textoSegundoApel";
            textoSegundoApel.Size = new Size(159, 25);
            textoSegundoApel.TabIndex = 2;
            textoSegundoApel.Text = "Segundo Apellido:";
            // 
            // textoTel
            // 
            textoTel.AutoSize = true;
            textoTel.Location = new Point(69, 199);
            textoTel.Name = "textoTel";
            textoTel.Size = new Size(83, 25);
            textoTel.TabIndex = 3;
            textoTel.Text = "Telefono:";
            // 
            // cajaNombre
            // 
            cajaNombre.Location = new Point(244, 62);
            cajaNombre.Name = "cajaNombre";
            cajaNombre.Size = new Size(150, 31);
            cajaNombre.TabIndex = 4;
            // 
            // cajaPrimerApel
            // 
            cajaPrimerApel.Location = new Point(244, 102);
            cajaPrimerApel.Name = "cajaPrimerApel";
            cajaPrimerApel.Size = new Size(150, 31);
            cajaPrimerApel.TabIndex = 5;
            // 
            // cajaSegundoApel
            // 
            cajaSegundoApel.Location = new Point(244, 146);
            cajaSegundoApel.Name = "cajaSegundoApel";
            cajaSegundoApel.Size = new Size(150, 31);
            cajaSegundoApel.TabIndex = 6;
            // 
            // cajaTel
            // 
            cajaTel.Location = new Point(244, 193);
            cajaTel.Name = "cajaTel";
            cajaTel.Size = new Size(150, 31);
            cajaTel.TabIndex = 7;
            // 
            // botonAgregar
            // 
            botonAgregar.Location = new Point(562, 86);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(112, 34);
            botonAgregar.TabIndex = 8;
            botonAgregar.Text = "Agregar";
            botonAgregar.UseVisualStyleBackColor = true;
            botonAgregar.Click += botonAgregar_Click;
            // 
            // botonCancelar
            // 
            botonCancelar.Location = new Point(562, 162);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(112, 34);
            botonCancelar.TabIndex = 9;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 254);
            Controls.Add(botonCancelar);
            Controls.Add(botonAgregar);
            Controls.Add(cajaTel);
            Controls.Add(cajaSegundoApel);
            Controls.Add(cajaPrimerApel);
            Controls.Add(cajaNombre);
            Controls.Add(textoTel);
            Controls.Add(textoSegundoApel);
            Controls.Add(textoPrimerApel);
            Controls.Add(textoNombre);
            MaximumSize = new Size(730, 310);
            MinimumSize = new Size(730, 310);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textoNombre;
        private Label textoPrimerApel;
        private Label textoSegundoApel;
        private Label textoTel;
        private TextBox cajaNombre;
        private TextBox cajaPrimerApel;
        private TextBox cajaSegundoApel;
        private TextBox cajaTel;
        private Button botonAgregar;
        private Button botonCancelar;
    }
}