
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет




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
int per=0;
Console.Write("Введите число для поиска: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        if (nums[i, j] == m) {

        Console.Write ($"Указанное число находится в ячейке с адресом:  {i}, {j}");
        Console.WriteLine();
        per++;

    }

    
}

}
if (per ==0)
Console.WriteLine("Указанного числа нет в массиве");

