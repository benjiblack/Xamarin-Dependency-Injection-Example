using System;
namespace dependencyinjection
{
    public interface ICameraController
    {
		byte[] TakePhoto(); //Make implementation return photo as byte array.
		string TestText(); //Return test text for example.
	}
}
