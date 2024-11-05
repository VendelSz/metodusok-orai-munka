namespace metódusok
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Koszonto();
			Console.WriteLine(Osszeadas(10, 90));
			int a = 5;
            Console.WriteLine(Duplaz(a));
			int duplazott = Duplaz(a);
            Console.WriteLine(a);
            Console.WriteLine(duplazott);
			Console.WriteLine(Osszeg(10));
			int elso = 5;
			int masodik = 10;
			Csere(elso, masodik);
            Console.WriteLine(elso + " " + masodik);
			List<int> primSzamok = PrimSzamok(1, 1000);
			foreach (int szam in primSzamok)
			{
                Console.WriteLine(szam + ",");
            }
        }

		static List<int> PrimSzamok(int kezdo, int veg)
		{
			List<int> primLista = new List<int>();
			for (int i = kezdo; i <= veg; i++)
			{
				if (PrimE(i))
				{
					primLista.Add(i);
				}
			}
			return primLista;
		}

		static bool PrimE(int szam)
		{
			if (szam < 2) return false;
			for (int i = 2; i <= Math.Sqrt(szam); i++)
			{
				if (szam % i == 0) return false;
			}
		}

		static void Koszonto()
		{
			Console.WriteLine("Hello, világ!");
		}

		static int Osszeadas(int a, int b)
		{
			/*
			int osszeg = a + b;
			return osszeg;
			*/
			return a + b;
		}

		static int Duplaz(int szam)
		{
			return szam * 2;
		}


		static int Osszeg(int a, int b = 5, int c = 2)
		{
			return a + b + c;
		}

		static void Csere(int a, int b)
		{
			int temp = a;
			a = b;
			b = temp;
            Console.WriteLine(a+ " " + b);
        }
	}
}
