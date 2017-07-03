using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinApp.Mvvm.View
{
    public partial class HeaderContentPage : ContentPage
    {
        private Xamarin.Forms.View _mainContent;

        public HeaderContentPage()
        {
            InitializeComponent();
        }
        public Xamarin.Forms.View MainContent
        {
            get { return _mainContent; }

            set
            {
                if (_mainContent != value)
                {
                    _mainContent = value;
                    MainContentContainer.Children.Clear();
                    MainContentContainer.Children.Add(_mainContent);

                    OnPropertyChanged("MainContent");
                }
            }
        }
    }
}
