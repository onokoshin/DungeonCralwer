using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : TabbedPage
	{
        //readonly Game gameTab;
        //readonly Score scoreTab; 
		public MainPage ()
		{
			InitializeComponent();
            //gameTab = new Game() { Title = "GAMETAB", Icon = "xamarin_logo.png" };
            //scoreTab = new Score() { Title = "SCORETAB", Icon = "xamarin_logo.png" };

            //Children.Add(gameTab);
            //Children.Add(scoreTab);
        }

        //public void SwitchToGameTab()
        //{
        //    CurrentPage = gameTab; 
        //}

        //public void SwitchToScoreTab()
        //{
        //    CurrentPage = scoreTab;
        //}


    }
}