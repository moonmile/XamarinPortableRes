using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace XamarinPortableRes.iOS
{
	public partial class XamarinPortableRes_iOSViewController : UIViewController
	{
		public XamarinPortableRes_iOSViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Perform any additional setup after loading the view, typically from a nib.
            // text content
            this.text1.Text = XamarinPortableRes.Lib.Properties.Resources.Message1;
            // image contents
            this.imageBlue.Image = ToBitmap(XamarinPortableRes.Lib.Resources.MarkBlue);
            this.imageGreen.Image = ToBitmap(XamarinPortableRes.Lib.Resources.MarkGreen);
            this.imageOrange.Image = ToBitmap(XamarinPortableRes.Lib.Resources.MarkOrange);
            this.imagePurple.Image = ToBitmap(XamarinPortableRes.Lib.Resources.MarkPurple);
            this.imageRed.Image = ToBitmap(XamarinPortableRes.Lib.Resources.MarkRed);
        }

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
        /// <summary>
        /// Convert to Bitmap from System.IO.Stream
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        UIImage ToBitmap(System.IO.Stream st)
        {
            var data = NSData.FromStream( st );
            var bmp = UIImage.LoadFromData(data);
            return bmp;
        }
    }
}