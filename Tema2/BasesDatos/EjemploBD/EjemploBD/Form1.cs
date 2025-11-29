namespace EjemploBD
{
    public partial class Form1 : Form
    {
        private BBDD baseDeDatos;
        public Form1()
        {
            InitializeComponent();
            baseDeDatos = new BBDD();
        }

        private void checkVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (checkVisible.Checked)
            {
                this.txtPassword.PasswordChar = '\0';
            }
            else
            {
                this.txtPassword.PasswordChar = '*';
            }

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (baseDeDatos.Conectar(txtServidor.Text, txtPuerto.Text,
                txtUsuario.Text, txtPassword.Text) == true)
            {
                dataGridView1.DataSource = baseDeDatos.ObtenerGrid();
            }
            else
            {
                MessageBox.Show("Problemas al conectar a la base de datos");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   

            baseDeDatos.getAlmacenamientoEnMemoria.Table //ALGO ASI ESITE?
            //NO HARA FALTA IF PIR QYE SI SALE TABLA ES QUE CONECTA, COJER CODIGO Y TAL PARA ENVIAR TOSAE
            /*if (baseDeDatos.Conectar(txtServidor.Text, txtPuerto.Text,
                txtUsuario.Text, txtPassword.Text) == true)
            {
                dataGridView2.DataSource = baseDeDatos.ObtenerSegundoSelect();
            }
            else
            {
                MessageBox.Show("Problemas al conectar a la base de datos");
            }*/

            //dataGridView2.DataSource = baseDeDatos.ObtenerSegundoSelect(dataGridView2.CurrentRow.);
        }
    }
}
