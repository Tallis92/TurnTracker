using TurnTracker.Views;

namespace TurnTracker
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnManageCombatClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EditEncounterPage());
        }
    }

}
