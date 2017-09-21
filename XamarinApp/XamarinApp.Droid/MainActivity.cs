using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
namespace XamarinApp.Droid
{
    [Activity(Label = "XamarinApp", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, 
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
         TabLayoutResource = Resource.Layout.Tabbar;
            //  ToolbarResource = Resource.Layout.Toolbar;
            SetContentView(Resource.Layout.Tabbar);
            base.OnCreate(bundle);
           

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
            SetActionbarText(this, "Dhaneeesh");
        }

        public static void SetActionbarText(Activity activity, string text)
        {
            // Setting custom view enable
            if (activity != null)
            {
                activity.ActionBar.SetHomeButtonEnabled(true);
                activity.ActionBar.SetIcon(Android.Resource.Color.Transparent);
                activity.ActionBar.SetDisplayShowCustomEnabled(true);

                LinearLayout linearLayout = new LinearLayout(activity);
                linearLayout.SetGravity(GravityFlags.CenterVertical);
                LinearLayout.LayoutParams textViewParameters =
                    new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MatchParent, LinearLayout.LayoutParams.MatchParent);
                textViewParameters.RightMargin = (int)(40 * activity.Resources.DisplayMetrics.Density);
                TextView modelTitle = new TextView(activity);
                modelTitle.Text = text;
                modelTitle.Gravity = GravityFlags.Center;
                modelTitle.TextSize = 20;
                modelTitle.SetTextColor(Android.Graphics.Color.White);
                linearLayout.AddView(modelTitle, textViewParameters);
                ActionBar.LayoutParams actionbarParams =
                    new ActionBar.LayoutParams(ActionBar.LayoutParams.MatchParent, ActionBar.LayoutParams.MatchParent);
                activity.ActionBar.SetCustomView(linearLayout, actionbarParams);
            }
        }
    }
}

