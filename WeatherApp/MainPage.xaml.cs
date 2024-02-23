namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OneGetWeatherClicked(object sender, EventArgs e)
        {
            var weatherService = new WeatherService();

            var weatherData = await weatherService.GetWeatherDataAsync(Entercity.Text);

            if (weatherData != null)
            {
                temperatureLabel.Text = $"Temperature: {weatherData.Main.Temp}C";

                if (weatherData.Weather != null && weatherData.Weather.Any())
                {
                    conditionLabel.Text = $"Condition: {weatherData.Weather[0].Main}, {weatherData.Weather[0].Description}";
                }
            }
        }

    }

}
