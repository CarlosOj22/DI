namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        int cont;
        public Form1()
        {
            cont = 0;
            InitializeComponent();
            this.Text = "Estoy cambiando las propiedades del titulo del fomr";
            btnPulsame.Text = "Pulsame";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cont++;
            this.Text = "Has pulsado " + cont;
        }
    }
}
