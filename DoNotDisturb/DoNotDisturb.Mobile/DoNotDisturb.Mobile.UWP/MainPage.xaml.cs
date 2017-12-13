using Caliburn.Micro;
using Shared = DoNotDisturb.Mobile; // required for VSTemplate

namespace DoNotDisturb.Mobile.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(IoC.Get<Shared.App>());
        }
    }
}
