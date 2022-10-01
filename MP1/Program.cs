int selection;

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
			Console.WriteLine(carConsumption.GetResult());
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
			Console.WriteLine(container.GetResult());
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
			Console.WriteLine(distance.GetResult());
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
			Console.WriteLine(radToDegree.GetResult());
		}
        else
        {
            Console.WriteLine("hibás input, lusta voltam loopolni szóval most megáll");
        }
        break;
	default:
		break;
}