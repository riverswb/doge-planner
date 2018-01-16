using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;
using System.Collections.Generic;

namespace doge_planner
{
    [Activity(Label = "doge_planner", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            Button scoreKeeperButton = FindViewById<Button>(Resource.Id.scoreKeeperButton);
            scoreKeeperButton.Click += Button_Click;

            void Button_Click(object sender, EventArgs e)
            {
                Intent intent = new Intent(this, typeof(ScoreKeeperActivity));
                StartActivity(intent);
            }

        }
    }
}

