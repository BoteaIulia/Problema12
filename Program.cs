using System;

public static class Globals
{
	internal static void Main()
	{
		Console.Write("Cate numere intregi divizibile cu n se afla in intervalul [a,b]");
		Console.Write("\n");

		int a;
		int b;
		int n;

		int counter = 0;

		Console.Write("a = ");
		a = Convert.ToInt32(Console.ReadLine());
		Console.Write("b = ");
		b = Convert.ToInt32(Console.ReadLine());
		Console.Write("n = ");
		n = Convert.ToInt32(Console.ReadLine());

		if (a < b)
		{

			for (int i = a; i <= b; i++)
			{

				if (i % n == 0)
				{

					counter++;

				}

			}

			if (counter == 0)
			{

				Console.Write("In intervalul [");
				Console.Write(a);
				Console.Write(":");
				Console.Write(b);
				Console.Write("] nu sunt numere divizibile cu ");
				Console.Write(n);
				Console.Write("\n");

			}
			else if (counter == 1)
			{

				Console.Write("In intervalul [");
				Console.Write(a);
				Console.Write(":");
				Console.Write(b);
				Console.Write("] este un numar divizibil cu ");
				Console.Write(n);
				Console.Write("\n");

			}
			else
			{

				Console.Write("In intervalul [");
				Console.Write(a);
				Console.Write(":");
				Console.Write(b);
				Console.Write("] sunt ");
				Console.Write(counter);
				Console.Write(" numere divizibile cu ");
				Console.Write(n);
				Console.Write("\n");

			}

		}
		else
		{

			Console.Write("Ati introdus gresit limitele intervalului");

		}


	}
}