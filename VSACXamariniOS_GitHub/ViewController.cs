using System;
using System.Collections.Generic;

using UIKit;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;


namespace VSACXamariniOS_GitHub
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        //public InvalidNumberException(int value)
        //{
        //    var message = string.Format("Custome error!. Value: {0}", value);
        //    base(message, this.InnexException)
        //}

        partial void UIButton197_TouchUpInside(UIButton sender)
        {
            Analytics.TrackEvent("Button clicked", new Dictionary<string, string> {
                { "Category", "Music" },
                { "Color", "blue"}
            });

            //throw new NotImplementedException();
        }

        partial void UIButton199_TouchUpInside(UIButton sender)
        {
            var number = 5;
            try {
                if (number == 5)
                    throw new InvalidTimeZoneException();
            } catch (Exception exception) {
                var properties = new Dictionary<string, string>
                {
                    { "Category", "Hand Exc" },
                    { "Button", "Yes"}
                };
                Crashes.TrackError(exception, properties);
            }
       
            Crashes.GenerateTestCrash();

            //throw new NotImplementedException();
        }
    }
}
