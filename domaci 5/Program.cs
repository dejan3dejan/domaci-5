using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] unetaMatrica = unesiMatricu();
        if (unetaMatrica != null)
        {
            (int min, int minRed, int minKol) = minElement(unetaMatrica);
            Console.WriteLine("Najmanji broj u matrici je {0} i nalazi se na poziciji [{1},{2}]", min, minRed, minKol);
        }
        Console.WriteLine("Pritisnite bilo koji taster za izlaz...");
        Console.ReadKey();
    }

    static (int, int, int) minElement(int[,] matrica)
    {
        int min = matrica[0, 0];
        int minRed = 0;
        int minKol = 0;

        for (int i = 0; i < matrica.GetLength(0); i++)
        {
            for (int j = 0; j < matrica.GetLength(1); j++)
            {
                if (min > matrica[i, j])
                {
                    min = matrica[i, j];
                    minRed = i;
                    minKol = j;
                }
            }
        }

        return (min, minRed, minKol);
    }

    static int[,] unesiMatricu()
    {
        Console.WriteLine("Unesite broj redova matrice:");
        int red;
        if (!int.TryParse(Console.ReadLine(), out red) || red <= 0)
        {
            Console.WriteLine("Neispravan unos za broj redova. Molimo unesite pozitivan ceo broj.");
            return null;
        }

        Console.WriteLine("Unesite broj kolona matrice:");
        int kol;
        if (!int.TryParse(Console.ReadLine(), out kol) || kol <= 0)
        {
            Console.WriteLine("Neispravan unos za broj kolona. Molimo unesite pozitivan ceo broj.");
            return null;
        }

        int[,] matrica = new int[red, kol];

        Console.WriteLine("Unesite vrednosti:");

        for (int i = 0; i < red; i++)
        {
            for (int j = 0; j < kol; j++)
            {
                Console.WriteLine("Unesite element [{0},{1}]:", i, j);
                int element;
                if (!int.TryParse(Console.ReadLine(), out element))
                {
                    Console.WriteLine("Neispravan unos. Molimo unesite ceo broj.");
                    return null;
                }
                matrica[i, j] = element;
            }
        }

        Console.WriteLine("Uneta matrica:");
        for (int i = 0; i < red; i++)
        {
            for (int j = 0; j < kol; j++)
            {
                Console.Write(matrica[i, j] + "\t");
            }
            Console.WriteLine();
        }

        return matrica;
    }
}
