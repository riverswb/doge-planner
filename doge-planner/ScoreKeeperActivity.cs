using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace doge_planner
{
    [Activity(Label = "@string/scoreKeeper")]
    public class ScoreKeeperActivity : Activity
    {
        TextView txtLizScore;

        int lizScore;

        TextView txtBrettScore;

        int brettScore;

        TextView txtSusanScore;

        int SusanScore;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.ScoreKeeper);

            txtLizScore = FindViewById<TextView>(Resource.Id.txtLizScore);

            FindViewById<Button>(Resource.Id.btnLizPlus1).Click += (o, e) =>
            txtLizScore.Text = (++lizScore).ToString();

            FindViewById<Button>(Resource.Id.btnLizPlus5).Click += (o, e) =>
            txtLizScore.Text = (lizScore += 5).ToString();

            FindViewById<Button>(Resource.Id.btnLizPlus10).Click += (o, e) =>
            txtLizScore.Text = (lizScore += 10).ToString();

            FindViewById<Button>(Resource.Id.btnLizMinus1).Click += (o, e) =>
            txtLizScore.Text = (--lizScore).ToString();

            FindViewById<Button>(Resource.Id.btnLizMinus5).Click += (o, e) =>
            txtLizScore.Text = (lizScore -= 5).ToString();

            FindViewById<Button>(Resource.Id.btnLizMinus10).Click += (o, e) =>
            txtLizScore.Text = (lizScore -= 10).ToString();

            txtBrettScore = FindViewById<TextView>(Resource.Id.txtBrettScore);

            FindViewById<Button>(Resource.Id.btnBrettPlus1).Click += (o, e) =>
            txtBrettScore.Text = (++brettScore).ToString();

            FindViewById<Button>(Resource.Id.btnBrettPlus5).Click += (o, e) =>
            txtBrettScore.Text = (brettScore += 5).ToString();

            FindViewById<Button>(Resource.Id.btnBrettPlus10).Click += (o, e) =>
            txtBrettScore.Text = (brettScore += 10).ToString();

            FindViewById<Button>(Resource.Id.btnBrettMinus1).Click += (o, e) =>
            txtBrettScore.Text = (--brettScore).ToString();

            FindViewById<Button>(Resource.Id.btnBrettMinus5).Click += (o, e) =>
            txtBrettScore.Text = (brettScore -= 5).ToString();

            FindViewById<Button>(Resource.Id.btnBrettMinus10).Click += (o, e) =>
            txtBrettScore.Text = (brettScore -= 10).ToString();

            txtSusanScore = FindViewById<TextView>(Resource.Id.txtSusanScore);

            FindViewById<Button>(Resource.Id.btnSusanPlus1).Click += (o, e) =>
            txtSusanScore.Text = (++SusanScore).ToString();

            FindViewById<Button>(Resource.Id.btnSusanPlus5).Click += (o, e) =>
            txtSusanScore.Text = (SusanScore += 5).ToString();

            FindViewById<Button>(Resource.Id.btnSusanPlus10).Click += (o, e) =>
            txtSusanScore.Text = (SusanScore += 10).ToString();

            FindViewById<Button>(Resource.Id.btnSusanMinus1).Click += (o, e) =>
            txtSusanScore.Text = (--SusanScore).ToString();

            FindViewById<Button>(Resource.Id.btnSusanMinus5).Click += (o, e) =>
            txtSusanScore.Text = (SusanScore -= 5).ToString();

            FindViewById<Button>(Resource.Id.btnSusanMinus10).Click += (o, e) =>
            txtSusanScore.Text = (SusanScore -= 10).ToString();

        }

    }
}

