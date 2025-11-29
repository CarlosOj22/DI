using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool ratonEnTxt1 = false;
        bool ratonEnTxt2 = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void menuOpcionesArchivoSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuOpcionesAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa que realiza Operaciones");
        }

        private void menuOpcionesOperacionesSuma_Click(object sender, EventArgs e)
        {
            if (menuOpcionesOperacionesDivision.Checked || menuOpcionesOperacionesResta.Checked ||
                menuOpcionesOperacionesMultiplicacion.Checked)
            {
                MessageBox.Show("No se pueden tener dos opciones marcadas a la vez");
                menuOpcionesOperacionesDivision.Checked = false;
                menuOpcionesOperacionesResta.Checked = false;
                menuOpcionesOperacionesMultiplicacion.Checked = false;
            }
            else
            {
                menuOpcionesOperacionesSuma.Checked = true;
            }
            //LLAMO A METODO ACTUALIZAR BOTON OPERACION CON LA OPERACION QUE CORRESPONDE
            this.btnOperacion.Visible = true;
            actualizarBotonOperacion(1);
        }

        private void menuOpcionesOperacionesMultiplicacion_Click(object sender, EventArgs e)
        {
            if (menuOpcionesOperacionesDivision.Checked || menuOpcionesOperacionesResta.Checked ||
                menuOpcionesOperacionesSuma.Checked)
            {
                MessageBox.Show("No se pueden tener dos opciones marcadas a la vez");
                menuOpcionesOperacionesDivision.Checked = false;
                menuOpcionesOperacionesResta.Checked = false;
                menuOpcionesOperacionesSuma.Checked = false;
            }
            else
            {
                menuOpcionesOperacionesMultiplicacion.Checked = true;
            }
            //LLAMO A METODO ACTUALIZAR BOTON OPERACION CON LA OPERACION QUE CORRESPONDE
            this.btnOperacion.Visible = true;
            actualizarBotonOperacion(2);
        }

        private void menuOpcionesOperacionesResta_Click(object sender, EventArgs e)
        {
            if (menuOpcionesOperacionesDivision.Checked || menuOpcionesOperacionesSuma.Checked ||
                menuOpcionesOperacionesMultiplicacion.Checked)
            {
                MessageBox.Show("No se pueden tener dos opciones marcadas a la vez");
                menuOpcionesOperacionesDivision.Checked = false;
                menuOpcionesOperacionesSuma.Checked = false;
                menuOpcionesOperacionesMultiplicacion.Checked = false;
            }
            else
            {
                menuOpcionesOperacionesResta.Checked = true;
            }
            //LLAMO A METODO ACTUALIZAR BOTON OPERACION CON LA OPERACION QUE CORRESPONDE
            this.btnOperacion.Visible = true;
            actualizarBotonOperacion(3);
        }

        private void menuOpcionesOperacionesDivision_Click(object sender, EventArgs e)
        {
            if (menuOpcionesOperacionesSuma.Checked || menuOpcionesOperacionesResta.Checked ||
                menuOpcionesOperacionesMultiplicacion.Checked)
            {
                MessageBox.Show("No se pueden tener dos opciones marcadas a la vez");
                menuOpcionesOperacionesSuma.Checked = false;
                menuOpcionesOperacionesResta.Checked = false;
                menuOpcionesOperacionesMultiplicacion.Checked = false;
            }
            else
            {
                menuOpcionesOperacionesDivision.Checked = true;
            }
            //LLAMO A METODO ACTUALIZAR BOTON OPERACION CON LA OPERACION QUE CORRESPONDE
            //Y LO PONGO VISIBLE!!
            this.btnOperacion.Visible = true;
            actualizarBotonOperacion(4);
        }

        public void actualizarBotonOperacion(int idOperacion)
        {
            switch (idOperacion)
            {
                case 1:
                    this.btnOperacion.Text = "+";
                    break;
                case 2:
                    this.btnOperacion.Text = "*";
                    break;
                case 3:
                    this.btnOperacion.Text = "-";
                    break;
                case 4:
                    this.btnOperacion.Text = "/";
                    break;
            }
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            if (this.txt1.Text.Length == 0 || this.txt2.Text.Length == 0)
            {
                MessageBox.Show("No se pueden dejar argumentos de la operacion vacios");
            }
            else
            {
                //CONTROLAMOS EXCEPCION DE QUE SE PASE UN NUMERO O LETRAS
                try
                {
                    double num1 = Double.Parse(this.txt1.Text);
                    double num2 = Double.Parse(this.txt2.Text);
                    double resultado;
                    switch (this.btnOperacion.Text)
                    {
                        case "+":
                            resultado = num1 + num2;
                            this.txtResultado.Text = resultado.ToString();
                            break;

                        case "*":
                            resultado = num1 * num2;
                            this.txtResultado.Text = resultado.ToString();
                            break;

                        case "-":
                            resultado = num1 - num2;
                            this.txtResultado.Text = resultado.ToString();
                            break;

                        case "/":
                            resultado = Math.Round(num1 / num2, 2);
                            this.txtResultado.Text = resultado.ToString();
                            break;
                    }

                }
                catch (Exception excepcion)
                {
                    MessageBox.Show("Error: Algun argumento no es un número");
                }
            }
        }


        //ME HE IDO A EVENTOS, RATON ENCIMA (supongo que la mejor opcion es esta hover y tal
        //pone que es cuando dejamos raton encima un tiempo)y cambio que el boleean TEXTO 1 POR EJEMPLO
        //pase de false a true, para luego saber quien tiene el raton encima en borrar y demas opciones
        //del menu contextual
        private void txt1_MouseHover(object sender, EventArgs e)
        {
            ratonEnTxt1 = true;
            ratonEnTxt2 = false;
        }

        private void txt2_MouseHover(object sender, EventArgs e)
        {
            ratonEnTxt2 = true;
            ratonEnTxt1 = false;
        }

        private void menuContextual1Borrar_Click(object sender, EventArgs e)
        {

            //MANERA MAS OPTIMO MENUCONTEXTUAL1.SOURCECONTROL, DEVUELVE QUIEN DESENCADENO EL EVENTO
            //LO QUE DEVUELVE LO TRANSFORMAMOS A TEXTBOOK
            //TEXTBOOK TXTPULSADA = (TEXTBOOK)MENUCONTEXTUAL1.SOURCECONTROL;
            //TXTPULSADA.TEXT = "";

            if (ratonEnTxt1 == true || ratonEnTxt2 == false)
            {
                //Si estoy encima de txt1 borro su contenido cuando le de a pulsar, funcionara asi?
                this.txt1.Text = "";
            }
            if (ratonEnTxt2 == true || ratonEnTxt1 == false)
            {
                this.txt2.Text = "";
            }
        }
        private void menuContextual1Iniciar_Click(object sender, EventArgs e)
        {
            if (ratonEnTxt1 == true || ratonEnTxt2 == false)
            {
                this.txt1.Text = "0";
            }
            if (ratonEnTxt2 == true || ratonEnTxt1 == false)
            {
                this.txt2.Text = "0";
            }
        }

        private void menuContextual1Aleatorio_Click(object sender, EventArgs e)
        {   
            Random rd = new Random();
            if (ratonEnTxt1 == true || ratonEnTxt2 == false)
            {
                this.txt1.Text = rd.Next(0,50).ToString();
            }
            if (ratonEnTxt2 == true || ratonEnTxt1 == false)
            {
                this.txt2.Text = rd.Next(0, 50).ToString();
            }
        }
    }
}
//MI IDEA CHEQUEAR QUIEN TIENE EL CLICK DE LA TEXT BOOK Y CON ESO TIRARLE
//SOLO UN MENU CONTEXTUAL, SE LO ASOCIAMOS A LOS DOS, PERO SI ELEGIMOS UNA ACCION SOLO TIENE
//QUE AFECTAR A AQUEL QUE SACO EL MENU CONTEXTUAL
//Y ACABAR EJERCICIO QUE BORRE, INICIE A 0, Y ALEATORIO ESO SAE