using System;
using System.IO;
using Xamarin.Forms;
using PropertySurvey;
using System.Runtime.Remoting.Contexts;
using PropertySurvey.Droid;
using Xamarin.Forms.Internals;
using Android.App;
using Android.Views;
using Android.Media;
using Android.Graphics;
using System.Collections.Generic;
using Android.Telephony;
//using Android.OS;
using Android.Provider;

[assembly: Xamarin.Forms.Dependency(typeof(CameraHelper))]
namespace PropertySurvey.Droid
{
    public class CameraHelper : ICameraHelper
    {
        public string GetIdentifier()
        {
            return Settings.Secure.GetString(Forms.Context.ContentResolver, Settings.Secure.AndroidId);

            //try
            //{
             //   TelephonyManager manager = (TelephonyManager)Forms.Context.GetSystemService(Android.Content.Context.TelephonyService);

            //    return manager.Imei;
            //}
            //catch
            //{
            //    return null;
            //}
        }
        public byte[] GenerateThumbImage(string path, int usecond)
        {
            MediaMetadataRetriever retriever = new MediaMetadataRetriever();
            retriever.SetDataSource(path);
            Bitmap bitmap = retriever.GetFrameAtTime(usecond);
            if (bitmap != null)
            {
                MemoryStream stream = new MemoryStream();
                bitmap.Compress(Bitmap.CompressFormat.Png, 0, stream);

                return stream.ToArray();
            }
            return null;
        }

        public void StartVideoCamera()
        {
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //return Path.Combine(path, filename);
            Forms.Context.StartActivity(typeof(VideoCameraActivity));
        }


        public void StartCameraOrientated()
        {
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //return Path.Combine(path, filename);
            //DeviceOrientation.

            //IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

            //var rotation = windowManager.DefaultDisplay.Rotation;
            //bool isLandscape = rotation == SurfaceOrientation.Rotation90 || rotation == SurfaceOrientation.Rotation270;
            //return isLandscape ? DeviceOrientations.Landscape : DeviceOrientations.Portrait;

            var displayRotation = MainActivity.Instance.WindowManager.DefaultDisplay.Rotation;
            bool isLandscape = displayRotation == SurfaceOrientation.Rotation90 || displayRotation == SurfaceOrientation.Rotation270;

            if (isLandscape == true)
                Forms.Context.StartActivity(typeof(CameraActivityLandscape));
            else
                Forms.Context.StartActivity(typeof(CameraActivity));
        }

        public void StartCamera()
        {
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //return Path.Combine(path, filename);
            Forms.Context.StartActivity(typeof(CameraActivity));
        }

        public void StartCameraLandscape()
        {
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //return Path.Combine(path, filename);
            Forms.Context.StartActivity(typeof(CameraActivityLandscape));
        }

        public void StartCameraLandscapeFixed()
        {
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //return Path.Combine(path, filename);
            Forms.Context.StartActivity(typeof(CameraActivityLandscapeFixed));
        }

    }
}
