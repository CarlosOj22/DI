namespace Ejercicio1
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
            btnPulsame = new Button();
            SuspendLayout();
            // 
            // btnPulsame
            // 
            btnPulsame.Location = new Point(659, 390);
            btnPulsame.Name = "btnPulsame";
            btnPulsame.Size = new Size(112, 34);
            btnPulsame.TabIndex = 0;
            btnPulsame.Text = "Click me";
            btnPulsame.UseVisualStyleBackColor = true;
            btnPulsame.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnPulsame);
            Name = "Form1";
            Text = "Ejercicio1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPulsame;
    }
}
