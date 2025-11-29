namespace PrimeraAplicacion.Vista;

public partial class CommandControlDemo1 : ContentPage
{
	public CommandControlDemo1()
	{
		InitializeComponent();
	}

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {	
		//Esto entra en el examen del proximo dia esta linea de abajo!!!!!
		//Simplemente que se puede aacceder a el objeto con el sneder o con su nombbre.
		//Si no tiene nombre podemos acceder asi
		CheckBox miChk = (CheckBox)sender;
		//Podemos acceder a los elementos de la vista si les emos puesto un x:Name
		if (chkEstado.IsChecked == true)
		{
			lblChk.Text = "El checkBox esta seleccionado";
		}
		else
		{
			lblChk.Text = "CheckBox no seleccionado";
		}
    }

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {

		lblSlider.Text = Convert.ToInt16(slider.Value).ToString();
		stepper.Value=slider.Value;
    }

    private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		if (stepper.Value > 10) stepper.Value = 10;
		if (stepper.Value < 0) stepper.Value = 0;
		slider.Value = stepper.Value;
    }

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {	
		Switch interruptor = (Switch)sender;
		chkEstado.IsChecked = interruptor.IsToggled;
    }

    private void fecha_DateSelected(object sender, DateChangedEventArgs e)
    {
		DisplayAlert("FECHA",fecha.Date.Date.ToString(),"OK");
    }
}