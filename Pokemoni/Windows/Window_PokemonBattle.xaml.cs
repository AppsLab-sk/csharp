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

namespace Pokemoni.Windows
{
    /// <summary>
    /// Interaction logic for Window_PokemonBattle.xaml
    /// </summary>
    public partial class Window_PokemonBattle : Window
    {
        public GameEngine GameEngine { get; set; } 
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
            Label1_Pokemon1_HP.Content = $"{GameEngine.FirstPokemon.Health} / {GameEngine.FirstPokemon.MaxHealth}";

            ProgressBar_Pokemon2_HP.Value = GameEngine.SecondPokemon.Health;
            Label2_Pokemon2_HP.Content = $"{GameEngine.SecondPokemon.Health} / {GameEngine.FirstPokemon.MaxHealth}";
            //Zobrazenie vsetkych sprav z boja
            ListView_FightLogger.Items.Clear();
            foreach (var log in FightLogger)
            {
                ListView_FightLogger.Items.Add(log);
            }
            if (GameEngine.FirstPokemon.Health <= 0)
            {
                Label1_Pokemon1_HP.Content = "LOSER!";
                Label2_Pokemon2_HP.Content = "WINNER!";
            }
            if (GameEngine.SecondPokemon.Health <= 0)
            {
                Label1_Pokemon1_HP.Content = "WINNER!";
                Label2_Pokemon2_HP.Content = "LOSER!";
            }
            if (GameEngine.SecondPokemon.Health <= 0 || GameEngine.FirstPokemon.Health <= 0)
            {
                Button_LA.IsEnabled = false;
                Button_MA.IsEnabled = false;
                Button_HA.IsEnabled = false;
                Button_Heal.IsEnabled = false;
            }



        }
        public void AIAttack()
        {
            Random rnd = new Random();
            var value = rnd.Next(0, 99);

            if (value < 10)
            {
                var damage = GameEngine.SecondPokemon.Attack1();
                var pokemonSurvived = GameEngine.FirstPokemon.TakeDamage(damage);
                FightLogger.Add($"{GameEngine.SecondPokemon.Name} used Light Attack and dealt {damage} damage to {GameEngine.FirstPokemon.Name}");

            }

            else if (value > 10 && value < 30)
            {
                var damage = GameEngine.SecondPokemon.Attack2();
                var pokemonSurvived = GameEngine.FirstPokemon.TakeDamage(damage);
                FightLogger.Add($"{GameEngine.SecondPokemon.Name} used Medium Attack and dealt {damage} damage to {GameEngine.FirstPokemon.Name}");
            }
            else if (value > 30 && value < 80)
            {
                var damage = GameEngine.SecondPokemon.Attack3();
                var pokemonSurvived = GameEngine.FirstPokemon.TakeDamage(damage);
                FightLogger.Add($"{GameEngine.SecondPokemon.Name} used Light Attack and dealt {damage} damage to {GameEngine.FirstPokemon.Name}");
            }
            else if (value > 80)
            {
                var heal = GameEngine.SecondPokemon.Heal();
                GameEngine.SecondPokemon.TakeHeal(heal);
                FightLogger.Add($"{GameEngine.FirstPokemon.Name} used Heal and was healed by {heal}.");
            }
        }





        //medium attack
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var damage = GameEngine.FirstPokemon.Attack2();
            var pokemonSurvived = GameEngine.SecondPokemon.TakeDamage(damage);
            FightLogger.Add($"{GameEngine.SecondPokemon.Name} used Medium Attack and dealt {damage} damage to {GameEngine.FirstPokemon.Name}");
            AIAttack();
            RefreshElements();
        }
        //critical attack
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var damage = GameEngine.FirstPokemon.Attack3();
            var pokemonSurvived = GameEngine.SecondPokemon.TakeDamage(damage);
            FightLogger.Add($"{GameEngine.SecondPokemon.Name} used High Attack and dealt {damage} damage to {GameEngine.FirstPokemon.Name}");
            AIAttack();
            RefreshElements();
        }
        //Heal
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var heal = GameEngine.FirstPokemon.Heal();
            GameEngine.FirstPokemon.TakeHeal(heal);
            FightLogger.Add($"{GameEngine.SecondPokemon.Name} used Heal and was healed by {heal}.");
           
            AIAttack();
            RefreshElements();
        }
        //Light Attack
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var damage = GameEngine.FirstPokemon.Attack1();
            var pokemonSurvived = GameEngine.FirstPokemon.TakeDamage(damage);
            FightLogger.Add($"{GameEngine.SecondPokemon.Name} used Light Attack and dealt {damage} damage to {GameEngine.FirstPokemon.Name}");

            if (pokemonSurvived)
            {
                AIAttack();
            }


            AIAttack();
            RefreshElements();
        }
    }
}



















