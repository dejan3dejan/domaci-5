using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] unetaMatrica = unesiMatricu();
        (int minValue, int minRow, int minCol) = minElement(unetaMatrica);
        Console.WriteLine("Najmanji broj u matrici je {0} i nalazi se na poziciji [{1},{2}]", minValue, minRow, minCol);
        Console.ReadKey();
    }

    static (int, int, int) minElement(int[,] matrica)
    {
        int min = matrica[0, 0];
        int minRow = 0;
        int minCol = 0;

        for (int i = 0; i < matrica.GetLength(0); i++)
        {
            for (int j = 0; j < matrica.GetLength(1); j++)
            {
                if (min > matrica[i, j])
                {
                    min = matrica[i, j];
                    minRow = i;
                    minCol = j;
                }
            }
        }

        return (min, minRow, minCol);
    }

    static int[,] unesiMatricu()
    {
        Console.WriteLine("Unesite broj redova i kolona matrice:");
        int red = Convert.ToInt32(Console.ReadLine());
        int kol = Convert.ToInt32(Console.ReadLine());
        int[,] matrica = new int[red, kol];

        Console.WriteLine("Unesite vrednosti:");
        for (int i = 0; i < red; i++)
        {
            for (int j = 0; j < kol; j++)
            {
                matrica[i, j] = Convert.ToInt32(Console.ReadLine());
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
