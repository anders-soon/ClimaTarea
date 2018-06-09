using ElClimaUDEO.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;

namespace ElClimaUDEO.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WeatherPage : ContentPage
	{
		public WeatherPage ()
		{
			InitializeComponent ();
            this.BindingContext = new WeatherViewModel();

        }

        

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void SearchBar_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            var oldText = e.OldTextValue;
            var newText = e.NewTextValue;
        }

       
    }
}