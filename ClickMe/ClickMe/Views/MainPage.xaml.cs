using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ClickMe.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private double _clickNumber = (int)Device.GetNamedSize(NamedSize.Small, typeof(Label));
        public double ClickNumber
        {
            get { return _clickNumber; }

            set
            {
                if (_clickNumber == value)
                    return;

                _clickNumber = value;
                OnPropertyChanged();
            }
        }

        public void ButtonClick(object sender, EventArgs arg)
        {
            ClickNumber *= 1.5;
        }
    }
}
