using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamFormExp.ViewModel;

namespace XamFormExp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void TestButton_Clicked(object sender,EventArgs e)
        {
            var temp = MainListViewModel.GetMainListViewModelDemoData(10);
            await DisplayAlert("Result", "Returned from ViewModel", "OK");
        }
    }
}
