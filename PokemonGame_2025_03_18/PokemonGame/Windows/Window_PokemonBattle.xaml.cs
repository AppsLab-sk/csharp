using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace PokemonGame.Windows
{
    public partial class Window_PokemonBattle : Window
    {
        public GameEngine GameEngine { get; set; }
        public List<string> FightLogger { get; set; } = new List<string>();

        public Window_PokemonBattle(GameEngine gameEngine)
        {
            InitializeComponent();

            GameEngine = gameEngine;

            //Prefight setup
            ProgressBar_Pokemon1_HP.Maximum = GameEngine.FirstPokemon.MaxHealth;
            ProgressBar_Pokemon2_HP.Maximum = GameEngine.SecondPokemon.MaxHealth;

            ProgressBar_Pokemon1_Energy.Maximum = GameEngine.FirstPokemon.MaxEnergy;
            ProgressBar_Pokemon2_Energy.Maximum = GameEngine.SecondPokemon.MaxEnergy;

            //Refresh pokemon picture
            var choosedEnemy = GameEngine.SecondPokemon;
            Image_SecondEnemy.Source = new BitmapImage(new Uri($"/Images/Pokemons/{choosedEnemy.Name}.png", UriKind.Relative));

            //Heal pokemons before fight
            GameEngine.FirstPokemon.TakeHeal(GameEngine.FirstPokemon.MaxHealth);
            GameEngine.SecondPokemon.Health = GameEngine.SecondPokemon.MaxHealth;

            RefreshElements();
        }

        private void RefreshElements()
        {
            //Zobrazenie spravneho poctu zivotov 
            ProgressBar_Pokemon1_HP.Value = GameEngine.FirstPokemon.Health;
            Label_Pokemon1_HP.Content = $"{GameEngine.FirstPokemon.Health} / {GameEngine.FirstPokemon.MaxHealth}";

            ProgressBar_Pokemon2_HP.Value = GameEngine.SecondPokemon.Health;
            Label_Pokemon2_HP.Content = $"{GameEngine.SecondPokemon.Health} / {GameEngine.SecondPokemon.MaxHealth}";

            //Zobrazenie spravneho poctu energie
            ProgressBar_Pokemon1_Energy.Value = GameEngine.FirstPokemon.Energy;
            Label_Pokemon1_Energy.Content = $"{GameEngine.FirstPokemon.Energy} / {GameEngine.FirstPokemon.MaxEnergy}";

            ProgressBar_Pokemon2_Energy.Value = GameEngine.SecondPokemon.Energy;
            Label_Pokemon2_Energy.Content = $"{GameEngine.SecondPokemon.Energy} / {GameEngine.SecondPokemon.MaxEnergy}";

            //Zobrazenie vsetkych sprav z boja
            ListView_FightLogger.Items.Clear();
            foreach (var log in FightLogger)
            {
                ListView_FightLogger.Items.Add(log);
            }

            if (GameEngine.FirstPokemon.Health <= 0)
            {
                Label_Pokemon1_HP.Content = "LOSER!";
                Label_Pokemon2_HP.Content = "WINNER!";
            }
            if (GameEngine.SecondPokemon.Health <= 0)
            {
                Label_Pokemon1_HP.Content = "WINNER!";
                Label_Pokemon2_HP.Content = "LOSER!";

                GameEngine.TakeXP(300 * GameEngine.SecondPokemon.Level);
            }
            if (GameEngine.SecondPokemon.Health <= 0 || GameEngine.FirstPokemon.Health <= 0)
            {
                Button_LA.IsEnabled = false;
                Button_MA.IsEnabled = false;
                Button_HA.IsEnabled = false;
                Button_Heal.IsEnabled = false;
            }
            if  (GameEngine.FirstPokemon.Energy <= 0)
            {
                Button_LA.IsEnabled = false;
                Button_Heal.IsEnabled = false;
            }
            if (GameEngine.FirstPokemon.Energy <= 50)
            {
                Button_MA.IsEnabled = false;
            }
            if (GameEngine.FirstPokemon.Energy <=100)
            {
                Button_HA.IsEnabled = false;
            }
        }

        private void AIAttack()
        {
            Random rnd = new Random();
            var value = rnd.Next(0, 5);

            if (value < 10)
            {
                var energyAttack = GameEngine.SecondPokemon.Energy_Attack1();
                var energyTake = GameEngine.SecondPokemon.TakeEnergy(energyAttack);
                var damage = GameEngine.SecondPokemon.Attack1();
                var pokemonSurvived = GameEngine.FirstPokemon.TakeDamage(damage);
                FightLogger.Add($"{GameEngine.SecondPokemon.Name} used Light Attack and dealt {damage} damage to {GameEngine.FirstPokemon.Name}");
            }
            else if (value >= 10 && value < 30)
            {
                var energyAttack = GameEngine.SecondPokemon.Energy_Attack2();
                var energyTake = GameEngine.SecondPokemon.TakeEnergy(energyAttack);
                var damage = GameEngine.SecondPokemon.Attack2();
                var pokemonSurvived = GameEngine.FirstPokemon.TakeDamage(damage);
                FightLogger.Add($"{GameEngine.SecondPokemon.Name} used Medium Attack and dealt {damage} damage to {GameEngine.FirstPokemon.Name}");
            }
            else if (value >= 30 && value < 80)
            {
                var energyAttack = GameEngine.SecondPokemon.Energy_Attack3();
                var energyTake = GameEngine.SecondPokemon.TakeEnergy(energyAttack);
                var damage = GameEngine.SecondPokemon.Attack3();
                var pokemonSurvived = GameEngine.FirstPokemon.TakeDamage(damage);
                FightLogger.Add($"{GameEngine.SecondPokemon.Name} used High Attack and dealt {damage} damage to {GameEngine.FirstPokemon.Name}");
            }
            else if (value >= 80)
            {
                var heal = GameEngine.SecondPokemon.Heal();
                GameEngine.SecondPokemon.TakeHeal(heal);
                FightLogger.Add($"{GameEngine.SecondPokemon.Name} used Heal and was healed by {heal}.");
            }
        }

        //Light Attack
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var energyAttack = GameEngine.FirstPokemon.Energy_Attack1();
            var energyTake = GameEngine.FirstPokemon.TakeEnergy(energyAttack);
            var damage = GameEngine.FirstPokemon.Attack1();
            var pokemonSurvived = GameEngine.SecondPokemon.TakeDamage(damage);
            FightLogger.Add($"{GameEngine.FirstPokemon.Name} used Light Attack and dealt {damage} damage to {GameEngine.SecondPokemon.Name}");

            if (pokemonSurvived)
            {
                AIAttack();
            }

            RefreshElements();
        }

        //Medium Attack
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var energyAttack = GameEngine.FirstPokemon.Energy_Attack2();
            var energyTake = GameEngine.FirstPokemon.TakeEnergy(energyAttack);
            var damage = GameEngine.FirstPokemon.Attack2();
            var pokemonSurvived = GameEngine.SecondPokemon.TakeDamage(damage);
            FightLogger.Add($"{GameEngine.FirstPokemon.Name} used Medium Attack and dealt {damage} damage to {GameEngine.SecondPokemon.Name}");

            if (pokemonSurvived)
            {
                AIAttack();
            }
            RefreshElements();
        }

        //High Attack
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var energyAttack = GameEngine.FirstPokemon.Energy_Attack3();
            var energyTake = GameEngine.FirstPokemon.TakeEnergy(energyAttack);
            var damage = GameEngine.FirstPokemon.Attack3();
            var pokemonSurvived = GameEngine.SecondPokemon.TakeDamage(damage);
            FightLogger.Add($"{GameEngine.FirstPokemon.Name} used High Attack and dealt {damage} damage to {GameEngine.SecondPokemon.Name}");

            if (pokemonSurvived)
            {
                AIAttack();
            }
            RefreshElements();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var heal = GameEngine.FirstPokemon.Heal();
            GameEngine.FirstPokemon.TakeHeal(heal);
            FightLogger.Add($"{GameEngine.FirstPokemon.Name} used Heal and was healed by {heal}.");

            AIAttack();

            RefreshElements();
        }
    }
}
