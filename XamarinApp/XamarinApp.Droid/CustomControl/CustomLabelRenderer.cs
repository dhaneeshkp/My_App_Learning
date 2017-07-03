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
using Xamarin.Forms;
using XamarinApp.CustomControl;
using XamarinApp.Droid.CustomControl;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;

[assembly:ExportRenderer(typeof(CustomLabel),typeof(CustomLabelRenderer))]
namespace XamarinApp.Droid.CustomControl
{
    
  public  class CustomLabelRenderer:LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            var font = Typeface.CreateFromAsset(Forms.Context.ApplicationContext.Assets,"GreatVibes-Regular.otf");
            Control.Typeface = font;
        }

    }
}