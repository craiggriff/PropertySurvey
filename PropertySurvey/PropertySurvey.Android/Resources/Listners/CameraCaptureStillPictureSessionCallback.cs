using Android.App;
using Android.Hardware.Camera2;
using Android.Util;

namespace PropertySurvey.Droid.Listeners
{
    public class CameraCaptureStillPictureSessionCallback : CameraCaptureSession.CaptureCallback
    {
        private static readonly string TAG = "CameraCaptureStillPictureSessionCallback";

        public Camera2BasicFragment Owner { get; set; }

        private System.Threading.Timer timer;

        public CameraCaptureStillPictureSessionCallback(Camera2BasicFragment owner)
        {
            Owner = owner;
        }

        public override void OnCaptureCompleted(CameraCaptureSession session, CaptureRequest request, TotalCaptureResult result)
        {
            //Owner.ShowToast("Saved: " + Owner.mFile);

            //Log.Debug(TAG, Owner.mFile.ToString());

            //result.Request.Keys.

            // int pt = App.net.photos_taken;//.ToString()
            Owner.ShowToast((App.net.photos_taken+1+ App.net.total_photos).ToString());
            Log.Debug(TAG, Owner.mFile.ToString());
            //Finish();
            //Activity.FragmentManager().popBackStack();
            //FragmentManager.
            //Camera2BasicFragment.

            //Owner.Fin();
            // Owner.getActivity().getFragmentManager().popBackStack();
            //Owner.OnStop();
            //Owner.getActivity().getF
            //Owner.getActivity().getFragmentManager()

            // Owner.getActivity().FragmentManager.PopBackStack();

            //App.net.AddPhotoSync(Owner.mFile.ToString());





            Owner.UnlockFocus();
            //Owner.OnDestroyView();
            //Owner.OnPause();
            //Owner.OnStop();
            //Owner.OnDestroyView();
            //Owner.OnDestroy();
            /*
            if (App.net.photos_taken == App.net.photos_required)
            {
                
                // timer to make sure it is saved
                CameraActivity myActivity = (CameraActivity)Owner.Activity;
                myActivity.onFin();


            }*/

            if (App.net.photos_taken >= App.net.photos_required - 1)
            {
                //Android.OS.SystemClock.Sleep(1000);
                //SystemClock.sleep(7000);
                // timer to make sure it is saved
                //App.net.pCamera.UpdateFileList();
                if (App.net.camera_landscape_mode == true)
                {
                    CameraActivityLandscapeFixed myActivity = (CameraActivityLandscapeFixed)Owner.Activity;
                    
                    myActivity.onFin();
                }
                else
                {
                    if (App.net.is_landscape == true)
                    {
                        CameraActivityLandscape myActivity = (CameraActivityLandscape)Owner.Activity;
                        myActivity.onFin();
                    }
                    else
                    {
                        CameraActivity myActivity = (CameraActivity)Owner.Activity;
                        myActivity.onFin();
                    }
                }
                


            }
            else
            {
                App.net.photos_taken++;
                App.net.image_number++;

                App.net.CreatePhotoFilename();

                //Button but = (Button)view.FindViewById(Resource.Id.p1);//.FindViewById(R.id.Player1);
                //but.Text = App.net.photos_taken.ToString() + "/" + App.net.photos_required.ToString();
               // Owner.num_button.Text = App.net.photos_taken.ToString() + "/" + App.net.photos_required.ToString();
            }

        }
    }
}