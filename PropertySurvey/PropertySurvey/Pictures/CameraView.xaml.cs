using PropertySurvey.CustomViews;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PropertySurvey
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CameraView : ContentPage
    {
        public CameraView()
        {
            InitializeComponent();
            CameraPreview.PictureFinished += OnPictureFinished;

            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += OnCameraClicked;
            CameraPreview.GestureRecognizers.Add(tap);
        }

        void OnCameraClicked(object sender, EventArgs e)
        {
            CameraPreview.CameraClick.Execute(null);
        }

        private void OnPictureFinished()
        {
            App.files.SaveBinary("Photos/" + App.net.photo_fname, App.cameraImage);
            App.net.photos_taken++;
            App.net.image_number++;
            Title = App.net.photos_taken.ToString();

            App.net.CreatePhotoFilename();
        }
    }
}