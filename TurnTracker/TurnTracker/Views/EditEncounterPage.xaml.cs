using TurnTracker.Models;

namespace TurnTracker.Views;

public partial class EditEncounterPage : ContentPage
{
    int amountOfPlayers = 1;
    int amountOfNPC = 1;
    List<PlayerCharacter> players = new List<PlayerCharacter>();
    List<Creature> creatures = new List<Creature>();
    Encounter selectedEncounter = new Encounter();

    public EditEncounterPage()
    {
        InitializeComponent();
    }

    private void OnAddPCClicked(object sender, EventArgs e)
    {
        if (amountOfPlayers >= 6)
        {
            DisplayAlert("Warning!", "Playercount can't exceed 6!", "Ok");
        }
        else
        {
            amountOfPlayers++;
            DisplayPlayerEntries();
        }
    }
    private void OnRemovePCClicked(object sender, EventArgs e)
    {
        if (amountOfPlayers <= 1)
        {
            DisplayAlert("Warning!", "Playercount can't be below 1 players", "Ok");
        }
        else
        {
            amountOfPlayers--;
            DisplayPlayerEntries();
        }
    }
    private void OnAddPCsClicked(object sender, EventArgs e)
    {
        AddPCButton.IsVisible = false;
        RemovePCButton.IsVisible = false;
        ResetPCButton.IsVisible = true;
        AddListOfPCsButton.IsVisible = false;
        if (PC1.Text != null && PC1Initiative.Text != null)
        {
            if (int.TryParse(PC1Initiative.Text, out int initiative))
            {
                players.Add(new PlayerCharacter() { Name = PC1.Text, Initiative = initiative });
                PC1.Text = "";
                PC1Initiative.Text = "";
            }
            else
            {
                DisplayAlert("Warning!", "Initiative has to be a number!", "Ok");
            }
        }
        if (PC2.Text != null && PC2Initiative.Text != null)
        {
            if (int.TryParse(PC2Initiative.Text, out int initiative))
            {
                players.Add(new PlayerCharacter() { Name = PC2.Text, Initiative = initiative });
                PC2.Text = "";
                PC2Initiative.Text = "";
            }
            else
            {
                DisplayAlert("Warning!", "Initiative has to be a number!", "Ok");
            }
        }
        if (PC3.Text != null && PC3Initiative.Text != null)
        {
            if (int.TryParse(PC3Initiative.Text, out int initiative))
            {
                players.Add(new PlayerCharacter() { Name = PC3.Text, Initiative = initiative });
                PC3.Text = "";
                PC3Initiative.Text = "";
            }
            else
            {
                DisplayAlert("Warning!", "Initiative has to be a number!", "Ok");
            }
        }
        if (PC4.Text != null && PC4Initiative.Text != null)
        {
            if (int.TryParse(PC4Initiative.Text, out int initiative))
            {
                players.Add(new PlayerCharacter() { Name = PC4.Text, Initiative = initiative });
                PC4.Text = "";
                PC4Initiative.Text = "";
            }
            else
            {
                DisplayAlert("Warning!", "Initiative has to be a number!", "Ok");
            }
        }
        if (PC5.Text != null && PC5Initiative.Text != null)
        {
            if (int.TryParse(PC5Initiative.Text, out int initiative))
            {
                players.Add(new PlayerCharacter() { Name = PC5.Text, Initiative = initiative });
                PC5.Text = "";
                PC5Initiative.Text = "";
            }
            else
            {
                DisplayAlert("Warning!", "Initiative has to be a number!", "Ok");
            }
        }
        if (PC6.Text != null && PC6Initiative.Text != null)
        {
            if (int.TryParse(PC6Initiative.Text, out int initiative))
            {
                players.Add(new PlayerCharacter() { Name = PC6.Text, Initiative = initiative });
                PC6.Text = "";
                PC6Initiative.Text = "";
            }
            else
            {
                DisplayAlert("Warning!", "Initiative has to be a number!", "Ok");
            }
        }
    }

    private void OnResetClicked(object sender, EventArgs e)
    {
        players.Clear();
        AddPCButton.IsVisible = true;
        RemovePCButton.IsVisible = true;
        AddListOfPCsButton.IsVisible = true;
        ResetPCButton.IsVisible = false;
    }
    private void DisplayPlayerEntries()
    {
        switch (amountOfPlayers)
        {
            case 1:
                PC2.IsVisible = false;
                PC2Initiative.IsVisible = false;
                break;
            case 2:
                PC2.IsVisible = true;
                PC2Initiative.IsVisible = true;

                PC3.IsVisible = false;
                PC3Initiative.IsVisible = false;
                break;
            case 3:
                PC3.IsVisible = true;
                PC3Initiative.IsVisible = true;

                PC4.IsVisible = false;
                PC4Initiative.IsVisible = false;
                break;
            case 4:
                PC4.IsVisible = true;
                PC4Initiative.IsVisible = true;

                PC5.IsVisible = false;
                PC5Initiative.IsVisible = false;
                break;
            case 5:
                PC5.IsVisible = true;
                PC5Initiative.IsVisible = true;

                PC6.IsVisible = false;
                PC6Initiative.IsVisible = false;
                break;
            case 6:
                PC6.IsVisible = true;
                PC6Initiative.IsVisible = true;
                break;
        }
    }

    private void OnAddNPCClicked(object sender, EventArgs e)
    {
        if (amountOfNPC >= 6)
        {
            DisplayAlert("Warning!", "You can't have more than 6 types of creatures in an encounter!", "Ok");
        }
        else
        {
            amountOfNPC++;
            DisplayNPCEntries();
        }
    }

    private void OnRemoveNPCClicked(object sender, EventArgs e)
    {
        if (amountOfNPC <= 1)
        {
            DisplayAlert("Warning!", "You must have at least one type of creatures in an encounter!", "Ok");
        }
        else
        {
            amountOfNPC--;
            DisplayNPCEntries();
        }
    }

    private void DisplayNPCEntries()
    {
        switch (amountOfNPC)
        {
            case 1:
                Creature2Entry.IsVisible = false;
                Creature2AmountEntry.IsVisible = false;
                Creature2InitiativeEntry.IsVisible = false;
                Creature2HPEntry.IsVisible = false;
                break;
            case 2:
                Creature2Entry.IsVisible = true;
                Creature2AmountEntry.IsVisible = true;
                Creature2InitiativeEntry.IsVisible = true;
                Creature2HPEntry.IsVisible = true;

                Creature3Entry.IsVisible = false;
                Creature3AmountEntry.IsVisible = false;
                Creature3InitiativeEntry.IsVisible = false;
                Creature3HPEntry.IsVisible = false;
                break;
            case 3:
                Creature3Entry.IsVisible = true;
                Creature3AmountEntry.IsVisible = true;
                Creature3InitiativeEntry.IsVisible = true;
                Creature3HPEntry.IsVisible = true;

                Creature4Entry.IsVisible = false;
                Creature4AmountEntry.IsVisible = false;
                Creature4InitiativeEntry.IsVisible = false;
                Creature4HPEntry.IsVisible = false;
                break;
            case 4:
                Creature4Entry.IsVisible = true;
                Creature4AmountEntry.IsVisible = true;
                Creature4InitiativeEntry.IsVisible = true;
                Creature4HPEntry.IsVisible = true;

                Creature5Entry.IsVisible = false;
                Creature5AmountEntry.IsVisible = false;
                Creature5InitiativeEntry.IsVisible = false;
                Creature5HPEntry.IsVisible = false;
                break;
            case 5:
                Creature5Entry.IsVisible = true;
                Creature5AmountEntry.IsVisible = true;
                Creature5InitiativeEntry.IsVisible = true;
                Creature5HPEntry.IsVisible = true;

                Creature6Entry.IsVisible = false;
                Creature6AmountEntry.IsVisible = false;
                Creature6InitiativeEntry.IsVisible = false;
                Creature6HPEntry.IsVisible = false;
                break;
            case 6:
                Creature6Entry.IsVisible = true;
                Creature6AmountEntry.IsVisible = true;
                Creature6InitiativeEntry.IsVisible = true;
                Creature6HPEntry.IsVisible = true;
                break;
        }
    }

    private void OnAddNPCsClicked(object sender, EventArgs e)
    {
        AddNPCButton.IsVisible = false;
        RemoveNPCButton.IsVisible = false;
        ResetNPCButton.IsVisible = true;
        AddListOfNPCButton.IsVisible = false;

        if (Creature1Entry.Text != null && Creature1AmountEntry.Text != null && Creature1InitiativeEntry != null && Creature1HPEntry != null)
        {
            if (int.TryParse(Creature1AmountEntry.Text, out int amount) && int.TryParse(Creature1InitiativeEntry.Text, out int initiative) && int.TryParse(Creature1HPEntry.Text, out int maxHP))
            {
                for (int i = 0; i < amount; i++)
                {
                    creatures.Add(new Creature { Name = Creature1Entry.Text + (i + 1), Initiative = initiative, MaxHP = maxHP, CurrentHP = maxHP });
                }
            }
            else
            {
                DisplayAlert("Warning!", "Initiative, Amount and Max HP has to be a number!", "Ok");
            }
        }

        if (Creature2Entry.Text != null && Creature2AmountEntry.Text != null && Creature2InitiativeEntry != null && Creature2HPEntry != null)
        {
            if (int.TryParse(Creature2AmountEntry.Text, out int amount) && int.TryParse(Creature2InitiativeEntry.Text, out int initiative) && int.TryParse(Creature2HPEntry.Text, out int maxHP))
            {
                for (int i = 0; i < amount; i++)
                {
                    creatures.Add(new Creature { Name = Creature2Entry.Text + (i + 1), Initiative = initiative, MaxHP = maxHP, CurrentHP = maxHP });
                }
            }
            else
            {
                DisplayAlert("Warning!", "Initiative, Amount and Max HP has to be a number!", "Ok");
            }
        }

        if (Creature3Entry.Text != null && Creature3AmountEntry.Text != null && Creature3InitiativeEntry != null && Creature3HPEntry != null)
        {
            if (int.TryParse(Creature3AmountEntry.Text, out int amount) && int.TryParse(Creature3InitiativeEntry.Text, out int initiative) && int.TryParse(Creature3HPEntry.Text, out int maxHP))
            {
                for (int i = 0; i < amount; i++)
                {
                    creatures.Add(new Creature { Name = Creature3Entry.Text + (i + 1), Initiative = initiative, MaxHP = maxHP, CurrentHP = maxHP });
                }
            }
            else
            {
                DisplayAlert("Warning!", "Initiative, Amount and Max HP has to be a number!", "Ok");
            }
        }

        if (Creature4Entry.Text != null && Creature4AmountEntry.Text != null && Creature4InitiativeEntry != null && Creature4HPEntry != null)
        {
            if (int.TryParse(Creature4AmountEntry.Text, out int amount) && int.TryParse(Creature4InitiativeEntry.Text, out int initiative) && int.TryParse(Creature4HPEntry.Text, out int maxHP))
            {
                for (int i = 0; i < amount; i++)
                {
                    creatures.Add(new Creature { Name = Creature4Entry.Text + (i + 1), Initiative = initiative, MaxHP = maxHP, CurrentHP = maxHP });
                }
            }
            else
            {
                DisplayAlert("Warning!", "Initiative, Amount and Max HP has to be a number!", "Ok");
            }
        }

        if (Creature5Entry.Text != null && Creature1AmountEntry.Text != null && Creature5InitiativeEntry != null && Creature5HPEntry != null)
        {
            if (int.TryParse(Creature5AmountEntry.Text, out int amount) && int.TryParse(Creature5InitiativeEntry.Text, out int initiative) && int.TryParse(Creature5HPEntry.Text, out int maxHP))
            {
                for (int i = 0; i < amount; i++)
                {
                    creatures.Add(new Creature { Name = Creature5Entry.Text + (i + 1), Initiative = initiative, MaxHP = maxHP, CurrentHP = maxHP });
                }
            }
            else
            {
                DisplayAlert("Warning!", "Initiative, Amount and Max HP has to be a number!", "Ok");
            }
        }

        if (Creature6Entry.Text != null && Creature6AmountEntry.Text != null && Creature6InitiativeEntry != null && Creature6HPEntry != null)
        {
            if (int.TryParse(Creature6AmountEntry.Text, out int amount) && int.TryParse(Creature6InitiativeEntry.Text, out int initiative) && int.TryParse(Creature6HPEntry.Text, out int maxHP))
            {
                for (int i = 0; i < amount; i++)
                {
                    creatures.Add(new Creature { Name = Creature6Entry.Text + (i + 1), Initiative = initiative, MaxHP = maxHP, CurrentHP = maxHP });
                }
            }
            else
            {
                DisplayAlert("Warning!", "Initiative, Amount and Max HP has to be a number!", "Ok");
            }
        }
    }

    private void OnResetNPCClicked(object sender, EventArgs e)
    {
        creatures.Clear();
        AddNPCButton.IsVisible = true;
        RemoveNPCButton.IsVisible = true;
        AddListOfNPCButton.IsVisible = true;
        ResetNPCButton.IsVisible = false;
    }

    private async void GoToCombatClicked(object sender, EventArgs e)
    {

        if (creatures.Count > 0 && players.Count > 0)
        {
            selectedEncounter = new Encounter() { EncounterPlayers = players, EncounterCreatures = creatures };

            await Navigation.PushAsync(new CombatPage(selectedEncounter));
        }
        else
        {
            DisplayAlert("Warning!", "You must have at least 1 player and 1 set of creatures to start combat!", "Ok!");
        }
    }
}