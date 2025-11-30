namespace Ejercicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 395);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(703, 31);
            textBox1.TabIndex = 0;
            textBox1.Text = "A";
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            DragDrop += Form1_DragDrop;
            DragOver += Form1_DragOver;
            KeyPress += Form1_KeyPress;
            MouseEnter += Form1_MouseEnter;
            MouseLeave += Form1_MouseLeave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
    }
}
