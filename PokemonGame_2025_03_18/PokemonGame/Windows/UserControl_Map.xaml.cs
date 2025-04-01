using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PokemonGame.Windows
{
    public partial class UserControl_Map : UserControl
    {
        public GameEngine GameEngine { get; set; }


        public UserControl_Map()
        {
            InitializeComponent();
        }

        public void GenerateMap()
        {
            Random random = new Random();
            int numberOfEnemies = 3;

            //TODO: Opravit genrovanie nepriatelov aby sa neprekrivali
            //TODO: Vybranie nahodnej mapy (nahodne pozadie 3 MAP)


            //Generovanie mapy

            //vygenerovanie random cisla + vyhladanie mapy
            var generatedNumber = random.Next(0, 3);
            var choosedMap = GameEngine.Maps[generatedNumber];
            //pridanie mapy do Image
            Image_MapBG.Source = new BitmapImage(new Uri($"/Images/Maps/{choosedMap}.png", UriKind.Relative));

            //Generovanie nepriatelov
            for (int i = 1; i < numberOfEnemies + 1; i++) // nechceme zacat od 0 Levela pokemona, inak by pri prepocte vychadzal DMG random(20,80)*0 => 0, bol by z neho "fackovaci panacik"
            {
                //Mapa ma velkost 400 x 400 px
                var positionX = random.Next(25, 275);
                var positionY = random.Next(25, 275);
                string choosedPokemon = GameEngine.Pokemons[random.Next(0, 9)];


                Image image = new Image();
                {
                    image.Width = 50;
                    image.Height = 50;
                    image.Source = new BitmapImage(new Uri($"/Images/Pokemons/{choosedPokemon}.png", UriKind.Relative));
                    image.MouseLeftButtonDown += button_Click;
                }

                // Obalenie do Border pre pozadie
                Border border = new Border
                {
                    Width = 75,
                    Height = 75,
                    Background = new SolidColorBrush(Color.FromArgb(200, 211, 211, 211)), // LightGray s 50% priehľadnosťou
                    CornerRadius = new CornerRadius(25), // Polovica šírky/výšky -> kruh
                    BorderBrush = new SolidColorBrush(Colors.Black),
                    BorderThickness = new Thickness(1),
                    Margin = new Thickness(positionX, positionY, 0, 0),
                    Child = image
                };

                Grid_Map.Children.Add(border);

                Pokemon pokemon = new Pokemon(choosedPokemon, 200 + (100 * i), i, 200);
                GameEngine.Enemies.Add(image, pokemon);
            }
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            var image = (Image)sender;
            var pokemon = GameEngine.Enemies[image];

            GameEngine.SecondPokemon = pokemon;

            var Window_PokemonBattle = new Window_PokemonBattle(GameEngine);
            Window_PokemonBattle.Show();
        }
    }
}
