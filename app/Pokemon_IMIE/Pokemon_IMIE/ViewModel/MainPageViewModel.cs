using Pokemon_IMIE.Pages;

namespace Pokemon_IMIE.ViewModel
{
    class MainPageViewModel
    {
        private MainPageView mainPageView;

        public MainPageView MainPageView
        {
            get { return mainPageView; }
            set { mainPageView = value; }
        }

        public MainPageViewModel(MainPageView mainPageView)
        {
            this.mainPageView = mainPageView;
            this.init();
            this.Bind();
        }


        public void Bind()
        {

        }

        private void init()
        {
        }
    }
}
