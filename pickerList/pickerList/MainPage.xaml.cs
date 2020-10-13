using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace pickerList
{
    public partial class MainPage : ContentPage
    {
        public HumanViewModel ViewModel;
        public MainPage()
        {
            InitializeComponent();

            ViewModel = new HumanViewModel();
            BindingContext = ViewModel;
            //if (BindingContext != null)
            //{
            //    Device.BeginInvokeOnMainThread(() =>
            //    {
            //        pick.ItemsSource = (System.Collections.IList)ViewModel.Results;
            //    });
            //}
        }
    }
}
