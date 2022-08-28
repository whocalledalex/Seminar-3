// Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Insert a number with 5 digits:");
double N = Convert.ToDouble(Console.ReadLine());
palindromeCheck(N);

void palindromeCheck(double x)
{

    if ((Math.Floor(x / 10000) == x % 10) && (Math.Floor(x / 1000) % 10 == Math.Floor((N % 100)/10)))
    Console.WriteLine($"{x} is palindrome");

    else Console.WriteLine($"{x} is not a palindrome");
}




// Задача 21

// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.WriteLine("Insert the first coordinate for A:");
// int Ax = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insert the second coordinate for A:");
// int Ay = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insert the third coordinate for A:");
// int Az = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insert the first coordinate for B:");
// int Bx = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insert the second coordinate for B:");
// int By = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Insert the third coordinate for B:");
// int Bz = Convert.ToInt32(Console.ReadLine());
// findDistance(Ax, Ay, Bx, By, Az, Bz);

// void findDistance(int Ox, int Oy, int Oz, int Nx, int Ny, int Nz)
// {
//     double distance = Math.Sqrt(Math.Pow((Ox - Nx), 2) + Math.Pow((Oy - Ny), 2)+ Math.Pow((Oz - Nz), 2));
// //f2 or f5 - to leave the needed number of digits after the comma
//     Console.WriteLine($"The distance is {distance:f2}");
// }






// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Insert a number:");
// int N = Convert.ToInt32(Console.ReadLine());
// rowOfSquares(N);

// void rowOfSquares (int x)
// {

//     for (int i = 1; i <= N; i++)
//     {
//         Console.Write($"{Math.Pow(i, 3)} ");
//     }
// }