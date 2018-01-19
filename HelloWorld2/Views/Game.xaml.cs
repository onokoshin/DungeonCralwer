using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Game : ContentPage
    {
        public Game()
        {
            InitializeComponent();       
        }

        async void ScorePageButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Score());
        }

        async void CharacterPageButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Character());
        }

        async void InventoryPageButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Inventory());
        }

        async void MonstersPageButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Monster());
        }

        async void ItemPageButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ItemPage());
        }

        async void BattlePageButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BattlePage());
        }

        

    }
}
