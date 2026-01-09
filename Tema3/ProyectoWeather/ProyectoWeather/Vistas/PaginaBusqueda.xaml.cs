namespace ProyectoWeather.Vistas;

public partial class PaginaBusqueda : ContentPage
{
	private List<Modelos.Localidad> listaLocalidades;
	public PaginaBusqueda()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		RellenarPicker();
    }

	public async void RellenarPicker()
	{
        Servicios.Geolocalizacion miBusquedaCiudad = new Servicios.Geolocalizacion();
		lista.ItemsSource = null;
		listaLocalidades = await miBusquedaCiudad.ObtenerLocalidades(poblacion.Text);
		lista.ItemsSource = listaLocalidades;
		lista.SelectedIndex = 0;
    }

    private void lista_SelectedIndexChanged(object sender, EventArgs e)
    {
		lat.Text = listaLocalidades[lista.SelectedIndex].Latitud.ToString();
		lon.Text = listaLocalidades[lista.SelectedIndex].Longitud.ToString();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {	
		
        //Cuando pulsamos calcular
        RellenarClima();
    }

	public async void RellenarClima()
	{
		Servicios.Clima busquedaClima=new Servicios.Clima();
		//Llamamos a la api
		var resultado= await busquedaClima.ObtenerDatosClimaticos(lat.Text, lon.Text);
		if (resultado != null)
		{

			tiempo.Text=$"Descripcion: {resultado.descripcion} \n" +
			$"Temperatura: {resultado.temperatura} ºF \n" +
			$"VelocidadViento: {resultado.velocidadViento}  m/s \n";

			//ICONO

			iconoClima.Source = ImageSource.FromUri(new Uri($"https://openweathermap.org/img/wn/{resultado.icono}@4x.png"));
        }
		else
		{
			tiempo.Text = "Problemas obteniendo el clima";
		}
	}
}