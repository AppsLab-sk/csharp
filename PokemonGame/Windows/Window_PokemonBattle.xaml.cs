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

namespace PokemonGame.Windows
{
    /// <summary>
    /// Interaction logic for Window_PokemonBattle.xaml
    /// </summary>
    public partial class Window_PokemonBattle : Window
    {
        public GameEngine GameEngine {  get; set; } = new GameEngine();
        public Window_PokemonBattle()
        {
            InitializeComponent();
            
            RefreshElements();

        }
        private void RefreshElements()
        {
            ProgressBar_Pokemon1_HP.Value = GameEngine.FirstPokemon.Health;
            Label_Pokemon1_HP.Content = $"{GameEngine.FirstPokemon.Health} / 100";

            ProgressBar_Pokemon2_HP.Value = GameEngine.SecondPokemon.Health;
            Label_Pokemon2_HP.Content = $"{GameEngine.SecondPokemon.Health} / 100";
        }
        private void AIAttack()
        {
            Random rnd = new Random();
            var value = rnd.Next(0, 99);
            if (value < 33)
            {
                var damage = GameEngine.SecondPokemon.Attack1();
                var pokemonSurvived = GameEngine.FirstPokemon.TakeDamage(damage);
            }
            else if (value > 33 && value < 90)
            {
                var damage = GameEngine.SecondPokemon.Attack2();
                var pokemonSurvived = GameEngine.FirstPokemon.TakeDamage(damage);
            }
            else if(value > 90)
            {
                var damage = GameEngine.SecondPokemon.Attack2();
                var pokemonSurvived = GameEngine.FirstPokemon.TakeDamage(damage);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var damage = GameEngine.FirstPokemon.Attack1();
            var pokemonSurvived = GameEngine.SecondPokemon.TakeDamage(damage);
            RefreshElements();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var damage = GameEngine.FirstPokemon.Attack2();
            var pokemonSurvived = GameEngine.SecondPokemon.TakeDamage(damage);
            RefreshElements();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var damage = GameEngine.FirstPokemon.Attack3();
            var pokemonSurvived = GameEngine.SecondPokemon.TakeDamage(damage);
            AIAttack();
            RefreshElements();
        }
    }
}
