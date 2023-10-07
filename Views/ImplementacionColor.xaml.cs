namespace ColoresGraphics.Views;

public partial class ImplementacionColor : ContentPage
{
	public ImplementacionColor()
	{
		InitializeComponent();

		Label red = new Label { Text = "Red", TextColor = Colors.Red };
		Label green = new Label { Text ="Green", TextColor = Color.FromRgb(38, 127, 0) };
        Label blue = new Label { Text = "Blue", TextColor = Color.FromRgba(0, 38, 255, 255) };
        Label yellow = new Label { Text = "Yellow", TextColor = Color.FromHsla(0.167, 1.0, 0.5, 1.0) };
        Label pink = new Label { Text = "Rosa", TextColor = Color.FromHsv(0.95f, 0.7f, 0.9f) };
        Label orange = new Label { Text = "Orange", TextColor = Color.FromArgb("FF6A00") };


        myStackLayout.Children.Add(red);
        myStackLayout.Children.Add(green);
        myStackLayout.Children.Add(blue);
        myStackLayout.Children.Add(yellow);
        myStackLayout.Children.Add(pink);
        myStackLayout.Children.Add(orange);

        //Implementacion de un color con el metodo fromInt
        int doradoArgb = unchecked((int)0xFFFFA500);
        AgregarLabelDesdeInt(doradoArgb);
    }
    private void AgregarLabelDesdeInt(int argb)
    {
        byte r = (byte)((argb & 0x00ff0000) >> 0x10);
        byte g = (byte)((argb & 0x0000ff00) >> 0x8);
        byte b = (byte)(argb & 0x000000ff);

        Label label = new Label
        {
            Text = $"Color desde Int: R:{r} G:{g} B:{b}",
            TextColor = Color.FromInt(argb)
        };

        myStackLayout.Children.Add(label);
    }
}