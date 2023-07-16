
void Task19()
{
    Console.WriteLine("Введите пятизначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    string numberStr = Convert.ToString(number);

    if (numberStr[0] == numberStr[4] && numberStr[1] == numberStr[3])
    {
        Console.Write($"Число {number} - полиндром");
    }
    else
    {
        Console.Write($"Число {number} - не полиндром");
    }

}

void Task21()
{
    Console.WriteLine("Введите координаты первой точки через пробел");
    int[] xyz = Console.ReadLine().Split().Select(int.Parse).ToArray();
    Console.WriteLine("Введите координаты второй точки через пробел");
    int[] xyz1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
    
    double result = Math.Sqrt(Math.Pow(xyz[0]-xyz1[0],2) + Math.Pow(xyz[1]-xyz1[1],2) + Math.Pow(xyz[2]-xyz1[2],2));
    result = Math.Round(result, 3);
    Console.WriteLine(result);
}

void Task23()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    //number = Math.Abs(number);
        for (int counter = 1; counter <= number; counter++)
    {
        double result = Math.Pow(counter,3);
        //Console.Write(result + ",");
        Console.Write(result + " ");
    } 
    //Console.WriteLine("\b\b"); хотела через запятую вывести, но потом подумала зачем, но всё-таки интересно,
    //как бы то было корректно убрать запятую последнюю, у меня не вышло.
}
Task23();