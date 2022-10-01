using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class RadToDegree
{
    //unity engine source code again
    const float Deg2Rad = (float)Math.PI / 180f;
    float degree;

    public void AskForData(out bool res)
    {
        Console.WriteLine("add meg a fokot");
        bool rad = float.TryParse(Console.ReadLine(), out degree);
        res = rad;
    }

    public string GetResult()
    {
        return (degree * Deg2Rad).ToString();
    }
}

