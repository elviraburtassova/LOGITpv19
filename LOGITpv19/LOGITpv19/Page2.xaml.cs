using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LOGITpv19
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		bool vkl;
		public Page2()
		{
			InitializeComponent();
		}
		Random rnd = new Random();
		private async void on_Clicked(object sender, EventArgs e)
		{
		vkl = true;
		while (true)
			{
				red.BackgroundColor = Color.Red;
				yellow.BackgroundColor = Color.Gray;
				green.BackgroundColor = Color.Gray;
				await Task.Run(() => Thread.Sleep(3000));
				for (int i = 0; i < 3; i++);
				{
					yellow.BackgroundColor = Color.Yellow;
					red.BackgroundColor = Color.Gray;
					green.BackgroundColor = Color.Gray;
					await Task.Run(() => Thread.Sleep(500));
				}
				green.BackgroundColor = Color.Green;
				red.BackgroundColor = Color.Gray;
				yellow.BackgroundColor = Color.Gray;
				await Task.Run(() => Thread.Sleep(3000));
			}
		
		}

		private void off_Clicked(object sender, EventArgs e)
		{
			red.BackgroundColor = Color.Gray;
			yellow.BackgroundColor = Color.Gray;
			green.BackgroundColor = Color.Gray;
			vkl = false;
		}

		private void Random_Clicked(object sender, EventArgs e)
		{
			int r = rnd.Next(0, 255);
			int g = rnd.Next(0, 255);
			int b = rnd.Next(0, 255);
			red.BackgroundColor = Color.FromRgb(r, g, b);
			r = rnd.Next(0, 255);
			g = rnd.Next(0, 255);
			b = rnd.Next(0, 255);
			yellow.BackgroundColor = Color.FromRgb(r, g, b);
			r = rnd.Next(0, 255);
			g = rnd.Next(0, 255);
			b = rnd.Next(0, 255);
			green.BackgroundColor = Color.FromRgb(r, g, b);
			r = rnd.Next(0, 255);
			g = rnd.Next(0, 255);
			b = rnd.Next(0, 255);
		}

		private async void Bublik_Clicked(object sender, EventArgs e)
		{
			red.Opacity = 0.5;
			yel.CornerRadius = 0;
			green.Text = "Bublik ...";
			int r = rnd.Next(0, 255);
			int g = rnd.Next(0, 255);
			int b = rnd.Next(0, 255);
			red.BackgroundColor = Color.FromRgb(r, g, b);
			gren.BorderColor = Color.FromRgb(r, g, b);
			gren.HasShadow = true;
			bool answer = await DisplayAlert("Color change", "Do you want to change the color? New color for red", "Yes", "No");
			if (answer)
			{
				red.BackgroundColor = Color.FromRgb(r, g, b);
			}
			else
			{
				red.BackgroundColor = Color.FromRgb(0,0,0);
			}
		}
	}
}