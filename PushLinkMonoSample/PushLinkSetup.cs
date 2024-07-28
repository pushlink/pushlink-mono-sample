using Android.App;
using Com.Pushlink.Android;


namespace PushLinkMonoSample
{

    [Application]
    public class PushLinkSetup : Application
    {
        protected PushLinkSetup(System.IntPtr javaReference, Android.Runtime.JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
        public override void OnCreate()
        {
            PushLink.Start(this, Resource.Mipmap.ic_launcher, "yourApiKey", "yourDeviceId");
        }
    }

}
