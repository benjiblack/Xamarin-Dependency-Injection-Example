using Xamarin.Forms;

namespace dependencyinjection
{
    public partial class dependencyinjectionPage : ContentPage
    {
        //Define dependency injection interface
        ICameraController cameraController = DependencyService.Get<ICameraController>();

        public dependencyinjectionPage()
        {
            InitializeComponent();

            helloWorldLabel.Text = cameraController.TestText();
        }
    }
}
