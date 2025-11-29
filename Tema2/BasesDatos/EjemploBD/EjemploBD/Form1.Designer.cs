namespace EjemploBD
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            txtServidor = new TextBox();
            txtPuerto = new TextBox();
            checkVisible = new CheckBox();
            btnConectar = new Button();
            dataGridView1 = new DataGridView();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label5 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 32);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 80);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 173);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 2;
            label3.Text = "Servidor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 227);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 3;
            label4.Text = "Puerto";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(152, 32);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 31);
            txtUsuario.TabIndex = 4;
            txtUsuario.Text = "root";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(152, 80);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "root";
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(152, 167);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(150, 31);
            txtServidor.TabIndex = 6;
            txtServidor.Text = "127.0.0.1";
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(152, 221);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(150, 31);
            txtPuerto.TabIndex = 7;
            txtPuerto.Text = "33060";
            // 
            // checkVisible
            // 
            checkVisible.AutoSize = true;
            checkVisible.Location = new Point(152, 118);
            checkVisible.Name = "checkVisible";
            checkVisible.Size = new Size(191, 29);
            checkVisible.TabIndex = 8;
            checkVisible.Text = "Mostrar contraseña\r\n";
            checkVisible.UseVisualStyleBackColor = true;
            checkVisible.CheckedChanged += checkVisible_CheckedChanged;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(782, 90);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(90, 32);
            btnConectar.TabIndex = 9;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 267);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(846, 160);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(349, 51);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 129);
            listBox1.TabIndex = 11;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(577, 51);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(180, 129);
            listBox2.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(346, 23);
            label5.Name = "label5";
            label5.Size = new Size(216, 25);
            label5.TabIndex = 13;
            label5.Text = "Selecciona base de datos ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(568, 23);
            label6.Name = "label6";
            label6.Size = new Size(216, 25);
            label6.TabIndex = 14;
            label6.Text = "Selecciona base de datos ";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(26, 446);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(846, 147);
            dataGridView2.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 687);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnConectar);
            Controls.Add(checkVisible);
            Controls.Add(txtPuerto);
            Controls.Add(txtServidor);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private TextBox txtServidor;
        private TextBox txtPuerto;
        private CheckBox checkVisible;
        private Button btnConectar;
        private DataGridView dataGridView1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView2;
    }
}
