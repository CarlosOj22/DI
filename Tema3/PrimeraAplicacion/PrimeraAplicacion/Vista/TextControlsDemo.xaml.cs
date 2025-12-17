namespace PrimeraAplicacion.Vista;


public partial class TextControlsDemo : ContentPage
{
    public TextControlsDemo()
    {
        InitializeComponent();
    }

    private void txtName_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (e.OldTextValue == null || e.NewTextValue.Length - e.OldTextValue.Length > 0)
        {
            if (e.OldTextValue != null)
            {
                DisplayAlert("Cambio de texto", $"Se ha añadido la letra {e.NewTextValue}", "OK");
            }
            else
            {
                DisplayAlert("Cambio de texto", $"Se ha añadido la letra {e.NewTextValue[e.NewTextValue.Length - 1]}", "OK");
            }
        }
        else
        {
            char letraEliminada = e.OldTextValue[e.OldTextValue.Length - 1];
            DisplayAlert("Cambio de texto", $"Se ha eliminado la letra '{letraEliminada}'\nTexto anterior: {e.OldTextValue}\nTexto nuevo: {e.NewTextValue}", "OK");
        }
        //si hemos añadido una letra ponemos que la hemos añadido y decimos cual y si lo borramos igual
    }

    private void txtName_Completed(object sender, EventArgs e)
    {

    }

    private void txtNuevoElementoLista_Completed(object sender, EventArgs e)
    {

        List<string> listaPicker = new List<string>();
        for(int i=0; i < picker.ItemsSource.Count; i++)
        {
            listaPicker.Add(picker.ItemsSource[i].ToString());
        }
        listaPicker.Add(txtNuevoElementoLista.Text);
        picker.ItemsSource = null;
        picker.ItemsSource = listaPicker;
    }
}