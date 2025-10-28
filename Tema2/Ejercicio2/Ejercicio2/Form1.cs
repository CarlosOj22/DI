namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        private bool tamano = false;
        private int indiceDialogo =0 ;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Buenos dias";
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.AntiqueWhite;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void Form1_DragOver(object sender, DragEventArgs e)
        {
            MessageBox.Show("No puedes arrastrar eso aqui");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (tamano == false)
            {
                WindowState = (FormWindowState)2;
                tamano = true;
            }
            else
            {
                WindowState = (FormWindowState)0;
                tamano = false;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Random aleatorio = new Random();
            Height = aleatorio.Next(600, 1001);
            Width = aleatorio.Next(700, 1001);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            // Mostrar la siguiente frase si todavía hay más
            if (indiceDialogo < Dialogos.dialogo.Length)
            {
                textBox1.Text = Dialogos.dialogo[indiceDialogo];
                indiceDialogo++;
            }
            else
            {
                textBox1.Text = "Que comienze tu aventura";
            }
        }
    }
}
