namespace Ejercicio2Clase
{
    public partial class Form1 : Form
    {

        private List<Coche> listaCoches;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*for (int i = 0; i < listBox1.Items.Count; i++)
            {
                comboBox1.Items.Add(listBox1.Items[i].ToString());
            }
            comboBox1.SelectedIndex = comboBox1.Items.Count-1;
            listBox1.Items.Add("Mazda");
            listBox1.SelectedIndex = listBox1.Items.Count - 1;*/

            listaCoches = new List<Coche>();
            listaCoches.Add(new Coche("Mercedes","Clase A"));
            listaCoches.Add(new Coche("Audi", "Q5"));
            listaCoches.Add(new Coche("Opel", "Astra"));
            listaCoches.Add(new Coche("Seat", "Leon"));

            listBox1.DataSource=listaCoches;
            comboBox1.DataSource=listaCoches;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblResolucion_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rdbResolucion1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdbPulsado = (RadioButton)sender;
            switch (rdbPulsado.TabIndex)
            {
                case 0:
                    //MessageBox.Show("Ha cambiado de Estado el radioButton" + rdbPulsado.Text + " a valor " +
                    //rdbPulsado.Checked);
                    if (rdbPulsado.Checked)
                    {
                        this.Size = new System.Drawing.Size(640, 480);
                    }
                    break;

                case 1:
                    //MessageBox.Show("Ha cambiado de Estado el radioButton" + rdbPulsado.Text + " a valor " +
                    //rdbPulsado.Checked);
                    if (rdbPulsado.Checked)
                    {
                        this.Size = new System.Drawing.Size(800, 600);
                    }
                    break;

                case 2:
                    //MessageBox.Show("Ha cambiado de Estado el radioButton" + rdbPulsado.Text + " a valor " +
                    //rdbPulsado.Checked);
                    if (rdbPulsado.Checked)
                    {
                        this.Size = new System.Drawing.Size(1024, 768);
                    }
                    break;
            }
        }

        private void Rdb640x480(object sender, EventArgs e)
        {
            if (chbVentana2.Checked)
            {

            }
            else if (rdbResolucion1.Checked)
            {
                this.Size = new Size(640, 480);
            }
        }

        private void Rdb800x600(object sender, EventArgs e)
        {
            if (chbVentana2.Checked)
            {

            }
            else if (rdbResolucion2.Checked)
            {
                this.Size = new Size(800, 600);
            }
        }
        private void Rdb1024x768(object sender, EventArgs e)
        {
            if (chbVentana2.Checked)
            {

            }
            else if (rdbResolucion3.Checked)
            {
                this.Size = new Size(1024, 768);
            }
        }

        private void chbVentana_Max(object sender, EventArgs e)
        {
            if (chbVentana2.Checked)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void chbMaximizar_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chb = (CheckBox)sender;
            switch (chb.TabIndex)
            {
                case 0:
                    if (chb.Checked)
                    {
                        this.WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
