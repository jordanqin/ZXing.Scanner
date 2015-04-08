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
using Android.Support.V4.App;
using Android.Content.PM;

namespace ZXing.Scanner
{
    [Activity(Label = "@string/ApplicationName", LaunchMode = LaunchMode.SingleTask, MainLauncher = true, ScreenOrientation = ScreenOrientation.Portrait, Theme = "@android:style/Theme.Light.NoTitleBar")]
    public class HomeActivity : FragmentActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.content_frame);

            SupportFragmentManager
                .BeginTransaction()
                .Replace(Resource.Id.content_frame, new HomeFragment())
                .CommitAllowingStateLoss();
        }
    }
}