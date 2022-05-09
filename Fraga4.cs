using System;

namespace Uppgift_4
{
    class Bibliotek
    {
        public static Bok[] bokVektor = Bok.genereraBöcker();

        public static void Main()
        {
            int menyVal;
            do
            {
                Console.WriteLine("Huvudmeny:\n" +
                    "1: Skriv ut alla böcker i listan\n" +
                    "2: Lägg till bok i listan\n" +
                    "3: Sök bok i listan\n" +
                    "0: Avsluta programmet");
                Console.Write("Ange ett menyval: ");
                while (!int.TryParse(Console.ReadLine(), out menyVal))
                {
                    Console.WriteLine("Du måste ange ett heltal!");
                }
                HuvudMeny(menyVal);
            } while (menyVal != 0);
        }

        public static void HuvudMeny(int val)
        {
            switch (val)
            {
                case 0:
                    Console.WriteLine("Programmet avslutas!");
                    Console.ReadKey();
                    break;
                case 1:
                    SkrivUtAllaBöcker(bokVektor);
                    break;
                case 2:
                    NyBok();
                    break;
                case 3:
                    FindByISBN();
                    break;
            }
        }

        //Skapa din metod här:
        public static void FindByISBN()
        {
            Console.Write("Ange ISBN: ");
            int searchPhrase = int.Parse(Console.ReadLine());
            Bok[] foundBooks = GetByISBN(searchPhrase);
            SkrivUtAllaBöcker(foundBooks);
        }
        public static Bok[] GetByISBN(int ISBN)
        {
            Bok[] foundBooks = new Bok[0];

            for (int i = 0; i < bokVektor.Length; i++)
            {
                if (bokVektor[i].ISBN.Equals(ISBN))
                {
                    foundBooks = AddBokToVector(foundBooks, bokVektor[i]);
                }
            }

            return foundBooks;
        }

        public static Bok[] AddBokToVector(Bok[] oldBokList, Bok newBok)
        {
            Bok[] newBokList = new Bok[oldBokList.Length + 1];

            for (int i = 0; i < oldBokList.Length; i++)
            {
                newBokList[i] = oldBokList[i];
            }

            newBokList[oldBokList.Length] = newBok;

            return newBokList;
        }

        //Slut på din metod

        public static void SkrivUtAllaBöcker(Bok[] bokVektor)
        {
            for (int i = 0; i < bokVektor.Length; i++)
            {
                Console.Write($"{bokVektor[i].ISBN}, ");
                SkrivUtBok(bokVektor[i]);
            }
        }

        public static void SkrivUtBok(Bok boken)
        {
            Console.WriteLine($"\"{boken.Titel}, {boken.Författaren}\" står i hylla {boken.Hylla} på plats {boken.Plats}");
        }

        public static void NyBok()
        {
            int nyttISBN, nyaHyllan, nyaPlatsen;
            string nyaTiteln, nyaFörfattaren;
            Console.Write("Vad är bokens ISBN: ");
            while (!int.TryParse(Console.ReadLine(), out nyttISBN))
            {
                Console.WriteLine("Du måste ange ett heltal!");
            }
            Console.Write("Vad är bokens titel: ");
            nyaTiteln = Console.ReadLine();
            Console.Write("Vem är bokens författare: ");
            nyaFörfattaren = Console.ReadLine();
            Console.Write("Vad är bokens hylla: ");
            while (!int.TryParse(Console.ReadLine(), out nyaHyllan))
            {
                Console.WriteLine("Du måste ange ett heltal!");
            }
            Console.Write("Vad är bokens plats: ");
            while (!int.TryParse(Console.ReadLine(), out nyaPlatsen))
            {
                Console.WriteLine("Du måste ange ett heltal!");
            }
            bokVektor = Bok.LäggTillBok(bokVektor, nyttISBN, nyaTiteln, nyaFörfattaren, nyaHyllan, nyaPlatsen);
            Console.WriteLine("\nBoken är tillagd i systemet!");
        }
       
    }

    public class Bok : IComparable<Bok>
    {
        public int ISBN
        {
            get; private set;
        }
        public string Titel
        {
            get; private set;
        }
        public string Författaren
        {
            get; private set;
        }
        public int Hylla
        {
            get; private set;
        }
        public int Plats
        {
            get; private set;
        }

        private Bok(int ISBN, string titel, string författaren, int hylla, int plats)
        {
            this.ISBN = ISBN;
            Titel = titel;
            Författaren = författaren;
            Hylla = hylla;
            Plats = plats;
        }

        public int CompareTo(Bok annanBok)
        {
            return (ISBN).CompareTo(annanBok.ISBN);
        }

        public static Bok[] genereraBöcker()
        {
            Bok[] böcker = new Bok[0];

            int[] ISBNn = { 123456789, 123456790, 123456791, 123456792, 123456793, 123456794, 123456795, 123456796, 123456797, 123456798, 123456799, 123456800, 123456801, 123456802, 123456803, 123456804, 123456805, 123456806, 123456807, 123456808, 123456809, 123456810, 123456811, 123456812, 123456813, 123456814, 123456815, 123456816, 123456817, 123456818, 123456819, 123456820, 123456821, 123456822, 123456823, 123456824, 123456825, 123456826, 123456827, 123456828, 123456829, 123456830, 123456831, 123456832, 123456833, 123456834, 123456835, 123456836, 123456837, 123456838, 123456839, 123456840, 123456841, 123456842, 123456843, 123456844, 123456845, 123456846, 123456847, 123456848, 123456849, 123456850, 123456851, 123456852, 123456853, 123456854, 123456855, 123456856, 123456857, 123456858, 123456859, 123456860, 123456861, 123456862, 123456863, 123456864, 123456865, 123456866, 123456867, 123456868, 123456869, 123456870, 123456871, 123456872, 123456873, 123456874, 123456875, 123456876, 123456877, 123456878, 123456879, 123456880, 123456881, 123456882, 123456883, 123456884, 123456885, 123456886, 123456887, 123456888 };
            string[] Titlar = { "Allt går sönder", "Drottningens juvelsmycke", "Andarnas hus +", "Ditte människobarn", "Hitom himlen", "Stolthet och fördom", "Pappa Goriot", "Ondskans blommor", "I väntan på Godot+", "Onkel Toms stuga", "Fru Marianne", "Röde Orm", "Markurells i Wadköping (sett en teaterföreställning)", "Decamerone", "Kallocain", "Mor Courage och hennes barn", "Hertha", "Agnes Grey", "Jane Eyre", "Svindlande höjder", "Mästaren och Margarita", "Om en vinternatt en resande", "Främlingen +", "Drömmar om röda gemak", "Don Quijote", "Mörkrets hjärta", "Den gudomliga komedin", "Robinson Crusoe", "Oliver Twist", "Brott och straff +", "De tre musketörerna", "Älskaren +", "Det öde landet+", "Medea+", "Absalom, Absalom", "Den store Gatsby+", "Madame Bovary", "Rosen på Tistelön", "Stockholms-serien +", "Hundra år av ensamhet +", "Den omoraliske", "Den unge Werthers lidanden", "Min barndom", "Brighton Rock", "Markens gröda", "Den tappre soldaten Svejk", "Moment 22", "Den gamle och havet", "Stäppvargen", "Odysséen", "Et dukkehjem", "Strändernas svall", "Ulysses", "Processen", "Låt tistlarna brinna!", "Bertha Funke*", "Barabbas +", "Kejsarn av Portugallien", "Lifsens rot", "Okänd soldat (har läst utdrag, räknas det?)", "Kungsgatan", "Huset Buddenbrook", "Nässlorna blomma", "Kvinnor och äppelträd", "Utvandrar-serien", "Tartuffe", "Historien*", "Älskade", "Lolita", "1984 +", "Doktor Zjivago", "Kärleksdikter", "På spaning efter den tid som flytt", "På Västfronten intet nytt", "Räddaren i nöden", "Alberte-serien x läst första delen i serien.", "Dikter och fragment", "Macbeth+", "Frankenstein", "Konung Oidipus", "En dag i Ivan Denisovitjs liv", "Vredens druvor", "Rött och svart*", "Dracula", "Dr Jekyll och Mr Hyde", "Röda rummet", "Egil Skallagrimssons saga", "Gullivers resor", "Den allvarsamma leken +", "Damen med hunden", "Anna Karenina +", "Huckleberry Finn", "Kristin Lavransdotter", "Jorden runt på 80 dagar +", "Candide", "Dorian Grays porträtt", "Mot fyren", "Pennskaftet", "Tornet", "Thérèse Raquin" };
            string[] Författare = { "Chinua Achebe", "Carl Jonas Love Almqvist", "Isabel Allende", "Martin Andersen Nexö", "Stina Aronson", "Jane Austen", "Honoré de Balzac", "Charles Baudelaire", "Samuel Beckett", "Harriet Beecher Stowe", "Victoria Benedictsson", "Frans G. Bengtsson", "Hjalmar Bergman", "Giovanni Boccaccio", "Karin Boye", "Bertholt Brecht", "Fredrika Bremer", "Anne Brontë", "Charlotte Brontë", "Emily Brontë", "Mikhail Bulgakov", "Italo Calvino", "Albert Camus", "Cao Xueqin", "Cervantes", "Joseph Conrad", "Dante Alighieri", "Daniel Defoe", "Charles Dickens", "Fjodor Dostojevskij", "Alexandre Dumas d ä", "Marguerite Duras", "T S Eliot", "Euripides", "William Faulkner", "F Scott Fitzgerald", "Gustave Flaubert", "Emilie Flygare-Carlén", "Per Anders Fogelström", "Gabriel García Márquez", "André Gide", "Johann Wolfgang von Goethe", "Maksim Gorkij", "Graham Greene", "Knut Hamsun", "Jaroslav Hasek", "Joseph Heller", "Ernest Hemingway", "Hermann Hesse", "Homeros", "Henrik Ibsen", "Eyvind Johnson", "James Joyce", "Franz Kafka", "Yasar Kemal", "Kleve, Stella (Malling, Mathilda)", "Pär Lagerkvist", "Selma Lagerlöf", "Lidman, Sara", "Väinö Linna", "Ivar Lo-Johansson", "Thomas Mann", "Harry Martinson", "Moa Martinson", "Vilhelm Moberg", "Molière", "Elsa Morante", "Morrison, Toni", "Vladimir Nabokov", "George Orwell", "Boris Pasternak", "Francesco Petrarca", "Marcel Proust", "Erich Maria Remarque", "J. D. Salinger", "Cora Sandel", "Sapfo", "William Shakespeare", "Mary Shelley", "Sofokles", "Solzjenitsyn", "John Steinbeck", "Stendhal", "Bram Stoker", "Robert Louis Stevenson", "August Strindberg", "Snorre Sturlasson", "Jonathan Swift", "Hjalmar Söderberg", "Anton Tjechov", "Lev Tolstoj", "Mark Twain", "Sigrid Undset", "Jules Verne", "Voltaire", "Oscar Wilde", "Woolf, Virginia", "Wägner, Elin", "William Butler Yeats", "Émile Zola" };

            for (int i = 0; i < 100; i++)
            {
                böcker = LäggTillBok(böcker, ISBNn[i], Titlar[i], Författare[i], ((i + 1) / 50) + 1, ((i + 1) % 10));
            }
            return böcker;
        }

        public static Bok[] LäggTillBok(Bok[] gamlaBöcker, int nyaISBN, string nyTitel, string nyFörfattare, int nyHylla, int nyPlats)
        {
            Bok[] nyaBöcker = new Bok[gamlaBöcker.Length + 1];
            for (int i = 0; i < gamlaBöcker.Length; i++)
            {
                nyaBöcker[i] = gamlaBöcker[i];
            }
            nyaBöcker[gamlaBöcker.Length] = new Bok(nyaISBN, nyTitel, nyFörfattare, nyHylla, nyPlats);
            return nyaBöcker;
        }
    }
}