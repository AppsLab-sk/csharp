using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

namespace Pokemon_Game.Windows
{
    /// <summary>
    /// Interaction logic for Window_PokemonBattle.xaml
    /// </summary>
    public partial class Window_PokemonBattle : Window
    {
        public GameEngine GameEngine {  get; set; }
        public List<string> FightLogger { get; set; } = new List<string>();
        public Window_PokemonBattle(GameEngine gameEngine)
        {
            InitializeComponent();
            GameEngine = gameEngine;
            RefreshElements();
        }

        private void RefreshElements()
        {
            ProgressBar_Pokemon1_HP.Value = GameEngine.FirstPokemon.Health;
            Label_Pokemon1_HP.Content = $"{GameEngine.FirstPokemon.Health} / {GameEngine.FirstPokemon.MaxHealth}";

            ProgressBar_Pokemon2_HP.Value = GameEngine.SecondPokemon.Health;
            Label_Pokemon2_HP.Content = $"{GameEngine.SecondPokemon.Health} / {GameEngine.SecondPokemon.MaxHealth}";

            ListView_FightLogger.Items.Clear();
            foreach (var log in FightLogger)
            {
                ListView_FightLogger.Items.Add(log);
            }

            // Pokemon 1 vypis

            if (GameEngine.FirstPokemon.Health <= 0)
            {
                Label_Pokemon1_HP.Content = "LOSER!";
                Label_Pokemon2_HP.Content = "WINNER!";
            }

            // Pokemon 2 vypis

            if (GameEngine.SecondPokemon.Health <= 0)
            {
                Label_Pokemon1_HP.Content = "WINNER!";
                Label_Pokemon2_HP.Content = "LOSER!";
            }

            // Vypnutie tlacitok

            if (GameEngine.SecondPokemon.Health <= 0 || GameEngine.FirstPokemon.Health <= 0)
            {
                Button_LightAttack.IsEnabled = false;
                Button_MediumAttack.IsEnabled = false;
                Button_CriticalAttack.IsEnabled = false;
                Button_Heal.IsEnabled = false;
            }
        }

        private void AIAttack()
        {
            Random random = new Random();
            var value = random.Next(0, 99);

            // Light attack AI

            if (value < 10)
            {
                var damage = GameEngine.SecondPokemon.Attack1();
                var pokemonSurvived = GameEngine.FirstPokemon.TakeDamage(damage);
                FightLogger.Add($"{GameEngine.SecondPokemon.Name} used Light Attack and dealt {damage} damage to {GameEngine.FirstPokemon.Name}.");
            }

            // Medium attack AI

            else if (value >= 10 && value < 30)
            {
                var damage = GameEngine.SecondPokemon.Attack2();
                var pokemonSurvived = GameEngine.FirstPokemon.TakeDamage(damage);
                FightLogger.Add($"{GameEngine.SecondPokemon.Name} used Light Attack and dealt {damage} damage to {GameEngine.FirstPokemon.Name}.");
            }

            // Critical attack AI

            else if (value >= 30 && value < 80)
            {
                var damage = GameEngine.SecondPokemon.Attack3();
                var pokemonSurvived = GameEngine.FirstPokemon.TakeDamage(damage);
                FightLogger.Add($"{GameEngine.SecondPokemon.Name} used Light Attack and dealt {damage} damage to {GameEngine.FirstPokemon.Name}.");
            }

            // Heal AI

            else if (value >= 80)
            {
                var heal = GameEngine.SecondPokemon.Heal();
                GameEngine.FirstPokemon.TakeHeal(heal);
                FightLogger.Add($"{GameEngine.SecondPokemon.Name} used Heal was healed by {heal}.");
            }
        }

        // Light attack player

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var damage = GameEngine.FirstPokemon.Attack1();
            var pokemonSurvived = GameEngine.SecondPokemon.TakeDamage(damage);
            FightLogger.Add($"{GameEngine.FirstPokemon.Name} used Light Attack and dealt {damage} damage to {GameEngine.SecondPokemon.Name}.");

            if (pokemonSurvived)
            {
                AIAttack();
            }

            RefreshElements();
        }

        // Medium attack player

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var damage = GameEngine.FirstPokemon.Attack2();
            var pokemonSurvived = GameEngine.SecondPokemon.TakeDamage(damage);
            FightLogger.Add($"{GameEngine.FirstPokemon.Name} used Medium Attack and dealt {damage} damage to {GameEngine.SecondPokemon.Name}.");

            if (pokemonSurvived)
            {
                AIAttack();
            }

            RefreshElements();
        }

        // Critical attack player

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var damage = GameEngine.FirstPokemon.Attack3();
            var pokemonSurvived = GameEngine.SecondPokemon.TakeDamage(damage);
            FightLogger.Add($"{GameEngine.FirstPokemon.Name} used Critical Attack and dealt {damage} damage to {GameEngine.SecondPokemon.Name}.");

            if (pokemonSurvived)
            {
                AIAttack();
            }

            RefreshElements();
        }

        // Heal player

        private void Button_Heal_Click(object sender, RoutedEventArgs e)
        {
            var heal = GameEngine.FirstPokemon.Heal();
            GameEngine.FirstPokemon.TakeHeal(heal);
            FightLogger.Add($"{GameEngine.FirstPokemon.Name} used Heal was healed by {heal}.");

            AIAttack();
            RefreshElements();
        }
    }
}
