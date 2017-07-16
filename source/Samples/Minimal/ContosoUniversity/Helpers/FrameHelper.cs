using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ContosoUniversity.Helpers
{
    public static class FrameHelper
    {
        public static Frame MainFrame
        {
            get { return (Frame)Window.Current.Content; }
        }
    }
}
