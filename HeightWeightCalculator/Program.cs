using System;

namespace HeightWeightCalculator 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--- Quel taille dois-je prendre ? ---");
            Console.Write("Entrez votre taille (en cm) : ");
            int personHeight = int.Parse(Console.ReadLine());
            Console.Write("Entrez votre poids (en kg) : ");
            int personWidth = int.Parse(Console.ReadLine());


        }
    }
}