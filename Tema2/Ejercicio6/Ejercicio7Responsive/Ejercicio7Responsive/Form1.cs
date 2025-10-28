namespace Ejercicio7Responsive
{
    public partial class Form1 : Form
    {
        public Form1()
        {   
            
            InitializeComponent();//PROPIEDADES DEBAJO ; DESPUES DEL CREAR FORM 1
            txtCaja1.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
                | AnchorStyles.Top;
            txtCaja1.Text = "Hello World";
        }
    }
}
