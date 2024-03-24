using TurnTracker.Models;

namespace TurnTracker.Views;

public partial class CombatPage : ContentPage
{
    Encounter savedEncounter = new Encounter();
    internal CombatPage(Encounter selectedEncounter)
    {
        InitializeComponent();

        savedEncounter = selectedEncounter;
        PlayerList.ItemsSource = savedEncounter.EncounterPlayers;
        CreatureList.ItemsSource = savedEncounter.EncounterCreatures;


    }



    private void OnRollInitiativeClicked(object sender, EventArgs e)
    {
        Random rnd = new Random();
        List<Combatant> combatants = new List<Combatant>();
        RollInitiativeButton.IsVisible = false;

        foreach (var creature in savedEncounter.EncounterCreatures)
        {
            creature.Initiative = rnd.Next(1, 20) + creature.Initiative;
            combatants.Add(new Combatant { Name = creature.Name, Initiative = creature.Initiative });
        }
        foreach (var player in savedEncounter.EncounterPlayers)
        {
            combatants.Add(new Combatant { Name = player.Name, Initiative = player.Initiative });
        }
        List<Combatant> sortedCombatatants = combatants.OrderByDescending(x => x.Initiative).ToList();
        CombatList.ItemsSource = sortedCombatatants;

    }

    internal class Combatant()
    {
        public string Name { get; set; }
        public int Initiative { get; set; }
    }

    internal void EditCombatant(object sender, SelectedItemChangedEventArgs e)
    {

        Creature selectedCreature = ((ListView)sender).SelectedItem as Creature;
        Managers.SingletonManager.GetSingleton().SetCreature(selectedCreature);
        CreatureName.Text = "  " + selectedCreature.Name;
        CreatureHP.Text = "HP: " + selectedCreature.CurrentHP + "/" + selectedCreature.MaxHP;
    }

    private void OnUpdateCreatureHPClicked(object sender, EventArgs e)
    {
        Creature selectedCreature = Managers.SingletonManager.GetSingleton().GetCreature();
        if (selectedCreature != null)
        {

            if (UpdateCreatureHP.Text != null)
            {
                if (UpdateCreatureHP.Text.StartsWith('-'))
                {
                    UpdateCreatureHP.Text = UpdateCreatureHP.Text.Replace("-", "");
                    if (int.TryParse(UpdateCreatureHP.Text, out int subtractValue))
                    {
                        selectedCreature.CurrentHP = selectedCreature.CurrentHP - subtractValue;
                        if (selectedCreature.CurrentHP <= 0)
                        {
                            selectedCreature.CurrentHP = 0;

                        }
                    }
                    else
                    {
                        DisplayAlert("Warning!", "You must input a numerical value!", "Ok!");
                    }

                }

                else if (UpdateCreatureHP.Text.StartsWith('+'))
                {
                    UpdateCreatureHP.Text.Replace("+", "");
                    if (int.TryParse(UpdateCreatureHP.Text, out int addValue))
                    {
                        selectedCreature.CurrentHP += addValue;
                    }
                }

                else if (int.TryParse(UpdateCreatureHP.Text, out int newValue))
                {
                    selectedCreature.CurrentHP = newValue;
                    if (selectedCreature.CurrentHP <= 0)
                    {
                        selectedCreature.CurrentHP = 0;

                    }
                }
                else
                {
                    DisplayAlert("Warning!", "You must input a numerical value!", "Ok!");
                }

                CreatureHP.Text = "HP: " + selectedCreature.CurrentHP + " / " + selectedCreature.MaxHP;
                CreatureList.ItemsSource = savedEncounter.EncounterCreatures.OrderBy(x => x.Name);
            }
            else
            {
                DisplayAlert("Warning!", "Please input a new HP value for the selected creature!", "Ok!");
            }
        }
        else
        {
            DisplayAlert("Warning!", "Error, no creature found!", "Ok!");
        }
    }
}