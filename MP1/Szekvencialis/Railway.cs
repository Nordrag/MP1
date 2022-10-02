using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Railway : BaseExcersize
{
    float distance;
    const int costPerTenKilometers = 210;

    public override void AskForData(out bool res)
    {
        Console.WriteLine("add meg a távot (km)");
        bool dist = float.TryParse(Console.ReadLine(), out distance);

        res = dist;
    }

    public override void PrintResult()
    {
        var costMultiplier = MathF.Ceiling(distance / 10);
        var cost = costMultiplier * costPerTenKilometers;       
        var discountCost = cost * .5f;
        int simpleCost = (int)discountCost;
        //egy stringből egyszerű kihúzni az utolsó x elemet
        var stringify = simpleCost.ToString();

        int stringLenght = stringify.Length;

        //valószínű ilyen keveset nem fizet, de ha nincs 2 számjegyű az összeg akkor gondolom ingyen van
        if (stringLenght >= 2)
        {
            //a szöveg max hossza -2 az utolsó 2 számjegy, a második paraméter meg hogy hány darabot számot akarunk, 2-t mivel 50től felfelé kerekítünk
            string lastDigits = stringify.Substring(stringLenght - 2, 2);
            //vissza alakít számmá
            int roundCheck = int.Parse(lastDigits);
            //segéd változó a kerekítéshez
            int round;

            if (roundCheck > 50)
            {
                round = 100;
            }
            else
            {
                round = 0;
            }

            //ezen a pontos az összes pl 220, abból ki kell vonni a 20at, + a kerekítés ami vagy 0 vagy 100
            Console.WriteLine(simpleCost - roundCheck + round);

        }
        else
        {
            Console.WriteLine("az összes nincs 2 számjegy szóval gondolom ingyen utazik a kerekítés miatt");
        }
    }
}

