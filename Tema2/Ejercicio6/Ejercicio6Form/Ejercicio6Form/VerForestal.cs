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
    public partial class VerForestal : Form
    {   
        Forestal forestal;
        public VerForestal(Forestal forestalSel)
        {
            InitializeComponent();
            this.forestal = forestalSel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormVerForestal_Load(object sender, EventArgs e)
        {
            //PONGO LAS DATOS DE ESE FORESTAL QUE SE LE PASA CUANDO LE DAMOS A VER FORESTAL(EL QUE ELEGIMOS)
            this.cajaNombre.Text = forestal.Nombre;
            this.cajaPrimerApel.Text = forestal.Apellido1;
            this.cajaSegundoApel.Text = forestal.Apellido2;
            this.cajaTel.Text = forestal.Telefono;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cajaNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //TAREA ACABAR; SI LE DAMOS A CONTAR APAREZCO UN MESSAGEBOX DICIENDO NUMERO DE FORESTALES QUE HAY
        //SI LE DAMOS A ELIMINAR VAMOS A LISTA Y EL SELECTED INDEX ELEGIDO, REMOVEAT Y ACTUALIZAR LISTA

    }
}
