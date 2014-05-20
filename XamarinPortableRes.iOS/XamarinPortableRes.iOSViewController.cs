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
            this.imageBlue.Image = XamarinPortableRes.Lib.Resources.MarkBlue.ToBitmap();
            this.imageGreen.Image = XamarinPortableRes.Lib.Resources.MarkGreen.ToBitmap();
            this.imageOrange.Image = XamarinPortableRes.Lib.Resources.MarkOrange.ToBitmap();
            this.imagePurple.Image = XamarinPortableRes.Lib.Resources.MarkPurple.ToBitmap();
            this.imageRed.Image = XamarinPortableRes.Lib.Resources.MarkRed.ToBitmap();
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
    }

    public static class StreamExtentions {
        /// <summary>
        /// Convert to Bitmap from System.IO.Stream
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public static UIImage ToBitmap(this System.IO.Stream st)
        {
            var data = NSData.FromStream(st);
            var bmp = UIImage.LoadFromData(data);
            return bmp;
        }
    }
}