namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        Console.WriteLine("Created");
        InitializeComponent();
    }

    ~MainPage()
    {
        Console.WriteLine("Destroyed");
    }

    private void OnPushClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage(), true);
    }

    private void OnPopClicked(object sender, EventArgs e)
    {
        if (Navigation.NavigationStack.Count > 0)
            Navigation.PopAsync(true);
    }

    private void OnPopToRootClicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync(true);
    }
}
