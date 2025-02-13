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

namespace Pokemon_Fight.Windows
{
    /// <summary>
    /// Interaction logic for Window_PokemonBattle.xaml
    /// </summary>
    public partial class Window_PokemonBattle : Window
    {
        public GameEngine GameEngine { get; set; }
        public List<string> PokemonFight { get; set; } = new List<string>();
        public Window_PokemonBattle(GameEngine gameEngine)
        {
            InitializeComponent();
            GameEngine = gameEngine;
            RefresElements();


        }
        private void RefresElements()
        {
            ProgressBar_Pokemon1_HP.Value = GameEngine.FirstPokemon.Health;
            label_Pokemon_1HP.Content = $" {GameEngine.FirstPokemon.Health} / {GameEngine.FirstPokemon.MaxHealth}";

            ProgressBar_Pokemon_2HP.Value = GameEngine.LastPokemon.Health;
            label_Pokemon_2HP.Content = $" {GameEngine.LastPokemon.Health} / {GameEngine.LastPokemon.MaxHealth}";

            ListView_FightLogger.Items.Clear();

            foreach (var log in PokemonFight)
            {
                ListView_FightLogger.Items.Add(log);
            }

            if (GameEngine.FirstPokemon.Health <= 0)
            {
                label_Pokemon_2HP.Content = "Winnner ";
                label_Pokemon_1HP.Content = "Looooooser";
               
            }

            if (GameEngine.LastPokemon.Health <= 0) 
            {
                label_Pokemon_1HP.Content = "Winnner ";
                label_Pokemon_2HP.Content = "Looooooser";
               
            }
            if (GameEngine.FirstPokemon.Health <= 0 || GameEngine.LastPokemon.Health <= 0) 
            { 
                Light.IsEnabled = false;                
                Medium.IsEnabled = false;                
                Bolt.IsEnabled = false;                
                Heal.IsEnabled = false;
            }
        }
        private void AIAtack()
        {
            Random rnd = new Random();
            var value = rnd.Next(0, 99);

            if (value < 10)
            {
                var damage = GameEngine.LastPokemon.Attack();
                var pokemonSurvive = GameEngine.FirstPokemon.TakeDamage(damage);

                PokemonFight.Add($"{GameEngine.LastPokemon.Name} used Light Attack and dealt {damage} damage to {GameEngine.FirstPokemon.Name}");

            }
            else if (value >= 10 && value < 30)
            {
                var damage = GameEngine.LastPokemon.Attack2();
                var pokemonSurvive = GameEngine.FirstPokemon.TakeDamage(damage);

                PokemonFight.Add($"{GameEngine.LastPokemon.Name} used Medium Light Attack and dealt {damage} damage to {GameEngine.FirstPokemon.Name}");

            }
            else if (value >= 30 && value < 80)
            {
                var damage = GameEngine.LastPokemon.Attack3();
                var pokemonSurvive = GameEngine.FirstPokemon.TakeDamage(damage);

                PokemonFight.Add($"{GameEngine.LastPokemon.Name} used Bolt Attack and dealt {damage} damage to {GameEngine.FirstPokemon.Name}");
            }
            else if (value >= 80)
            {
                var heal = GameEngine.LastPokemon.Heal();
                GameEngine.LastPokemon.TakeHeal(heal);
                PokemonFight.Add($"{GameEngine.LastPokemon.Name} used heal and healt {heal}");

            }
        }

        // light pikachu
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var damage = GameEngine.FirstPokemon.Attack();
            var pokemonSurvive = GameEngine.LastPokemon.TakeDamage(damage);

            PokemonFight.Add($"{GameEngine.FirstPokemon.Name} used Light Attack and dealt {damage} damage to {GameEngine.LastPokemon.Name}");

            if (pokemonSurvive)
            {
                AIAtack();
            }

            RefresElements();



        }
        //M LIght pikachu
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var damage = GameEngine.FirstPokemon.Attack2();
            var pokemonSurvive = GameEngine.LastPokemon.TakeDamage(damage);

            PokemonFight.Add($"{GameEngine.FirstPokemon.Name} used Medium Light Attack and dealt {damage} damage to {GameEngine.LastPokemon.Name}");

            if (pokemonSurvive)
            {
                AIAtack();
            }
            RefresElements();



        }
        //|Bolt pikachu
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var damage = GameEngine.FirstPokemon.Attack3();
            var pokemonSurvive = GameEngine.LastPokemon.TakeDamage(damage);

            PokemonFight.Add($"{GameEngine.FirstPokemon.Name} used Bolt Attack and dealt {damage} damage to {GameEngine.LastPokemon.Name}");

            if (pokemonSurvive)
            {
                AIAtack();
            }
            RefresElements();

        }
        //Heal Pikachu
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var heal = GameEngine.FirstPokemon.Heal();
            GameEngine.FirstPokemon.TakeHeal(heal);

            PokemonFight.Add($"{GameEngine.FirstPokemon.Name} used heal and healt {heal} ");

            AIAtack();
            RefresElements();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
