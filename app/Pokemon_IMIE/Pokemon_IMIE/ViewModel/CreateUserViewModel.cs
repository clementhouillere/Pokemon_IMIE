using Pokemon_IMIE.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Pokemon_IMIE.ViewModel
{
    class CreateUserViewModel
    {
        private CreateUserView createUserView;

        public CreateUserView CreateUserView
        {
            get { return createUserView; }
            set { createUserView = value; }
        }

        public CreateUserViewModel(CreateUserView createUserView)
        {
            this.createUserView = createUserView;
            this.init();
            this.Bind();
        }


        public void Bind()
        {

        }

        private void init()
        {
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(CreateUserView));
        }
    }
}
