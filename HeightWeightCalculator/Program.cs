using System;

namespace HeightWeightCalculator;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("--- Quel taille dois-je prendre ? ---");
        Console.Write("Entrez votre taille (en cm) : ");
        int personHeight = int.Parse(Console.ReadLine());
        Console.Write("Entrez votre poids (en kg) : ");
        int personWeight = int.Parse(Console.ReadLine());

        // Si je fais entre 145cm et 160cm  et que je pése entre 43kg et 65kg
        if (personHeight >= 145 && personHeight <= 160 && personWeight  >= 43 && personWeight <= 65)
        {
            Console.WriteLine("Prenez la taille 1\n");
        } 
        // Si je fais entre 163cm et 165cm et que je pése entre 43kg et 59kg
        else if(personHeight >= 163 && personHeight <= 165 && personWeight >= 43 && personWeight <= 59)
        {
            Console.WriteLine("Prenez la taille 1\n");
        }
        // Si je fais entre 163cm et 165cm et que je pése entre 66kg et 71kg
        else if (personHeight >= 163 && personHeight <= 165 && personWeight >= 66 && personWeight <= 71)
        {
            Console.WriteLine("Prenez la taille 2\n");
        }
        // Si je fais entre 163cm et 165cm et que je pése entre 72kg et 77kg
        else if (personHeight >= 163 && personHeight <= 165 && personWeight >= 66 && personWeight <= 71)
        {
            Console.WriteLine("Prenez la taille 3\n");
        }
        // Si je fais entre 166cm et 168cm et que je pése entre 43kg et 53kg
        else if (personHeight >= 166 && personHeight <= 168 && personWeight >= 43 && personWeight <= 53)
        {
            Console.WriteLine("Prenez la taille 1\n");
        }
        // Si je fais entre 166cm et 168cm et que je pése entre 54kg et 71kg
        else if (personHeight >= 166 && personHeight <= 168 && personWeight >= 54 && personWeight <= 71)
        {
            Console.WriteLine("Prenez la taille 2\n");
        }
        // Si je fais entre 166cm et 168cm et que je pése entre 72kg et 77kg
        else if (personHeight >= 166 && personHeight <= 168 && personWeight >= 72 && personWeight <= 77)
        {
            Console.WriteLine("Prenez la taille 3\n");
        }
        // Si je fais entre 169cm et 171cm et que je pése entre 43kg et 47kg
        else if (personHeight >= 169 && personHeight <= 171 && personWeight >= 43 && personWeight <= 47)
        {
            Console.WriteLine("Prenez la taille 1\n");
        }
        // Si je fais entre 169cm et 171cm et que je pése entre 48kg et 71kg
        else if (personHeight >= 169 && personHeight <= 171 && personWeight >= 48 && personWeight <= 71)
        {
            Console.WriteLine("Prenez la taille 2\n");
        }
        // Si je fais entre 169cm et 171cm et que je pése entre 72kg et 77kg
        else if (personHeight >= 169 && personHeight <= 171 && personWeight >= 72 && personWeight <= 77)
        {
            Console.WriteLine("Prenez la taille 3\n");
        }
        // Si je fais entre 172cm et 174cm et que je pése entre 48kg et 65kg
        else if (personHeight >= 172 && personHeight <= 174 && personWeight >= 48 && personWeight <= 71)
        {
            Console.WriteLine("Prenez la taille 2\n");
        }
        // Si je fais entre 172cm et 174cm et que je pése entre 66kg et 77kg
        else if (personHeight >= 172 && personHeight <= 174 && personWeight >= 66 && personWeight <= 77)
        {
            Console.WriteLine("Prenez la taille 3\n");
        }
        // Si je fais entre 175cm et 177cm et que je pése entre 48kg et 58kg
        else if (personHeight >= 175 && personHeight <= 177 && personWeight >= 48 && personWeight <= 58)
        {
            Console.WriteLine("Prenez la taille 2\n");
        }
        // Si je fais entre 175cm et 177cm et que je pése entre 59kg et 64kg
        else if (personHeight >= 175 && personHeight <= 177 && personWeight >= 59 && personWeight <= 64)
        {
            Console.WriteLine("Prenez la taille 3\n");
        }
        // Si je fais entre 178cm et 182cm et que je pése entre 48kg et 53kg
        else if (personHeight >= 178 && personHeight <= 182 && personWeight >= 48 && personWeight <= 53)
        {
            Console.WriteLine("Prenez la taille 2\n");
        }
        // Si je fais entre 178cm et 182cm et que je pése entre 54kg et 77kg
        else if (personHeight >= 178 && personHeight <= 182 && personWeight >= 48 && personWeight <= 53)
        {
            Console.WriteLine("Prenez la taille 3\n");
        }
        // Si je fais entre 182cm et 183cm et que je pése entre 54kg et 77kg
        else if (personHeight >= 182 && personHeight <= 183 && personWeight >= 54 && personWeight <= 77)
        {
            Console.WriteLine("Prenez la taille 3\n");
        }

        Console.WriteLine("Appuyer sur n'importe quel touche pour fermer le programme...");
    }
}