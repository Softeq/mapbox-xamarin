using System;
using CoreLocation;
using Foundation;
using MapboxBindingIOS;
using UIKit;

namespace MapBoxSampleIOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle) { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            MGLAccountManager.AccessToken = @"pk.eyJ1Ijoid2hhdHN1cDEwMjkiLCJhIjoiY2pycnlidWh6MDM5YTN5dGN0ZTl6dWYwdCJ9.lAT_WwGQug0vz-ball4t1Q";

            var mapView = new MGLMapView(View.Bounds, new NSUrl("mapbox://styles/mapbox/light-v9"))
            {
                WeakDelegate = this
            };

            var center = new CLLocationCoordinate2D(29.7604, -95.3698);

            mapView.SetCenterCoordinate(center, zoomLevel: 8, direction: 0, animated: false);

            mapView.MinimumZoomLevel = 8;
            mapView.MaximumZoomLevel = 15;

            View.AddSubview(mapView);
        }
    }
}