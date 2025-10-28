namespace Ejercicio2Clase
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
            lblResolucion = new Label();
            panel1 = new Panel();
            chbVentana2 = new CheckBox();
            panel2 = new Panel();
            rdbResolucion2 = new RadioButton();
            rdbResolucion3 = new RadioButton();
            rdbResolucion1 = new RadioButton();
            lblVentana = new Label();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblResolucion
            // 
            lblResolucion.AutoSize = true;
            lblResolucion.Location = new Point(34, 25);
            lblResolucion.Margin = new Padding(4, 0, 4, 0);
            lblResolucion.Name = "lblResolucion";
            lblResolucion.Size = new Size(97, 25);
            lblResolucion.TabIndex = 1;
            lblResolucion.Text = "Resolucion";
            lblResolucion.Click += lblResolucion_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(chbVentana2);
            panel1.Location = new Point(326, 54);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 120);
            panel1.TabIndex = 2;
            // 
            // chbVentana2
            // 
            chbVentana2.AutoSize = true;
            chbVentana2.Location = new Point(39, 45);
            chbVentana2.Margin = new Padding(4);
            chbVentana2.Name = "chbVentana2";
            chbVentana2.Size = new Size(118, 29);
            chbVentana2.TabIndex = 0;
            chbVentana2.Text = "Maximizar";
            chbVentana2.UseVisualStyleBackColor = true;
            chbVentana2.CheckedChanged += chbMaximizar_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(rdbResolucion2);
            panel2.Controls.Add(rdbResolucion3);
            panel2.Controls.Add(rdbResolucion1);
            panel2.Location = new Point(34, 54);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 226);
            panel2.TabIndex = 3;
            // 
            // rdbResolucion2
            // 
            rdbResolucion2.AutoSize = true;
            rdbResolucion2.Location = new Point(22, 90);
            rdbResolucion2.Margin = new Padding(4);
            rdbResolucion2.Name = "rdbResolucion2";
            rdbResolucion2.Size = new Size(115, 29);
            rdbResolucion2.TabIndex = 1;
            rdbResolucion2.TabStop = true;
            rdbResolucion2.Text = "800 x 600";
            rdbResolucion2.UseVisualStyleBackColor = true;
            rdbResolucion2.CheckedChanged += rdbResolucion1_CheckedChanged;
            // 
            // rdbResolucion3
            // 
            rdbResolucion3.AutoSize = true;
            rdbResolucion3.Location = new Point(22, 148);
            rdbResolucion3.Margin = new Padding(4);
            rdbResolucion3.Name = "rdbResolucion3";
            rdbResolucion3.Size = new Size(125, 29);
            rdbResolucion3.TabIndex = 2;
            rdbResolucion3.TabStop = true;
            rdbResolucion3.Text = "1024 x 768";
            rdbResolucion3.UseVisualStyleBackColor = true;
            rdbResolucion3.CheckedChanged += rdbResolucion1_CheckedChanged;
            // 
            // rdbResolucion1
            // 
            rdbResolucion1.AutoSize = true;
            rdbResolucion1.Location = new Point(22, 29);
            rdbResolucion1.Margin = new Padding(4);
            rdbResolucion1.Name = "rdbResolucion1";
            rdbResolucion1.Size = new Size(115, 29);
            rdbResolucion1.TabIndex = 0;
            rdbResolucion1.TabStop = true;
            rdbResolucion1.Text = "640 x 480";
            rdbResolucion1.UseVisualStyleBackColor = true;
            rdbResolucion1.CheckedChanged += rdbResolucion1_CheckedChanged;
            // 
            // lblVentana
            // 
            lblVentana.AutoSize = true;
            lblVentana.Location = new Point(326, 25);
            lblVentana.Margin = new Padding(4, 0, 4, 0);
            lblVentana.Name = "lblVentana";
            lblVentana.Size = new Size(75, 25);
            lblVentana.TabIndex = 1;
            lblVentana.Text = "Ventana";
            lblVentana.Click += label2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "Ford\t", "BMW", "Mercedes", "Seat", "Opel", "Audi", "Mitsubishi" });
            listBox1.Location = new Point(326, 212);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 279);
            listBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(36, 324);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 33);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(lblResolucion);
            Controls.Add(lblVentana);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResolucion;
        private Panel panel1;
        private Panel panel2;
        private Label lblVentana;
        private RadioButton rdbResolucion1;
        private RadioButton rdbResolucion2;
        private RadioButton rdbResolucion3;
        private CheckBox chbVentana2;
        private ListBox listBox1;
        private ComboBox comboBox1;
    }
}
