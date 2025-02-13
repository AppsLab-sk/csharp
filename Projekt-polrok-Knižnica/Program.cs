using System;
using System.Collections.Generic;
using System.Threading;
using Newtonsoft.Json;
namespace Projekt_polrok_Knižnica
{
    public enum Role
    {
        Student,
        Admin
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }

        public User(string username, string password, Role role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
        public override string ToString()
        {
            return $"{Username}, {Password}, {Role}";
        }


        public bool CanBorrowBook()
        {
            return Role == Role.Student || Role == Role.Admin;
        }

        public bool CanAccessAllAreas()
        {
            return Role == Role.Admin;
        }
    }

    public class Program
    {
        static List<User> users = new List<User>();
        static List<Book> store = new List<Book>
    {
        new Book(1, "Harry Potter a Kameň mudrcov", "J.K. Rowling", 1997, "Fantasy"),
        new Book(2, "Pán prsteňov", "J.R.R. Tolkien", 1954, "Fantasy"),
        new Book(3, "Ako zabiť drozda", "Harper Lee", 1960, "Dráma"),
        new Book(4, "1984", "George Orwell", 1949, "Dystopia"),
        new Book(5, "Pýcha a predsudok", "Jane Austen", 1813, "Romance"),
        new Book(6, "Veľký Gatsby", "F. Scott Fitzgerald", 1925, "Dráma"),
        new Book(7, "Moby-Dick", "Herman Melville", 1851, "Dobrodružstvo"),
        new Book(8, "Vojna a mier", "Leo Tolstoy", 1869, "Historický"),
        new Book(9, "Kto chytá v žite", "J.D. Salinger", 1951, "Dráma"),
        new Book(10,"Hobbit", "J.R.R. Tolkien", 1937, "Fantasy"),
        new Book(11, "Zločin a trest", "Fyodor Dostoevsky", 1866, "Psychologický"),
        new Book(12, "Bratia Karamazovovci", "Fyodor Dostoevsky", 1880, "Filozofický"),
        new Book(13, "Anna Karenina", "Leo Tolstoy", 1877, "Romance"),
        new Book(14, "Statočný nový svet", "Aldous Huxley", 1932, "Dystopia"),
        new Book(15, "Odyssea", "Homér", -800, "Epická"),
        new Book(16, "Sto rokov samoty", "Gabriel Garcia Marquez", 1967, "Magický realizmus"),
        new Book(17, "Božská komédia", "Dante Alighieri", 1320, "Epická"),
        new Book(18, "Jana Eyrová", "Charlotte Brontë", 1847, "Romance"),
        new Book(19, "Iliada", "Homér", -850, "Epická"),
        new Book(20, "Frankenstein", "Mary Shelley", 1818, "Horor"),
        new Book(21, "Veľké nádeje", "Charles Dickens", 1861, "Dráma"),
        new Book(22, "Don Quijote", "Miguel de Cervantes", 1605, "Dobrodružstvo"),
        new Book(23, "Ulysses", "James Joyce", 1922, "Modernistická"),
        new Book(24, "Pani Bovaryová", "Gustave Flaubert", 1857, "Romance"),
        new Book(25, "Búrlivé výšiny", "Emily Brontë", 1847, "Romance"),
        new Book(26, "Gróf Monte Cristo", "Alexandre Dumas", 1844, "Dobrodružstvo"),
        new Book(27, "Bedári", "Victor Hugo", 1862, "Historický"),
        new Book(28, "Hrozno hnevu", "John Steinbeck", 1939, "Dráma"),
        new Book(29, "Hlava XXII", "Joseph Heller", 1961, "Satirická"),
        new Book(30, "Lolita", "Vladimir Nabokov", 1955, "Dráma"),
        new Book(31, "Alchymista", "Paulo Coelho", 1988, "Filozofická"),
        new Book(32, "Harry Potter a Tajomná komnata", "J.K. Rowling", 1998, "Fantasy"),
        new Book(33, "Harry Potter a Väzeň z Azkabanu", "J.K. Rowling", 1999, "Fantasy"),
        new Book(34, "Harry Potter a Ohnivá čaša", "J.K. Rowling", 2000, "Fantasy"),
        new Book(35, "Harry Potter a Fénixov rád", "J.K. Rowling", 2003, "Fantasy"),
        new Book(36, "Harry Potter a Polovičný princ", "J.K. Rowling", 2005, "Fantasy"),
        new Book(37, "Harry Potter a Dary smrti", "J.K. Rowling", 2007, "Fantasy"),
        new Book(38, "Letopisy Narnie", "C.S. Lewis", 1950, "Fantasy"),
        new Book(39, "Príbeh dvoch miest", "Charles Dickens", 1859, "Historický"),
        new Book(40, "Zlodejka kníh", "Markus Zusak", 2005, "Historický"),
        new Book(41, "451 stupňov Fahrenheita", "Ray Bradbury", 1953, "Dystopia"),
        new Book(42, "Žiariace", "Stephen King", 1977, "Horor"),
        new Book(43, "Dracula", "Bram Stoker", 1897, "Horor"),
        new Book(44, "Mechanický pomaranč", "Anthony Burgess", 1962, "Dystopia"),
        new Book(45, "Rozum a cit", "Jane Austen", 1811, "Romance"),
        new Book(46, "Odviate vetrom", "Margaret Mitchell", 1936, "Historický"),
        new Book(47, "Portrét Doriana Graya", "Oscar Wilde", 1890, "Filozofická"),
        new Book(48, "Zvieracia farma", "George Orwell", 1945, "Politická satira"),
        new Book(49, "Cesta", "Cormac McCarthy", 2006, "Post-apokalyptická"),
        new Book(50, "Dievča s dračím tetovaním", "Stieg Larsson", 2005, "Krimi"),
        new Book(51, "Bitúnok číslo päť", "Kurt Vonnegut", 1969, "Anti-vojnová"),
        new Book(52, "Vražda v Orient Expresse", "Agatha Christie", 1934, "Detektívka"),
        new Book(53, "Cudzinec", "Albert Camus", 1942, "Filozofická"),
        new Book(54, "Rebeka", "Daphne du Maurier", 1938, "Gothická"),
        new Book(55, "Spomienky gejše", "Arthur Golden", 1997, "Historický"),
        new Book(56, "Stopárov sprievodca po galaxii", "Douglas Adams", 1979, "Sci-fi"),
        new Book(57, "Starec a more", "Ernest Hemingway", 1952, "Literárna fikcia"),
        new Book(58, "Hra o tróny", "George R.R. Martin", 1996, "Fantasy"),
        new Book(59, "Da Vinciho kód", "Dan Brown", 2003, "Detektívka"),
        new Book(60, "Anjeli a démoni", "Dan Brown", 2000, "Detektívka")
    };

        static List<Book> borrowedBooks = new List<Book>();
        //Výpis menu
        public static void Main()
        {
            LoadUsersFromJson();
            VypisInfo();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("VITAJTE V KNIŽNICI");
                Console.WriteLine();
                Console.WriteLine("Vyberte možnosť:");
                Console.WriteLine("1. Registrácia");
                Console.WriteLine("2. Prihlásenie");
                Console.WriteLine("3. Ukončenie");
                Console.Write("Vaša voľba: ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    RegisterUser(users);
                }
                else if (choice == "2")
                {
                    LoginUser(users);
                }
                else if (choice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Neplatná voľba. Skúste znova.");
                }
            }
        }

        //Registrácia / kontrola hesla
        public static void RegisterUser(List<User> users)
        {
            string username;
            while (true)
            {
                Console.Write("Zadajte používateľské meno (alebo 0 pre návrat do menu): ");
                username = Console.ReadLine();

                if (username == "0")
                {
                    Console.Clear();
                    VypisInfo();
                    return;
                }

                if (username.Length >= 3 && username.Length <= 15)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Používateľské meno musí byť dlhé aspoň 3 a najviac 15 znakov. Skúste znova.");
                }
            }

            string password;
            while (true)
            {
                Console.Write("Zadajte heslo (alebo 0 pre návrat do menu): ");
                password = Console.ReadLine();

                if (password == "0")
                {
                    Console.Clear();
                    VypisInfo();
                    return;
                }

                if (password.Length >= 5 && password.Length <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Heslo musí byť dlhé aspoň 5 a najviac 10 znakov. Skúste znova.");
                }
            }

            Console.Write("Vyberte rolu (1-Student, 2-Admin): ");
            Role role = (Console.ReadLine() == "1") ? Role.Student : Role.Admin;

            users.Add(new User(username, password, role));
            Console.WriteLine("Registrácia úspešná!\n");
            Thread.Sleep(3000);
            Console.Clear();
            VypisInfo();
        }


        //Prihlasovanie

        public static void LoginUser(List<User> users)
        {
            Console.Write("Používateľské meno (alebo 0 pre návrat do menu): ");
            string username = Console.ReadLine();

            if (username == "0")
            {
                Console.Clear();
                VypisInfo();
                return;
            }

            Console.Write("Heslo (alebo 0 pre návrat do menu): ");
            string password = Console.ReadLine();

            if (password == "0")
            {
                Console.Clear();
                VypisInfo();
                return;
            }

            User loggedInUser = users.Find(user => user.Username == username && user.Password == password);

            if (loggedInUser != null)
            {
                Console.WriteLine($"\nPrihlásený používateľ: {loggedInUser.Username}");
                DisplayMenu(loggedInUser);
            }
            else
            {
                Console.WriteLine("Nesprávne používateľské meno alebo heslo.");
            }
        }

        //Prístup k funkciam ako študent/admin
        public static void DisplayMenu(User loggedInUser)
        {
            bool isEnd = false;
            while (!isEnd)
            {
                PrintMenu();
                Console.WriteLine();

                var answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        DisplayBooks();
                        break;
                    case "2":
                        if (loggedInUser.CanAccessAllAreas())
                        {
                            Console.WriteLine("Zadajte názov, autora, rok a žáner knihy na pridanie (alebo 0 pre návrat):");
                            var newItemName = Console.ReadLine();
                            var menoAutora = Console.ReadLine();
                            var rokVydania = int.Parse(Console.ReadLine());
                            var zaner = Console.ReadLine();
                            if (newItemName != "0")
                            {
                                AddItem(store, newItemName, menoAutora, rokVydania, zaner);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nemáte povolenie na pridávanie kníh.");
                        }
                        break;
                    case "3":
                        if (loggedInUser.CanAccessAllAreas())
                        {
                            Console.WriteLine("Zadajte ID knihy na odobratie (alebo 0 pre návrat):");

                            var itemName = int.Parse(Console.ReadLine());
                            if (itemName != 0)
                            {
                                RemoveItem(store, itemName);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nemáte povolenie na odoberanie kníh.");
                        }
                        break;
                    case "4":
                        if (loggedInUser.CanBorrowBook())
                        {
                            Console.WriteLine("Zadajte ID knihy na požičanie (alebo 0 pre návrat):");
                            var bookName = int.Parse(Console.ReadLine());
                            if (bookName != 0)
                            {
                                BorrowBook(store, borrowedBooks, bookName);

                            }
                        }
                        else
                        {
                            Console.WriteLine("Nemáte povolenie na požičiavanie kníh.");
                        }
                        break;
                    case "5":
                        SaveUsersToJson();
                        SaveBooksToJson();
                        isEnd = true;
                        break;
                    default:
                        Console.WriteLine("Nesprávna akcia!");
                        break;
                }
            }
        }


        //Pridávanie kníh
        public static void AddItem(List<Book> itemList, string NazovKnihy, string MenoAutora, int RokVydania, string Zaner)
        {
            //vyhladam maximalne ID, pridam +1
            int newId = itemList.Count > 0 ? itemList.Max(x => x.ID) + 1 : 1;
            //vytvorim knihu s novym ID a novym nazvom
            Book novaKniha = new Book(newId, NazovKnihy, MenoAutora, RokVydania, Zaner);

            if (!itemList.Any(x => x.NazovKnihy == NazovKnihy))
            {
                itemList.Add(novaKniha);
                Console.WriteLine($"Kniha {novaKniha.NazovKnihy} bola pridaná do knižnice.");
            }
            else
            {
                Console.WriteLine($"Kniha {novaKniha.NazovKnihy} už existuje v knižnici.");
            }
            Console.WriteLine("\nStlačte Enter, aby ste sa vrátili do menu.");
            Console.ReadLine();
        }

        //Odtraňovanie kníh
        public static void RemoveItem(List<Book> itemList, int itemID)
        {
            Book najdenaKniha = itemList.Where(x => x.ID == itemID).First();
            if (najdenaKniha != null)
            {
                itemList.Remove(najdenaKniha);
                Console.WriteLine($"Kniha {najdenaKniha.NazovKnihy} bola odstránená z knižnice.");
            }
            else
            {
                Console.WriteLine($"Kniha {najdenaKniha.NazovKnihy} nebola nájdená v knižnici.");
                Console.WriteLine("\nStlačte Enter, aby ste sa vrátili do menu.");
                Console.ReadLine();
            }
        }

        //Požičiavanie kníh

        public static void BorrowBook(List<Book> itemList, List<Book> borrowedList, int itemID)
        {
            Book najdenaKniha = itemList.Where(x => x.ID == itemID).First();
            if (najdenaKniha != null)
            {
                itemList.Remove(najdenaKniha);
                borrowedList.Add(najdenaKniha);
                Console.WriteLine($"Kniha {najdenaKniha.NazovKnihy} bola požičaná.");
            }
            else
            {
                Console.WriteLine($"Kniha {najdenaKniha.NazovKnihy} nebola nájdená v knižnici.");
            }
            Console.WriteLine("\nStlačte Enter, aby ste sa vrátili do menu.");
            Console.ReadLine();
        }

        //Výpis menu
        public static void PrintMenu()
        {
            Thread.Sleep(3000);
            Console.Clear();
            Menu();
            Console.WriteLine("\n1. Výpis kníh");
            Console.WriteLine("2. Pridanie knihy");
            Console.WriteLine("3. Odobratie knihy");
            Console.WriteLine("4. Požičiavanie knihy");
            Console.WriteLine("5. Odhlásiť sa");
            Console.WriteLine("Vyberte akciu:");
        }
        //Výpis kníh
        public static void DisplayBooks()
        {
            Console.WriteLine("Zoznam kníh:");
            foreach (var item in store)
            {
                Console.WriteLine($"Názov knihy: {item.NazovKnihy}, Meno autora: {item.Autor}, Rok vydania: {item.Rok}, Žáner knihy: {item.Zaner}");
            }
            Console.WriteLine("\nStlačte Enter, aby ste sa vrátili do menu.");
            Console.ReadLine();
        }





        //Nadpis menu 1
        public static void VypisInfo()
        {
            Console.Clear();
            Console.WriteLine("                                                ____");
            Console.WriteLine("                                                \\__/");
            Console.WriteLine("                      __  ___  __   ___  ___  ________   __   __   __    ______     ___");
            Console.WriteLine("                     |  |/  / |  \\ |  | |  | |       /  |  \\ |  | |  |  /      |   /   \\     ");
            Console.WriteLine("                     |  '  /  |   \\|  | |  | `---/  /   |   \\|  | |  | |  ,----'  /  ^  \\    ");
            Console.WriteLine("                     |    <   |  . `  | |  |    /  /    |  . `  | |  | |  |      /  /_\\  \\   ");
            Console.WriteLine("                     |  .  \\  |  |\\   | |  |   /  /----.|  |\\   | |  | |  `----./  _____  \\");
            Console.WriteLine("                     |__|\\__\\ |__| \\__| |__|  /________||__| \\__| |__|  \\______/__/     \\__\\");
        }

        //Nadpis menu 2

        public static void Menu()
        {
            Console.WriteLine("                                                ____");
            Console.WriteLine("                                                \\__/");
            Console.WriteLine("                      __  ___  __   ___  ___  ________   __   __   __    ______     ___");
            Console.WriteLine("                     |  |/  / |  \\ |  | |  | |       /  |  \\ |  | |  |  /      |   /   \\     ");
            Console.WriteLine("                     |  '  /  |   \\|  | |  | `---/  /   |   \\|  | |  | |  ,----'  /  ^  \\    ");
            Console.WriteLine("                     |    <   |  . `  | |  |    /  /    |  . `  | |  | |  |      /  /_\\  \\   ");
            Console.WriteLine("                     |  .  \\  |  |\\   | |  |   /  /----.|  |\\   | |  | |  `----./  _____  \\");
            Console.WriteLine("                     |__|\\__\\ |__| \\__| |__|  /________||__| \\__| |__|  \\______/__/     \\__\\");
        }

        public static void SaveUsersToJson()
        {
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText("users.json", json);
        }

        public static void LoadUsersFromJson()
        {
            if (File.Exists("users.json"))
            {
                string json = File.ReadAllText("users.json");
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }
            else
            {
                Console.WriteLine("Žiadny uložený používateľ nebol nájdený.");
            }
        }
        public static void SaveBooksToJson()
        {
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText("books.json", json);
        }

        public static void LoadBooksFromJson()
        {
            if (File.Exists("books.json"))
            {
                string json = File.ReadAllText("users.json");
                store = JsonConvert.DeserializeObject<List<Book>>(json);
            }
            else
            {
                Console.WriteLine("Žiadna uložena kniha nebola nájdený.");
            }
        }
    }
}






































