using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_9_MDI
{
    public partial class FormDocumentos : Form
    {
        private Form1 formPrincipal = new Form1();
        public FormDocumentos(string texto, Form1 formprincipal)
        {
            InitializeComponent();
            richTxtFolio.Text = texto;
            this.formPrincipal = formPrincipal;
        }

        public FormDocumentos(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        public FormDocumentos(String str)
        {
            InitializeComponent();
            this.richTxtFolio.Text = str;
        }

        public String contenidoRichBox()
        {
            return this.richTxtFolio.Text;
        }

        private void FormDocumentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrincipal.borrarFormularioCerrado(this);
            //((Form1)this.MdiParent).borrarFormularioCerrado(this);
        }
    }
}
