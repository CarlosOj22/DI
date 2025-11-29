namespace Ejercicio_9_MDI
{
    partial class FormDocumentos
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
            richTxtFolio = new RichTextBox();
            SuspendLayout();
            // 
            // richTxtFolio
            // 
            richTxtFolio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTxtFolio.Location = new Point(12, 12);
            richTxtFolio.Name = "richTxtFolio";
            richTxtFolio.Size = new Size(776, 439);
            richTxtFolio.TabIndex = 0;
            richTxtFolio.Text = "";
            // 
            // FormDocumentos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTxtFolio);
            Name = "FormDocumentos";
            Text = "FormDocumentos";
            FormClosing += FormDocumentos_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTxtFolio;
    }
}