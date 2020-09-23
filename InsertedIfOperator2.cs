using System;
class Programm
{
    static void Main()
    {
        int number;
        Console.Write("ВВедите целое число:");
        number = Int32.Parse(Console.ReadLine());
        if (number == 1)
            Console.WriteLine("Адын");
        else if (number == 2)
            Console.WriteLine("Два");
         else if (number == 3)
            Console.WriteLine("Три");
         else if (number == 4)
            Console.WriteLine("Четыре");
         else
            Console.WriteLine("Хз");
      
    }
}