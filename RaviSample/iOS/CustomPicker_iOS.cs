using System;
using RaviSample;
using RaviSample.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPicker_iOS))]
namespace RaviSample.iOS
{
    public class CustomPicker_iOS : PickerRenderer
    {
        public CustomPicker_iOS()
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if(Control != null){
                Control.BackgroundColor = UIColor.Clear;
                Control.BorderStyle = UITextBorderStyle.None;
                Control.Font = UIFont.FromName("Arial", 13);
            }
        }
    }
}
