// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечётных/чётных чисел.

Console.Clear();

Random rnd = new Random();

Console.Write("На сколько элементов задаём массив? ");
int elem = int.Parse(Console.ReadLine());
int[] array = new int[elem];

for (int i = 0; i < elem; i++)
{
    array[i] = rnd.Next(100, 1000);
    Console.Write(array[i] + "\t");
}

int par = 0;
int notpar = 0;

for (int j = 0; j < elem; j++)
{
    if (array[j]%2 == 0) par++;
    else notpar++;
}
Console.WriteLine();
Console.WriteLine($"количество четных элементов - {par}");
Console.WriteLine($"количество нечетных элементов - {notpar}");