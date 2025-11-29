namespace Ejercicio_9_MDI
{
    public partial class Form1 : Form
    {
        //Se podria hacer con una sola variable
        private List<FormDocumentos> listaFormularios = new List<FormDocumentos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void menuDeOpcionesNuevo_Click(object sender, EventArgs e)
        {   
            if(listaFormularios.Count()==0)
            {
                /*ultimoFormulario = new FormDocumentos();
                //Decimos que el nuevo form es hijo del COntenedor Form1
                ultimoFormulario.MdiParent = this;
                //Show No modal, showdialog Modal
                ultimoFormulario.Show();*/

                FormDocumentos formHijoMDI = new FormDocumentos(this);
                formHijoMDI.MdiParent = this;
                listaFormularios.Add(formHijoMDI);

                formHijoMDI.Show();


            }
            else
            {
                /*nuevoFormulario = new FormDocumentos(ultimoFormulario.contenidoRichBox());
                nuevoFormulario.MdiParent = this;
                ultimoFormulario = nuevoFormulario;
                nuevoFormulario.Show();*/

                string textoObtenido = listaFormularios[listaFormularios.Count - 1].contenidoRichBox();
                FormDocumentos ultimoFormulario = new FormDocumentos(textoObtenido,this);
                ultimoFormulario.MdiParent = this;
                listaFormularios.Add(ultimoFormulario);

                ultimoFormulario.Show();
            }
        }

        public void borrarFormularioCerrado(FormDocumentos formularioCerrado)
        {
            listaFormularios.Remove(formularioCerrado);
        }
    }
}
