namespace Ejercicio7Responsive
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
            btnButton1 = new Button();
            btnButton2 = new Button();
            panel1 = new Panel();
            txtCaja1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnButton1
            // 
            btnButton1.BackColor = Color.FromArgb(192, 192, 255);
            btnButton1.Location = new Point(12, 12);
            btnButton1.Name = "btnButton1";
            btnButton1.Size = new Size(225, 294);
            btnButton1.TabIndex = 0;
            btnButton1.Text = "button1";
            btnButton1.UseVisualStyleBackColor = false;
            // 
            // btnButton2
            // 
            btnButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnButton2.BackColor = Color.FromArgb(192, 192, 255);
            btnButton2.Location = new Point(563, 12);
            btnButton2.Name = "btnButton2";
            btnButton2.Size = new Size(225, 294);
            btnButton2.TabIndex = 1;
            btnButton2.Text = "button2";
            btnButton2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(128, 255, 128);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtCaja1);
            panel1.Location = new Point(243, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 395);
            panel1.TabIndex = 2;
            // 
            // txtCaja1
            // 
            txtCaja1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCaja1.Location = new Point(14, 16);
            txtCaja1.Multiline = true;
            txtCaja1.Name = "txtCaja1";
            txtCaja1.Size = new Size(275, 323);
            txtCaja1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnButton2);
            Controls.Add(btnButton1);
            MinimumSize = new Size(822, 506);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnButton1;
        private Button btnButton2;
        private Panel panel1;
        private TextBox txtCaja1;
    }
}
