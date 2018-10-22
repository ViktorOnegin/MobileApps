using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Android.Content.PM;

namespace WeatherApp
{
    [Activity(Label = "@string/app_name", Icon = "@drawable/Storm1" , Theme = "@style/AppTheme", MainLauncher = true ,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]

    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var SearchButton = FindViewById<Button>(Resource.Id.button1);
            var ForecastButton = FindViewById<Button>(Resource.Id.button2);

            SearchButton.Click += SearchButton_Click;
            ForecastButton.Click += ForecastButton_Click;
        }

        private async void SearchButton_Click(object sender, System.EventArgs e)
        {
            var editText = FindViewById<EditText>(Resource.Id.textView1);
            var temp = FindViewById<TextView>(Resource.Id.textView4);
            var windSpeed = FindViewById<TextView>(Resource.Id.textView5);
            var pressure = FindViewById<TextView>(Resource.Id.textView6);
            var visibility = FindViewById<TextView>(Resource.Id.textView7);
            var humidity = FindViewById<TextView>(Resource.Id.textView8);
            var icon = FindViewById<ImageView>(Resource.Id.imageView1);

            icon.Visibility = Android.Views.ViewStates.Visible;

            var weather = await Core.Core.GetWeather(editText.Text);

            temp.Text = weather.Temperature;
            windSpeed.Text = weather.WindSpeed;
            pressure.Text = weather.pressure;
            visibility.Text = weather.Visibility;
            humidity.Text = weather.Humidity;

            switch (weather.Icon)
            {
                case ("01d"):
                    icon.SetImageResource(Resource.Drawable.Sun);
                    break;

                case ("02d"):
                    icon.SetImageResource(Resource.Drawable.CloudAndSun);
                    break;

                case ("04d"):
                    icon.SetImageResource(Resource.Drawable.Cloudy);
                    break;

                case ("09d"):
                    icon.SetImageResource(Resource.Drawable.rainy1);
                    break;
                    
                case ("10d"):
                    icon.SetImageResource(Resource.Drawable.Rainy);
                    break;

                case ("11d"):
                    icon.SetImageResource(Resource.Drawable.Storm);
                    break;

                case ("13d"):
                    icon.SetImageResource(Resource.Drawable.Snowy);
                    break;

                case ("50d"):
                    icon.SetImageResource(Resource.Drawable.Windy);
                    break;

            }

        }

        private void ForecastButton_Click(object sender, System.EventArgs e)
        {
            var secondActivity = new Intent(this, typeof(SecondActivity));
            StartActivity(secondActivity);
        }
    }
}