namespace Ejercicio6Form
{
    public partial class Form1 : Form
    {
        //Lista de forestales
        private List<Forestal> listaForestales;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Se iniciliza cuando carga el Form1
            listaForestales = new List<Forestal>();
            lista.DataSource = listaForestales;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            //Esconde Form1 pero lo deja vivo
            //MEJOR ASI O CON VISIBLE =FALSE?; y CON METODO CON FORMCLOSE PRA CAMBIAR A TRUE; MAS 
            //FACIL ASI NO?
            this.Hide();
            //Crear un objeto de tipo form 2 y lo muestra
            new Form2(this).ShowDialog();
            //Cuando salimos de form 2 vuelve a mostrar form1
            //this.Show();
        }
        //PREGUNTAR SI SE HACEN AQUI LOS METODOS, DIFERENCIA ENTRE FORM1.CS y FORM1.DESIGNER.CS
        //SUPONGO QUE LA LOGICA VA AQUI Y EL DISEÑO COMO BIEN DICE EN DESIGNER; LO QUE ES EL CUADRADO
        public List<Forestal> devolverForestales()
        {
            return listaForestales;
        }
        public void añadirForestal(Forestal f)
        {
            listaForestales.Add(f);
        }
        public void actualizarListBox(Forestal f)
        {
            //Añadimos trabajador a la lista
            this.lista.Items.Add(f);
        }

        public void actualizarVista()
        {
            lista.DataSource = null;
            lista.DataSource = listaForestales;
        }

        private void botonVerNombres_Click(object sender, EventArgs e)
        {
            //PONGO TRY CATCH PORQUE SI PULSO VER SIN ELEGIR FORESTAL ERROR CRESEAA (EN EL CATH UN MESSAGVOX 
            //SEPUEDE TAMBIEN MEJOR CON IF A DICHO SERGIO
            Forestal forestalSeleccionado = null;
            try
            {
                forestalSeleccionado = listaForestales[lista.SelectedIndex];
                new VerForestal(forestalSeleccionado).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No has elegido ningun Trabajador");
            }
            //NO escondo el formulario 1 solo 
            //this.Hide();

        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                listaForestales.RemoveAt(lista.SelectedIndex);
                //ME SEGUIA SALIENDO TRABAJADOR TENGO QUE ACTUALIZAR LISTA
                actualizarVista();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No has seleccionado ningun trabajador");
            }
        }

        private void botonContar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hay " + listaForestales.Count() + " Forestales");
        }
    }
}
