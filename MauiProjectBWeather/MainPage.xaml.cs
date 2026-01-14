using MauiProjectBWeather.Services;

namespace MauiProjectBWeather
{
    public partial class MainPage : ContentPage
    {
        private OpenWeatherService _service;
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            _service = new OpenWeatherService();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            try
            {
                var forecast = await _service.GetForecastAsync("Uppsala");
                ServiceLabel.Text = $"{forecast.Items.Count} forcast items read.";
            }
            catch (Exception ex)
            {
                ServiceLabel.Text = $"Error reading forecast: {ex.Message}";
            }
        }

    }
}
