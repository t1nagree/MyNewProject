using System.Numerics;
int first, second, stepen, procent;
    Console.WriteLine("Выберите операцию, которую хотите выполнить:");
    Console.WriteLine("1. Сложить два числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");
a:
int operation = Convert.ToInt32(Console.ReadLine());
while (operation <= 9)
{
    switch (operation)
    {
        case 1:

            Console.WriteLine("Введите первое число");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(first + second);
            Console.WriteLine("Вы можете выбрать другую арифметическую операцию из предложенных, либо завершить действие программы");
            goto a;
        case 2:

            Console.WriteLine("Введите первое число");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(first - second);
            Console.WriteLine("Вы можете выбрать другую арифметическую операцию из предложенных, либо завершить действие программы");
            goto a;
        case 3:

            Console.WriteLine("Введите первое число");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(first * second);
            Console.WriteLine("Вы можете выбрать другую арифметическую операцию из предложенных, либо завершить действие программы");
            goto a;
        case 4:

            Console.WriteLine("Введите первое число");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(first / second);
            Console.WriteLine("Вы можете выбрать другую арифметическую операцию из предложенных, либо завершить действие программы");
            goto a;
        case 5:

            Console.WriteLine("Введите первое число");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень, в которую нужно возвести число");
            stepen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Pow(first, stepen));
            Console.WriteLine("Вы можете выбрать другую арифметическую операцию из предложенных, либо завершить действие программы");
            goto a;
        case 6:

            Console.WriteLine("Введите число, из которого необходимо найти квадратный корень");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(first));
            Console.WriteLine("Вы можете выбрать другую арифметическую операцию из предложенных, либо завершить действие программы");
            goto a;
        case 7:

            Console.WriteLine("Введите число, от которого необходимо найти один процент");
            procent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(procent / 100);
            Console.WriteLine("Вы можете выбрать другую арифметическую операцию из предложенных, либо завершить действие программы");
            goto a;
        case 8:

            Console.WriteLine("Введите число, для нахождения факториала из него");
            int factorial = Convert.ToInt32(Console.ReadLine());
            {
                BigInteger a = 1;
                for (int i = factorial; i >= 1; i--)
                    a *= i;
                Console.WriteLine(a);
            }
            Console.WriteLine("Вы можете выбрать другую арифметическую операцию из предложенных, либо завершить действие программы.");
            goto a;

        case 9:
            goto b;
    }
b:
    Console.WriteLine("Работа программы завершена.");
    break;
}