using System;


[assembly: Xamarin.Forms.Dependency(typeof( dependencyinjection.iOS.iOSCameraController))]
namespace dependencyinjection.iOS
{
	public class iOSCameraController : ICameraController
	{
		public iOSCameraController()
		{

		}

        public byte[] TakePhoto()
        {
            throw new NotImplementedException();
        }

        public string TestText()
        {
            return "this is the iOS implementation.";
        }
    }
}
