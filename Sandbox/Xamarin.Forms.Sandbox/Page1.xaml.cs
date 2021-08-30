using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Forms.Sandbox
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1()
		{
			InitializeComponent();
		}

		async void Button_Clicked(object sender, EventArgs e)
		{
			try
			{
				Debug.WriteLine("Button_Clicked begin");
				await Navigation.PushModalAsync(new Page2(), false);
				var poppedPage = await Navigation.PopAsync(false);
				if (poppedPage != this)
					throw new Exception($"Nav stack inconsistent: expected popped page {this} but got {poppedPage} from PopAsync");
				else if(Navigation.NavigationStack.Contains(this))
					throw new Exception($"Nav stack inconsistent: popped page {this} still on nav stack after PopAsync");
				Debug.WriteLine("Button_Clicked end");
			}
			catch(Exception ex)
			{
				await DisplayAlert("Error", ex.ToString(), "OK");
			}
		}
	}
}