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

            MGLAccountManager.AccessToken = @"insert";

            var mapView = new MGLMapView(
               View.Bounds,
               new NSUrl("mapbox://styles/naxamtest/cj5kin5x21li42soxdx3mb1yt")
           );
            this.View.AddSubview(mapView);
            mapView.WeakDelegate = this;

            mapView.SetCenterCoordinate(new CLLocationCoordinate2D(21.028511, 105.804817), 11, false);

            var temple = new MGLPointAnnotation
            {
                Title = "Temple of literature",
                Subtitle = "Van Mieu - Quoc Tu Giam",
                Coordinate = new CLLocationCoordinate2D(21.0276, 105.8355)
            };

            mapView.AddAnnotation((MGLAnnotation)temple);

            var newLayer = new MGLSymbolStyleLayer(Guid.NewGuid().ToString(), new MGLSource("xxx"))
            {
                IconImageName = NSExpression.FromConstant(new NSString("temple")),
                IconOpacity = NSExpression.FromConstant(NSNumber.FromDouble(0.7))
            };
        }
    }
}