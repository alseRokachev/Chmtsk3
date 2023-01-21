// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Вариант ввода по отдельности

System.Console.Write("Введите X координату первой точки: ");
int firstX = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите Y координату первой точки: ");
int firstY = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите Z координату первой точки: ");
int firstZ = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("--------------------");

System.Console.Write("Введите X координату второй точки: ");
int secondX = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите Y координату второй точки: ");
int secondY = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите Z координату второй точки: ");
int secondZ = Convert.ToInt32(Console.ReadLine());

double firstSqr = Math.Pow(firstX - secondX, 2);
double secondSqr = Math.Pow(firstY - secondY, 2);
double thirdSqr = Math.Pow(firstZ - secondZ, 2);

double answer = Math.Sqrt(firstSqr + secondSqr + thirdSqr);

System.Console.WriteLine($"Ответ: {Math.Round(answer, 3)}");




// Вариант с массивом

System.Console.Write("Введите координаты первой точки через запятую(X,Y,Z): ");
string? firstMass = Console.ReadLine();
int firstMassLength = firstMass.Length;

System.Console.Write("Введите координаты второй точки через запятую(X,Y,Z): ");
string? secondMass = Console.ReadLine();
int secondMassLength = firstMass.Length;

if (firstMassLength == 5 & secondMassLength == 5)
{
    double firstSqr = Math.Pow(firstMass[0] - secondMass[0], 2);
    double secondSqr = Math.Pow(firstMass[2] - secondMass[2], 2);
    double thirdSqr = Math.Pow(firstMass[4] - secondMass[4], 2);

    double answer = Math.Sqrt(firstSqr + secondSqr + thirdSqr);

    System.Console.WriteLine($"Ответ: {Math.Round(answer, 3)}");

}
else if (firstMassLength == 3 & secondMassLength == 3)
{
    double firstSqr = Math.Pow(firstMass[0] - secondMass[0], 2);
    double secondSqr = Math.Pow(firstMass[1] - secondMass[1], 2);
    double thirdSqr = Math.Pow(firstMass[2] - secondMass[2], 2);

    double answer = Math.Sqrt(firstSqr + secondSqr + thirdSqr);

    System.Console.WriteLine($"Ответ: {Math.Round(answer, 3)}");

}
else
{
    System.Console.WriteLine("Неправильно введены координаты");
}