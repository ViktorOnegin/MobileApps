using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

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
            
            SearchButton.Click += SearchButton_Click;

        }

        private async void SearchButton_Click(object sender, System.EventArgs e)
        {
            var editText = FindViewById<EditText>(Resource.Id.textView1);
            var temp = FindViewById<TextView>(Resource.Id.textView4);
            var windSpeed = FindViewById<TextView>(Resource.Id.textView5);
            var pressure = FindViewById<TextView>(Resource.Id.textView6);
            var visibility = FindViewById<TextView>(Resource.Id.textView7);
            var humidity = FindViewById<TextView>(Resource.Id.textView8);

            var weather = await Core.Core.GetWeather(editText.Text);

            temp.Text = weather.Temperature;
            windSpeed.Text = weather.WindSpeed;
            pressure.Text = weather.pressure;
            visibility.Text = weather.Visibility;
            humidity.Text = weather.Humidity;

        }
    }
}