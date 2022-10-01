using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class VectorDistance
{
    Vector2 a, b;

    public void AskForData(out bool res)
    {
        float ax, ay, bx, by;
        Console.WriteLine("első x");
        bool fx = float.TryParse(Console.ReadLine(), out ax);
        Console.WriteLine("első y");
        bool fy = float.TryParse(Console.ReadLine(), out ay);
        Console.WriteLine("második x");
        bool sx = float.TryParse(Console.ReadLine(), out bx);
        Console.WriteLine("második y");
        bool sy = float.TryParse(Console.ReadLine(), out by);

        a = new Vector2(ax, ay);
        b = new Vector2(bx, by);

        res = fx && fy && sx && sy;
    }

    public float GetResult()
    {
        float dist = Vector2.Distance(a, b);
        return (float)Math.Round(dist, 3);
    }
}

public struct Vector2
{
    public float x, y;

    public static float Distance(Vector2 a, Vector2 b)
    {
        //unity engine source code cuz im lazy
        float num = a.x - b.x;
        float num2 = a.y - b.y;
        float res = (float)Math.Sqrt(num * num + num2 * num2);
        return (float)Math.Round(res, 3);
    }

    public Vector2(float X, float Y)
    {
        x = X;
        y = Y;
    }
}

