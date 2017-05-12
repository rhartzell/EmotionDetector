// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace EmotionDetector
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton CrashMeButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel DetailsText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton TakePhotoButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView ThePhoto { get; set; }

		[Action ("UIButton9_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton9_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (CrashMeButton != null) {
				CrashMeButton.Dispose ();
				CrashMeButton = null;
			}
			if (DetailsText != null) {
				DetailsText.Dispose ();
				DetailsText = null;
			}
			if (TakePhotoButton != null) {
				TakePhotoButton.Dispose ();
				TakePhotoButton = null;
			}
			if (ThePhoto != null) {
				ThePhoto.Dispose ();
				ThePhoto = null;
			}
		}
	}
}
