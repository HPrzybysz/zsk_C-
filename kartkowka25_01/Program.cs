namespace KasperskiFilip_gr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadanie 4
            Console.WriteLine("\nZadanie 4");
            List<int> randomInts = UtworzListe(10);
            Random random = new Random();
            for (int i = 0; i < randomInts.Count; i++)
            {
                randomInts[i] = random.Next(1, 101);
            }
            for (int i = 0; i < randomInts.Count; i++)
            {
                Console.WriteLine($"Wartość {i + 1} listy : {randomInts[i]}");
            }

            //zadanie 5
            Console.WriteLine("\nZadanie 5");
            int[,] tablica = UtworzTablice([1, 2, 3], [4,5,6], [7,8,9]);
            int suma = 0;
            for(int i=0; i<3; i++)
            {
                suma += tablica[i,i];
            }
            Console.WriteLine($"Suma liczba na przekątej tablicy wynosi: {suma}");

            //zadanie 6
            Console.WriteLine("\nZadanie 6");
            Dictionary<string,string> slownik = new Dictionary<string, string>();
            slownik.Add("kot", "miau");
            slownik.Add("pies", "hau");
            slownik.Add("krowa", "muuu");
            
            Dictionary<string, string> zwierzeta = UtworzSlownik([slownik]);
            while (true)
            {
                try
                {
                    Console.WriteLine("Podaj nazwe zwierzęcia: ");
                    string? input = Console.ReadLine();
                    if (input == "koniec")
                    {
                        break;
                    }
                    if (slownik[input] != null)
                    {
                        Console.WriteLine(slownik[input]);
                    }
                    else
                    {
                        Console.WriteLine("Nie znam tego zwierzęcia");
                    }
                }
                catch (Exception e) { Console.WriteLine(e.Message);
            }

        }
        static Dictionary<string, string> UtworzSlownik(List<Dictionary<string,string>> list)
        {
            Dictionary<string, string> pustySlownik = new Dictionary<string, string>();
            Dictionary<string,string> slownik = new Dictionary<string,string>();
            for (int i = 0;i< list.Count; i++)
            {
                foreach (var j in list[i].Keys)
                {
                    if (j != string.Empty) slownik[j] = list[i][j];
                    else return pustySlownik;
                }
                foreach (var j in list[i].Values)
                {
                    if (j == string.Empty) return pustySlownik;

                }
            }
            return slownik;
        }


        static int[,] UtworzTablice(List<int> lista1, List<int> lista2, List<int> lista3)
        {
            int[,] tablica = new int[3,3];
            if(lista1.Count == 3 && lista2.Count == 3 && lista3.Count == 3)
            {
                for(int i = 0; i < 3; i++)
                {
                    tablica[i,0] = lista1[i];
                    tablica[i,1] = lista2[i];
                    tablica[i,2] = lista3[i];
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    tablica[i, 1] = 0;
                    tablica[i, 2] = 0;
                    tablica[i, 3] = 0;
                }
            }
            return tablica;
            
        }

        static List<int> UtworzListe(int n)
        {
            List<int> list = new List<int>();
            if (n > 0)
            {
                for(int i = 0;i<n;i++)
                {
                    list.Add(0);
                }
                return list;
            }
            else
            {
                return list;
            }
        }
    }
}
