using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace WeatherApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var SearchButton = FindViewById<Button>(Resource.Id.button1);
            var editText = FindViewById<TextView>(Resource.Id.textView1);

            SearchButton.Click += SearchButton_Click;
        }
        private async void SearchButton_Click(object sender, System.EventArgs e)
        {
            var editText = FindViewById<TextView>(Resource.Id.textView1);
            var city = FindViewById<TextView>(Resource.Id.textView2);
            var temp = FindViewById<TextView>(Resource.Id.textView3);
            var windSpeed = FindViewById<TextView>(Resource.Id.textView4);
            var mainPressure = FindViewById<TextView>(Resource.Id.textView5);

            var weather = await Core.Core.GetWeather(editText.Text);
            city.Text = weather.City;
            temp.Text = weather.Temperature;
            windSpeed.Text = weather.WindSpeed;
            mainPressure.Text = weather.MainPressure;
        }
    }
}