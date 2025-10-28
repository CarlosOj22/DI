using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6Form
{
    public partial class Form2 : Form
    {
        //Creo objeto de tipo Form1 para acceder a su array y añadir desde el boton añadir de Form2
        Form1 formPrimero = new Form1();
        public Form2(Form1 formPrincipal)
        {
            InitializeComponent();
            formPrimero = formPrincipal;
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            formPrimero.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            //Miro si cualquier texto sta vacio
            if (cajaNombre.Text.Length == 0 || cajaPrimerApel.Text.Length == 0
                || cajaSegundoApel.Text.Length == 0 || cajaTel.Text.Length == 0)
            {
                //SACAR MENSAJE ERROR Y SALIR
                MessageBox.Show("ERROR : Hay cuadros de Texto Vacios");
                formPrimero.actualizarVista();
            }
            else
            {
                Forestal forestal = new Forestal(cajaNombre.Text, cajaPrimerApel.Text
                ,cajaSegundoApel.Text, cajaTel.Text);
                formPrimero.añadirForestal(forestal);
                formPrimero.actualizarVista();
                MessageBox.Show("Ingernio Añadido Correctamente");
                this.Close();
            }

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
