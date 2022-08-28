// Напишите программу, которая принимает на вход координаты точек Х и Y, где оба не равны 0. 
// и выдает номер четверти плоскости, в которой точка с этими координатами окажется

// void printQuarter(int a, int b)
// {
//     if (a > 0 && b > 0)
//     {
//         Console.WriteLine("First quarter");
//     }

//     else if (a < 0 && b > 0)
//     {
//         Console.WriteLine("Second quarter");
//     }
//     else if (a < 0 && b < 0)
//     {
//         Console.WriteLine("Third quarter");
//     }
//     else if (a > 0 && b < 0)
//     {
//         Console.WriteLine("Fourth quarter");
//     }
//     else
//     {
//         Console.WriteLine("Not possible to define the quarter");
//     }
// }


// Console.WriteLine("Insert X:");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insert Y:");
// int y = Convert.ToInt32(Console.ReadLine());
// printQuarter(x, y);

// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Insert quarter:");
// int x = Convert.ToInt32(Console.ReadLine());

// printRange(x);

// void printRange(int x)
// {
//     if (x == 1)
//     {
//         Console.WriteLine("The range for this quarter is (a>0;b>0)");
//     }
//     else if (x == 2)
//     {
//         Console.WriteLine("The range for this quarter is (a<0;b>0)");
//     }
//     else if (x == 3)
//     {
//         Console.WriteLine("The range for this quarter is (a<0;b<0)");
//     }
//     else if (x == 4)
//     {
//         Console.WriteLine("The range for this quarter is (a>0;b<0)");
//     }
//     else Console.WriteLine("There is now such a range");
// }

// Задача 21: Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


// Console.WriteLine("Insert the first coordinate for A:");
// int Ax = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insert the second coordinate for A:");
// int Ay = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insert the first coordinate for B:");
// int Bx = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insert the second coordinate for B:");
// int By = Convert.ToInt32(Console.ReadLine());


// void findDistance(int Ox, int Oy, int Nx, int Ny)
// {
//     double distance = Math.Sqrt(Math.Pow((Ox - Nx), 2) + Math.Pow((Oy - Ny), 2));
////f2 or f5 - to leave the needed number of digits after the comma
//     Console.WriteLine($"The distance is {distance:f2}");
// }

// findDistance(Ax, Ay, Bx, By);

// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Insert a number:");
int N = Convert.ToInt32(Console.ReadLine());
rowOfSquares(N);

// void rowOfSquares (int x)
// {
//     int index = 1;
//     while (index <= x)
//     {
//         Console.Write($"{Math.Pow(index, 2)} ");
//         index++;
//     }
// }

// other option - for cycle
void rowOfSquares (int x)
{

    for (int i = 1; i <= N; i++)
    {
        Console.Write($"{Math.Pow(i, 2)} ");
    }
}