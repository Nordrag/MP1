﻿int selection;

Console.WriteLine("válassz feladatot (1, autós, 2 festék, 3 pontok távolsága, 4 radian");
selection = int.Parse(Console.ReadLine());

switch (selection)
{
	case 1:

		CarConsumption carConsumption = new CarConsumption();
		bool carInputSuccess;
		carConsumption.AskForData(out carInputSuccess);

		if (carInputSuccess)
		{
			carConsumption.PrintResult();
		}
		else
		{
			Console.WriteLine("hibás input, lusta voltam loopolni szóval most megáll");
		}
		break;
	case 2:
		Container container = new Container();
		bool containerInputSuccess;
		container.AskForData(out containerInputSuccess);

		if (containerInputSuccess)
		{
			container.PrintResult();
		}
        else
        {
            Console.WriteLine("hibás input, lusta voltam loopolni szóval most megáll");
        }

        break;
	case 3:

		VectorDistance distance = new VectorDistance();
		bool distanceInputSuccess;
		distance.AskForData(out distanceInputSuccess);

		if (distanceInputSuccess)
		{
			distance.PrintResult();
		}
        else
        {
            Console.WriteLine("hibás input, lusta voltam loopolni szóval most megáll");
        }
        break;

	case 4:

		RadToDegree radToDegree = new RadToDegree();
		bool radInputSuccess;
		radToDegree.AskForData(out radInputSuccess);

		if (radInputSuccess)
		{
			radToDegree.PrintResult();
		}
        else
        {
            Console.WriteLine("hibás input, lusta voltam loopolni szóval most megáll");
        }
        break;
	case 5:

		Railway railway = new Railway();
		bool railwayInputSuccess;
		railway.AskForData(out railwayInputSuccess);

		if (railwayInputSuccess)
		{
			railway.PrintResult();
		}
        else
        {
            Console.WriteLine("hibás input, lusta voltam loopolni szóval most megáll");
        }
        break;
	default:
		break;
}