namespace ProyectoWeather
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Mostramos inicialmente la vista de bienvenida
            MainPage = new Vistas.Bienvenidad();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new EstructuraNavegacion.AppShellInicio());
        }

        //Metodo para poner la vista segun el rol
        public static void CambiarShellUsuario(int tipoUsuario)
        {
            if (tipoUsuario == 0) //Administrador
            {
                Current.MainPage = new EstructuraNavegacion.AppShellAdministrador();
            }
            if (tipoUsuario == 1) //Usuario Normal
            {
                Current.MainPage = new EstructuraNavegacion.AppShellInicio();
            }
            if(tipoUsuario != 0 || tipoUsuario != 1) //CUalquiere usuario, invitado
            {
                Current.MainPage = new EstructuraNavegacion.AppShell();
            }
        }
    }
}