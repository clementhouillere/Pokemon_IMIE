// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

using Pokemon_IMIE.Pages;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace Pokemon_IMIE.usercontrols
{
    public sealed partial class MainButton : BaseUserControl
    {
        public MainButton()
        {
            this.InitializeComponent();
            base.DataContext = this;
        }


        public String Label
        {
            get { return (string)base.GetValue(LabelProperty); }
            set { base.SetValue(LabelProperty, value); }
        }

        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(MainButton), null);
    }
}
