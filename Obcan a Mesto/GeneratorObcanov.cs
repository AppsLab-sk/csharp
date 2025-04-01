namespace Obcan_a_Mesto
{
    public static class GeneratorObcanov
    {
        public static string[] mena = { "Igor", "Anna", "Peter", "Jana", "Martin", "Lucia",
            "Tomáš", "Eva", "Michal", "Zuzana", "Marek", "Katarína", "Andrej", "Lenka", "Patrik",
            "Monika", "Filip", "Veronika", "Richard", "Simona", "Róbert", "Mária", "Jakub", "Barbora",
            "Adam", "Dominika", "Lukáš", "Daniela", "Vladimír", "Nikola" };
        public static string[] programovacieJazyky = { "Betonova", "Maltova","Plastova","Ocelova","Gumova" };
        public static Obcan GenreujObcana()
        {
            Random random = new Random();
            int pozicia = random.Next(mena.Length);
            string meno = mena[pozicia];
            int vek = random.Next(15, 116);
            Obcan obcan = new Obcan(meno, vek);
            return obcan;
            
        }
        public static Obcan GenerujJazyk()
        {
            Random r = new Random();
            int pozicia = r.Next(mena.Length);
            string meno = mena[pozicia];
            int vek = r.Next(15, 116);
            Obcan obcan = new Obcan(meno, vek);
            int dlzkaEnum = (Enum.GetValues<StavObcana>().Length);
            int nahodnyIndex = r.Next(dlzkaEnum);
            obcan.Stav = (StavObcana)nahodnyIndex;
            obcan.Stav = StavObcana.Cudzinec;
            return obcan;


        }
    }
}
