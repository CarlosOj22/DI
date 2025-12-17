namespace Ejercicio4._1.Vista;

public partial class JuegoAlineacion : ContentPage
{
	public JuegoAlineacion()
	{
		InitializeComponent();
	}

    private void btnHorizontalStart_Clicked(object sender, EventArgs e)
    {
        this.target.HorizontalTextAlignment = TextAlignment.Start;
    }

    private void btnHorizontalCenter_Clicked(object sender, EventArgs e)
    {
        this.target.HorizontalTextAlignment = TextAlignment.Center;
    }

    private void btnHorizontalEnd_Clicked(object sender, EventArgs e)
    {
        this.target.HorizontalTextAlignment = TextAlignment.End;
    }

    private void btnHorizontalFill_Clicked(object sender, EventArgs e)
    {
        this.target.HorizontalOptions = LayoutOptions.Fill;

    }

    private void btnVerticalStart_Clicked(object sender, EventArgs e)
    {
        this.target.VerticalTextAlignment = TextAlignment.Start;
    }

    private void btnVerticalCenter_Clicked(object sender, EventArgs e)
    {
        this.target.VerticalTextAlignment = TextAlignment.Center;
    }

    private void btnVerticalEnd_Clicked(object sender, EventArgs e)
    {
        this.target.VerticalTextAlignment = TextAlignment.End;
    }

    private void btnVerticalFill_Clicked(object sender, EventArgs e)
    {
        this.target.VerticalOptions = LayoutOptions.Fill;
    }
}