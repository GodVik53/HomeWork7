// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.





int[,] nums = new int[3, 4];

for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        nums[i, j] = new Random().Next(0, 10);
    }
}

for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        Console.Write(nums[i, j] + " ");
    }
    Console.WriteLine();
}
double sum = 0;
double mid =0;
Console.Write("Среднее арифметическое каждого столбца: ");
for(int j = 0;j < nums.GetLength(1);j++){
    sum = 0;
    for(int i = 0;i < nums.GetLength(0);i++)
    {
        sum +=nums[i,j];
    }
    mid=sum/nums.GetLength(0);
    Console.Write($"{mid:F2}");

    if (j < nums.GetLength(1) - 1) {
    Console.Write($"; ");   } 
    else {
    Console.Write($".");}
}


