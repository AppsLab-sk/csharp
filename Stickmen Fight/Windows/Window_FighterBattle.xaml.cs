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

namespace Stickmen_Fight.Windows
{
    /// <summary>
    /// Interaction logic for Window_FighterBattle.xaml 
    /// </summary>
    public partial class Window_FighterBattle : Window
    {
        //Properties
        public GameEngine gameEngine { get; set; }
        public List<string> FightLogger { get; set; } = new List<string>();
        public Window_FighterBattle(GameEngine GameEngine)
        {
            InitializeComponent();
            gameEngine = GameEngine;
            RefreshElements();
        }

        //Refresher
        private void RefreshElements()
        {
            ProgressBar_Pokemon1_HP.Value = gameEngine.FirstFighter.health;
            Label_Pokemon2_HP.Content = gameEngine.FirstFighter.health + "/" + gameEngine.FirstFighter.maxHealth;

            ProgressBar_Pokemon2_HP.Value = gameEngine.SecondFighter.health;
            Label_Pokemon2_HP.Content = gameEngine.SecondFighter.health + "/" + gameEngine.SecondFighter.maxHealth;

            ListBox_FightLog.Items.Clear();
            foreach (var log in FightLogger)
            {
                ListBox_FightLog.Items.Add(log);
            }

            if (gameEngine.FirstFighter.health <= 0)
            {
                Label_Pokemon1_HP.Content = "Looser!";
                Label_Pokemon2_HP.Content = "Winner!";
            }
            else if (gameEngine.SecondFighter.health <= 0)
            {
                Label_Pokemon1_HP.Content = "Winner!";
                Label_Pokemon2_HP.Content = "Looser!";
            }

            if (gameEngine.SecondFighter.health <= 0 || gameEngine.FirstFighter.health <= 0) 
            {
                Button_Pokemon1_LightAttack.IsEnabled = false;
                Button_Pokemon1_HardAttack.IsEnabled = false;
                Button_Pokemon1_Critical.IsEnabled = false;
                Button_Pokemon1_Heal.IsEnabled = false;
            }
        }

        //Light Attack
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var damage = gameEngine.FirstFighter.Attack1();
            var pokemonSurvive = gameEngine.SecondFighter.TakeDamage(damage);
            FightLogger.Add($"{gameEngine.FirstFighter.name} used light attack and dealed {damage} damage to {gameEngine.SecondFighter.name}!");

            if (pokemonSurvive)
            {
                AIattack();
            }
            
            RefreshElements();
        }

        //Hard Attack
        private void Button_Pokemon1_HardAttack_Click(object sender, RoutedEventArgs e)
        {
            var damage = gameEngine.FirstFighter.Attack2();
            var pokemonSurvive = gameEngine.SecondFighter.TakeDamage(damage);
            FightLogger.Add($"{gameEngine.FirstFighter.name} used hard attack and dealed {damage} damage to {gameEngine.SecondFighter.name}!");

            if (pokemonSurvive)
            {
                AIattack();
            }

            RefreshElements();
        }

        //Critical Attack
        private void Button_Pokemon1_Critical_Click(object sender, RoutedEventArgs e)
        {
            var damage = gameEngine.FirstFighter.Attack3();
            var pokemonSurvive = gameEngine.SecondFighter.TakeDamage(damage);
            FightLogger.Add($"{gameEngine.FirstFighter.name} used critical attack and dealed {damage} damage to {gameEngine.SecondFighter.name}!");

            if (pokemonSurvive)
            {
                AIattack();
            }

            RefreshElements();
        }

        //Heal
        private void Button_Pokemon1_Heal_Click(object sender, RoutedEventArgs e)
        {
            var healValue = gameEngine.FirstFighter.Heal();
            gameEngine.FirstFighter.TakeHeal(healValue);
            FightLogger.Add($"{gameEngine.FirstFighter.name} healed with {healValue} HP!");
            AIattack();
            RefreshElements();
        }

        //AI Attack
        private void AIattack()
        {
            Random random = new Random();
            var value = random.Next(0,99);

            if (value > 33)
            {
                var damage = gameEngine.FirstFighter.Attack1();
                var pokemonSurvive = gameEngine.FirstFighter.TakeDamage(damage);
                FightLogger.Add($"{gameEngine.SecondFighter.name} used light attack and dealed {damage} damage to {gameEngine.FirstFighter.name}!");
            }
            else if (value >= 33 && value < 69)
            {
                var damage = gameEngine.FirstFighter.Attack2();
                var pokemonSurvive = gameEngine.FirstFighter.TakeDamage(damage);
                FightLogger.Add($"{gameEngine.SecondFighter.name} used hard attack and dealed {damage} damage to {gameEngine.FirstFighter.name}!");
            }
            else if(value >= 69 && value < 80)
            {
                var damage = gameEngine.FirstFighter.Attack3();
                var pokemonSurvive = gameEngine.FirstFighter.TakeDamage(damage);
                FightLogger.Add($"{gameEngine.SecondFighter.name} used critical attack and dealed {damage} damage to {gameEngine.FirstFighter.name}!");
            }
            else if(value >= 80)
            {
                var healValue = gameEngine.SecondFighter.Heal();
                gameEngine.SecondFighter.TakeHeal(healValue);
                FightLogger.Add($"{gameEngine.SecondFighter.name} healed with {healValue} HP!");
            }
        }
    }
}
