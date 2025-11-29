using EjemploBD;

namespace Persona
{
    public partial class Form1 : Form
    {
        private BBDD miBBDD = new BBDD();
        public Form1()
        {
            InitializeComponent();
        }//Constructor FORM1

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (miBBDD.Conectar2())
            {
                btnConectar.Enabled = true;
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = true;
                btnActualizar.Enabled = true;
                txtApellidos.Enabled = true;
                txtNombre.Enabled = true;
                MostrarBBDD();
            }
            else
            {
                MessageBox.Show("Error conectando a la base de datos");
            }
        }//btnConectar_Click


        private void MostrarBBDD()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = miBBDD.LeerBBDD();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            miBBDD.Agregar(txtNombre.Text, txtApellidos.Text);
            MostrarBBDD();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //SACAR DE UN DATA GRID SACAMOS EL VALOR DE UNA CELDA EN UNA FILA(ENTRA EN EL EXAMEN)
            //APRENDER ESTO DE ABAJO BIEN
            int indiceFila = dataGridView1.SelectedCells[0].RowIndex;
            string id = dataGridView1.Rows[indiceFila].Cells[0].Value.ToString();
            miBBDD.Eliminar(id);
            MostrarBBDD();


            //CHULETA CONEXION LINEAS DE CONEXION,  CADENA CONEXION, COMAND OBJETOS, METODOS EXECUTEREADER SI
            //COMANDO VA AUN DATAREADER, SI NO NONQUERY, SI ESTAMOS MANEJANDO DATASET GUARDAR SET DATOS QUE DEVUELVE
            //FOLIO SE GRAPA Y VA CON EL EXAMEN
            //NO TRAER METODOS ENTEROS
        }
    }
}
