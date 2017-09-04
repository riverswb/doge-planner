using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace doge_planner
{
    [Activity(Label = "doge_planner", MainLauncher = true)]
    public class MainActivity : Activity
    {
        TextView txtLizScore;

        int lizScore;

        TextView txtBrettScore;

        int brettScore;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            txtLizScore = FindViewById<TextView>(Resource.Id.txtLizScore);

            FindViewById<Button>(Resource.Id.btnLizIncrement).Click += (o, e) =>
            txtLizScore.Text = (++lizScore).ToString();

            FindViewById<Button>(Resource.Id.btnLizDecrement).Click += (o, e) =>
            txtLizScore.Text = (--lizScore).ToString();


            txtBrettScore = FindViewById<TextView>(Resource.Id.txtBrettScore);

            FindViewById<Button>(Resource.Id.btnBrettIncrement).Click += (o, e) =>
            txtBrettScore.Text = (++brettScore).ToString();

            FindViewById<Button>(Resource.Id.btnBrettDecrement).Click += (o, e) =>
            txtBrettScore.Text = (--brettScore).ToString();
        }
        
    }
}

