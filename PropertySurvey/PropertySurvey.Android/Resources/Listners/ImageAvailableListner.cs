
using Android.Graphics;
using Android.Media;
using Android.Widget;
using Java.IO;
using Java.Lang;
using Java.Nio;
using System.IO;

namespace PropertySurvey.Droid.Listeners
{
    public class ImageAvailableListener : Java.Lang.Object, ImageReader.IOnImageAvailableListener
    {
        public ImageAvailableListener(Camera2BasicFragment fragment, Java.IO.File file)
        {
            if (fragment == null)
                throw new System.ArgumentNullException("fragment");
            if (file == null)
                throw new System.ArgumentNullException("file");

            owner = fragment;
            this.file = file;
        }

        public void UpdateFile(Java.IO.File file)
        {
            this.file = file;
        }
        private Java.IO.File file;
        private readonly Camera2BasicFragment owner;

        public void UpdateFileName(string fname)
        {
            this.last_filename = this.filename;
            this.filename = fname;
        }
        string filename = "";
        string last_filename = "";
        //public File File { get; private set; }
        //public Camera2BasicFragment Owner { get; private set; }

        public Bitmap rotateImage(int angle, Bitmap bitmapSrc)
        {
            Matrix matrix = new Matrix();
            matrix.PostRotate(angle);
            return Bitmap.CreateBitmap(bitmapSrc, 0, 0,
                bitmapSrc.Width, bitmapSrc.Height, matrix, true);
        }
        
        public void OnImageAvailable(ImageReader reader)
        {
            App.net.PhotoComplete();
            App.net.ShutterSound();
            App.net.bSavingPhoto = true;
            try
            {
                Image pic = reader.AcquireNextImage();
                SaveImage(pic, file);
            }
            catch(Exception e)
            {

            }
            App.net.bSavingPhoto = false;
            //App.net.mBackgroundHandler.Post(new ImageSaver(reader.AcquireNextImage(), file));

            /*
            if (App.net.photos_taken > App.net.photos_required)
            {

            }
            else
            {
                
            }
            App.net.photos_taken++;
            if (this.last_filename != this.filename)
            {
                string path = filename;// Owner.mFile.Name.ToString();
                int pos = path.LastIndexOf("/") + 1;
                string line_no = System.Int32.Parse(path.Substring(pos, path.Length - pos).Substring(0, 20)).ToString();

                App.net.add_to_que("ADDPHOTO", line_no, 0, "", filename, App.net.photos_taken, 0);

                if (App.net.photos_taken >= App.net.photos_required)
                {
                    //Owner.vi
                    App.Database.SetLineState(App.net.current_line_number, App.net.current_line_state);
                    App.net.add_to_que("SETSTATE", line_no, App.net.current_line_state, "", "", App.net.photos_taken, 0);
                    //App.UpdateList();
                    App.net.UpdateListItem(App.net.current_line_state, App.net.photos_taken);
                    App.net.SendNextTask();
                    //App.net.
                }
            }
            */

        }

        // The JPEG image
        private Image mImage;
        bool image_closed = false;
        // The file we save the image into.
        private Java.IO.File mFile;

        private void SaveImage(Image image, Java.IO.File file)
        {
            int height = image.Height;
            int width = image.Width;
            if (image == null)
                throw new System.ArgumentNullException("image");
            if (file == null)
                throw new System.ArgumentNullException("file");

            //image.

            image_closed = false;



            mImage = image;
            mFile = file;

            try
            {
                if (image_closed == false)
                {
                    ByteBuffer buffer = mImage.GetPlanes()[0].Buffer;
                    int size = buffer.Remaining();
                    byte[] bytes = new byte[size];
                    buffer.Get(bytes);
                    //string fname = mFile.Name;
                    
                    //Bitmap bmp = BitmapFactory.DecodeByteArray(bytes, 0, size);

                    //Bitmap rotated = rotateImage(90, bmp);

                    //mFile.Path

                    //string path = Path.Combine(Environment.GetExternalStoragePublicDirectory(Environment.DirectoryPictures).AbsolutePath, "newProdict.png");
                    /*
                    var fs = new FileStream(mFile.Path.ToString(), FileMode.CreateNew, FileAccess.Write);
                    if (fs != null)
                    {
                        bmp.Compress(Bitmap.CompressFormat.Png, 90, fs);
                        fs.Close();
                    }
                    */

                    
                    using (var output = new FileOutputStream(mFile))
                    {
                       // rotated.Compress(Bitmap.CompressFormat.Png, 100, output);

                        
                        try
                        {
                            output.Write(bytes);
                        }
                        catch (Java.IO.IOException e)
                        {
                            e.PrintStackTrace();
                        }
                        finally
                        {
                            mImage.Close();
                        }
                       
                    }
                    

                }
            }
            catch (Java.IO.IOException e)
            {

            }
            
            if(false)
            {

                ExifInterface newExif = new ExifInterface(owner.fileService.CreatePathToFile("Photos/" + mFile.Name));
                //newExif.SetAttribute(ExifInterface.TagOrientation, "90");
                string orient = newExif.GetAttribute(ExifInterface.TagOrientation);
                //newExif.SetAttribute(ExifInterface.TagGpsLatitude, "teste lat");
                //newExif.SetAttribute(ExifInterface.TagGpsLatitudeRef, "teste lat ref");
                //newExif.SetAttribute(ExifInterface.TagGpsLongitude, "teste long");
                //newExif.SetAttribute(ExifInterface.TagGpsLongitudeRef, "teste long ref");
                //newExif.SaveAttributes();
            }
        }

        // Saves a JPEG {@link Image} into the specified {@link File}.
        private class ImageSaver : Java.Lang.Object, IRunnable
        {
            // The JPEG image
            private Image mImage;

            // The file we save the image into.
            private Java.IO.File mFile;

            public ImageSaver(Image image, Java.IO.File file)
            {
                if (image == null)
                    throw new System.ArgumentNullException("image");
                if (file == null)
                    throw new System.ArgumentNullException("file");

                mImage = image;
                mFile = file;
            }

            public void Run()
            {
                try
                {

                    ByteBuffer buffer = mImage.GetPlanes()[0].Buffer;
                    byte[] bytes = new byte[buffer.Remaining()];
                    buffer.Get(bytes);
                    //string fname = mFile.Name;

                    using (var output = new FileOutputStream(mFile))
                    {
                        try
                        {
                            output.Write(bytes);
                        }
                        catch (Java.IO.IOException e)
                        {
                            e.PrintStackTrace();
                        }
                        finally
                        {
                            mImage.Close();
                        }
                    }
                }
                catch (Java.IO.IOException e)
                {

                }
            }
        }
    }
}