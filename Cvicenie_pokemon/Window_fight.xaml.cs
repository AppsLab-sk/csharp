using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Metrics;
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

namespace Cvicenie_pokemon
{
    //+"\n"+"adadf"
    public partial class Window_fight : Window
    {
        public Hero myActualHero { get; set; }
        public Priserkabojimbojim myActualEnemy { get; set; }
        public Window_fight(Hero myhero, Priserkabojimbojim myenemy)
        {
            InitializeComponent();
            myActualHero = myhero;
            myActualEnemy = myenemy;

            ProgressbarHP.Value = myhero.Helth;
            ProgressbarHP.Maximum = myhero.MaximumHelth;
            Label_HP.Content = ProgressbarHP.Value + "/" + ProgressbarHP.Maximum + "\n" + myActualHero.ActualEnergy + "/" + myActualHero.MaxEnergy;

            ProgressBar_enemy.Maximum = myenemy.MaximumHelth;
            ProgressBar_enemy.Value = myenemy.Helth;
            Label_enemyHP.Content = ProgressBar_enemy.Value + "/" + ProgressBar_enemy.Maximum;
        }

        private void Hero_demage_Click(object sender, RoutedEventArgs e)
        {

            EnemyattackHero(1);
            HeroAttackEnemy(1);
            CheckHp();
            InitializeComponent();
        }
        private void HeroAttackEnemy(int demagescale)
        {
            myActualEnemy.Helth -= myActualHero.Demage * demagescale;
            if (myActualEnemy.Helth < 0)
            {
                myActualEnemy.Helth = 0;
            }
            Label_enemyHP.Content = myActualEnemy.Helth + "/" + myActualEnemy.MaximumHelth ;

            ProgressBar_enemy.Value = myActualEnemy.Helth;
        }
        private void EnemyattackHero(int demagescale2)
        {
            myActualHero.Helth -= myActualEnemy.Demage * demagescale2;
            if (myActualHero.Helth < 0) { myActualHero.Helth = 0; }
            myActualHero.ActualEnergy -=10;
            if (myActualHero.ActualEnergy < 0) 
            {
                myActualHero.Helth=0; 
                demagescale2 = 0;
            }
            Label_HP.Content = myActualHero.Helth + "/" + myActualHero.MaximumHelth +"\n" + myActualHero.ActualEnergy  + "/" + myActualHero.MaxEnergy;
            ProgressbarHP.Value = myActualHero.Helth;
        }

        private void Mid_Herodemage_Click(object sender, RoutedEventArgs e)
        {
            EnemyattackHero(1);
            HeroAttackEnemy(3);
            CheckHp();
            InitializeComponent();
        }

        private void Hard_HeroDemage_Click(object sender, RoutedEventArgs e)
        {
            EnemyattackHero(1);
            HeroAttackEnemy(5);
            CheckHp();
            InitializeComponent();
        }
        private void CheckHp() 
        {
            if(myActualHero.Helth <= 0)
            {
                Game_status.Content = "Lost";
            }
            if (myActualEnemy.Helth <= 0)
            {

                Game_status.Content = "Win";
            }


        }

    }
}
