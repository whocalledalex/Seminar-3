// Напишите программу, которая принимает на вход координаты точек Х и Y, где оба не равны 0. 
// и выдает номер четверти плоскости, в которой точка с этими координатами окажется

void printQuarter(int a, int b)
{
    if (a > 0 && b > 0)
    {
        Console.WriteLine("First quarter");
    }

    else if (a < 0 && b > 0)
    {
        Console.WriteLine("Second quarter");
    }
    else if (a < 0 && b < 0)
    {
        Console.WriteLine("Third quarter");
    }
    else if (a > 0 && b < 0)
    {
        Console.WriteLine("Fourth quarter");
    }
    else
    {
        Console.WriteLine("Not possible to define the quarter");
    }
}


Console.WriteLine("Insert X:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insert Y:");
int y = Convert.ToInt32(Console.ReadLine());
printQuarter(x, y);