

namespace ProyectoWeather.Vistas;

public partial class Bienvenidad : ContentPage
{
    public Bienvenidad()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        BBDD.BBDD miBBDD = new BBDD.BBDD();
        if (miBBDD.Conectar())
        {   
            miBBDD.AbrirConexion();//ABRIMOS CONEXION ANTES DE COMPROBAR USUARIO

            if (miBBDD.ComprobarUsuario(txtEmail.Text, txtPass.Text))
            {
                int tipoUsuario = miBBDD.TipoDeUsuario();

                App.CambiarShellUsuario(tipoUsuario);
            }
            else
            {
                DisplayAlert("FEROOR", "Usuario o contraseña Incorrectos", "X");
            }
        }
        else
        {
            DisplayAlert("FALLO AL CONECTAR", "No Conectado", "X");
        }
    }
}