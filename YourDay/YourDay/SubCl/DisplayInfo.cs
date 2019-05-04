using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace YourDay.SubCl
{
  public class DisplayInfo
    {
        public double WidthScreen { get; set; }
        public double HeighScreen { get; set; }
        public double DensityScreen { get; set; }
        public DisplayOrientation OrientationScreen { get; set; }
        public DisplayRotation RotationScreen { get; set; }
        public DisplayInfo()
        {
            DeviceDisplay.MainDisplayInfoChanged += OnMainDisplayInfoChanged;

            // Get Metrics
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

            // Orientation (Landscape, Portrait, Square, Unknown)
            OrientationScreen = mainDisplayInfo.Orientation;

            // Rotation (0, 90, 180, 270)
            RotationScreen = mainDisplayInfo.Rotation;

            // Width (in pixels)
            WidthScreen = mainDisplayInfo.Width;

            // Height (in pixels)
            HeighScreen = mainDisplayInfo.Height;

            // Screen density
            DensityScreen = mainDisplayInfo.Density;
        }
        public void ToggleScreenLock()
        {
            DeviceDisplay.KeepScreenOn = !DeviceDisplay.KeepScreenOn;
        }
        private void OnMainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            var displayInfo = e.DisplayInfo;

        }
    }
}
