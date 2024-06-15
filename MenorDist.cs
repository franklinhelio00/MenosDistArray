using System;
using System.Collections.Generic;
public class MenorDistanciaArrays
{
    public static void Main(string[] args)
    {
        int[] array1 = { 15, 250, 30, 10, 100, 150, 170, 240, 370, 450 };
        int[] array2 = { 26, 60, 130, 270, 310, 40, 210, 190, 390, 400 }; 

        int menorDistancia = EncontrarMenorDist(array1, array2, out List<(int, int, int)> todasDistancias);
        Console.WriteLine("A menor distância entre dois arrays é: " + menorDistancia);
    
    }

    public static int EncontrarMenorDist(int[] array1, int[] array2, out List<(int, int, int)> todasDistancias)
    {
        todasDistancias = new List<(int, int, int)>();
        int menorDistancia = int.MaxValue;

        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < array2.Length; j++)
            {
                int distancia = Math.Abs(array1[i] - array2[j]);
                todasDistancias.Add((i, j, distancia));

                if (distancia < menorDistancia)
                {
                    menorDistancia = distancia;
                }
            }
        }

        return menorDistancia;
    }
}
