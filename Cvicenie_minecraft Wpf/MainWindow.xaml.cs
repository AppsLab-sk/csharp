using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cvicenie_minecraft_Wpf
{
   
    public partial class MainWindow : Window
    {
        public string ImagePath { get; set; } = "C:\\Users\\Moskalm25\\Source\\Repos\\csharp\\Cvicenie_minecraft Wpf\\obrazky\\d8ebr67-ccb9b1ec-1d6e-4ffe-9552-9397c34a99c1 .png";

        List<armorpart> Armors_Helm = new List<armorpart>();
        List<armorpart> ArmorParts_Body = new List<armorpart>();
        List <armorpart> ArmorParts_Pant = new List<armorpart>();
        List <armorpart> ArmorParts_Leg = new List<armorpart>();
        public armorpart Head { get; set; }
        public armorpart Body { get; set; }
        public armorpart Pant { get; set; }
        public armorpart Leg { get; set; }
        private void UpdateLabels()
        {
            var playerSet = new List<armorpart>();

            if (Head != null)
                playerSet.Add(Head);
            if (Body != null)
                playerSet.Add(Body);
            if (Pant != null)
                playerSet.Add(Pant);
            if (Leg != null)
                playerSet.Add(Leg);

            int totalArmor = playerSet.Sum(x => x.Armorpower);

            Label_ActualArmor.Content = totalArmor;
            //PRepocitavanie a zapousivabnie do lablu
            var groupedItems = playerSet.GroupBy(p => p.ArmorType, (key, g) => new { ArmorType = key, Items = g.ToList() }).ToList();
            var multiplaierValue = groupedItems.OrderByDescending(x => x.Items.Count).First().Items.Count;
            Label_ArmorMultiplier.Content = multiplaierValue;

            var numberOfArmor = playerSet.Sum(x => x.Armorpower);
            Label_ArmorPowerValue.Content = $"{numberOfArmor} (+{multiplaierValue * numberOfArmor})";
        }
        public MainWindow()
        {
            InitializeComponent();

            Armors_Helm.Add(new armorpart("Plesinka", 0, EArmorType.none, EArmorPartName.Helmet, 28, 29, 100, 90));
                Armors_Helm.Add(new armorpart("Helma bronzova", 1, EArmorType.lether, EArmorPartName.Helmet, 28, 29, 100, 90));
                Armors_Helm.Add(new armorpart("Helma retiazkova", 2, EArmorType.chain, EArmorPartName.Helmet, 177, 29, 100, 90));
                Armors_Helm.Add(new armorpart("Helma zelezna", 5, EArmorType.iron, EArmorPartName.Helmet, 338, 29, 100, 90));
                Armors_Helm.Add(new armorpart("Helma zlata", 10, EArmorType.gold, EArmorPartName.Helmet, 505, 29, 100, 90));
            Armors_Helm.Add(new armorpart("Helma diamantova", 20, EArmorType.diamond, EArmorPartName.Helmet, 659, 29, 100, 90));
           
            combox_Helmpicker.ItemsSource = Armors_Helm;

            ArmorParts_Body.Add(new armorpart("Hola hrud", 0, EArmorType.none, EArmorPartName.Chestplate  , 0, 0, 0, 0));
            ArmorParts_Body.Add(new armorpart("Body bronzove", 5, EArmorType.lether , EArmorPartName.Chestplate, 7, 136, 139, 130));
            ArmorParts_Body.Add(new armorpart("Body retiazkove", 10, EArmorType.chain, EArmorPartName.Chestplate, 159, 136, 139, 130));
            ArmorParts_Body.Add(new armorpart("Body zelezne", 15, EArmorType.iron, EArmorPartName.Chestplate, 321, 136, 139, 130));
            ArmorParts_Body.Add(new armorpart("Body zlate", 30, EArmorType.gold, EArmorPartName.Chestplate, 486, 136, 139, 130));
            ArmorParts_Body.Add(new armorpart("Body diamantove", 50, EArmorType.diamond, EArmorPartName.Chestplate, 639, 136, 139, 130));
            ComboBox_BodyPicker.ItemsSource = ArmorParts_Body;

            ArmorParts_Pant.Add(new armorpart("Trenky", 0, EArmorType.none, EArmorPartName.nohavice, 0, 0, 0, 0));
            ArmorParts_Pant.Add(new armorpart("Nohavice bronzove", 2, EArmorType.lether, EArmorPartName.nohavice, 26, 279, 100, 131));
            ArmorParts_Pant.Add(new armorpart("Nohavice retiazkove", 4, EArmorType.chain, EArmorPartName.nohavice, 179, 279, 100, 131));
            ArmorParts_Pant.Add(new armorpart("Nohavice zelezne", 8, EArmorType.iron, EArmorPartName.nohavice, 339, 279, 100, 131));
            ArmorParts_Pant.Add(new armorpart("Nohavice zlate", 15, EArmorType.gold, EArmorPartName.nohavice, 506, 279, 100, 131));
            ArmorParts_Pant.Add(new armorpart("Nohavice diamantove", 22, EArmorType.diamond, EArmorPartName.nohavice, 657, 279, 100, 131));
            ComboBox_PantPicker.ItemsSource = ArmorParts_Pant;

            ArmorParts_Leg.Add(new armorpart("Sandale", 0, EArmorType.none, EArmorPartName.Leg, 0, 0, 0, 0));
            ArmorParts_Leg.Add(new armorpart("Topanky bronzove", 2, EArmorType.lether, EArmorPartName.Leg, 2, 425, 140, 100));
            ArmorParts_Leg.Add(new armorpart("Topanky retiazkove", 4, EArmorType.chain, EArmorPartName.Leg, 159, 425, 140, 100));
            ArmorParts_Leg.Add(new armorpart("Topanky zelezne", 8, EArmorType.iron, EArmorPartName.Leg, 319, 425, 140, 100));
            ArmorParts_Leg.Add(new armorpart("Topanky zlate", 15, EArmorType.gold, EArmorPartName.Leg, 484, 425, 140, 100));
            ArmorParts_Leg.Add(new armorpart("Topanky diamantove", 22, EArmorType.diamond, EArmorPartName.Leg, 636, 425, 140, 100));
            ComboBox_LegPicker.ItemsSource = ArmorParts_Leg;
        }

        private void combox_Helmpicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            armorpart armorPart=(armorpart)combox_Helmpicker.SelectedItem as armorpart;
            Head = armorPart;
            if (armorPart.ArmorType != EArmorType.none)
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(ImagePath, UriKind.Absolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad; // aby sa súbor neu lockol
                bitmap.EndInit();
                bitmap.Freeze();

                var cropped = new CroppedBitmap(bitmap, new Int32Rect(armorPart.XLeft, armorPart.YTop, armorPart.Width, armorPart.Height));
                cropped.Freeze();

                Image_HelmetPlaceHolder.Source = cropped;
                Image_HelmetPlaceHolder.Visibility = Visibility.Visible;
                
            }

            else
            {

                Image_HelmetPlaceHolder.Visibility= Visibility.Collapsed;
            }
            
            UpdateLabels();
        }

        private void ComboBox_BodyPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            armorpart armorPart = (armorpart)ComboBox_BodyPicker.SelectedItem as armorpart;
            Body = armorPart;
            if (armorPart.ArmorType != EArmorType.none)
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(ImagePath, UriKind.Absolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad; // aby sa súbor neu lockol
                bitmap.EndInit();
                bitmap.Freeze();

                var cropped = new CroppedBitmap(bitmap, new Int32Rect(armorPart.XLeft, armorPart.YTop, armorPart.Width, armorPart.Height));
                cropped.Freeze();

                Image_chestPlaceHolder.Source = cropped;
                Image_chestPlaceHolder.Visibility = Visibility.Visible;
            }

            else
            {

                Image_chestPlaceHolder.Visibility = Visibility.Collapsed;
            }
            
            UpdateLabels();
        }

        private void ComboBox_PantPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            armorpart armorPart = (armorpart)ComboBox_PantPicker.SelectedItem as armorpart;
            Pant = armorPart;
            if (armorPart.ArmorType != EArmorType.none)
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(ImagePath, UriKind.Absolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad; // aby sa súbor neu lockol
                bitmap.EndInit();
                bitmap.Freeze();

                var cropped = new CroppedBitmap(bitmap, new Int32Rect(armorPart.XLeft, armorPart.YTop, armorPart.Width, armorPart.Height));
                cropped.Freeze();

                Image_nohavicePlaceHolder.Source = cropped;
                Image_nohavicePlaceHolder.Visibility = Visibility.Visible;
            }

            else
            {

                Image_nohavicePlaceHolder.Visibility = Visibility.Collapsed;
            }
            UpdateLabels(); 

        }

        private void ComboBox_LegPicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            armorpart armorPart = (armorpart)ComboBox_LegPicker.SelectedItem as armorpart;
            Leg = armorPart;
            if (armorPart.ArmorType != EArmorType.none)
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(ImagePath, UriKind.Absolute);
                bitmap.CacheOption = BitmapCacheOption.OnLoad; // aby sa súbor neu lockol
                bitmap.EndInit();
                bitmap.Freeze();

                var cropped = new CroppedBitmap(bitmap, new Int32Rect(armorPart.XLeft, armorPart.YTop, armorPart.Width, armorPart.Height));
                cropped.Freeze();

                Image_legPlaceHolder.Source = cropped;
                Image_legPlaceHolder.Visibility = Visibility.Visible;
            }

            else
            {

                Image_legPlaceHolder.Visibility = Visibility.Collapsed;
            }
            UpdateLabels();

        }
    }
}