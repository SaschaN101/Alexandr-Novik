
Console.WriteLine("двухмерный массив");
int[,] array = new int[,] { {10, 20, 30, 40}, {-50, -60, -70, -80} };
int[][] array2 = new int[][] 
{new int[] {44, 55, 66, 77},
new int[] {303, -101}
};

int minValue = int.MaxValue;
int maxValue = int.MinValue;
for (int i = 0; i <= array.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= array.GetUpperBound(1); j++)
            {
                 if (array[i,j] < minValue)
                 minValue = array[i,j];
                if (array[i, j] > maxValue)
                    maxValue = array[i, j];
            }
        };
Console.WriteLine($"maxValue array = {maxValue}, minValue array = {minValue}");

Console.WriteLine();
Console.WriteLine("зубчатый массив"); 
int minValue2 = int.MaxValue;
int maxValue2 = int.MinValue;
for (int i = 0; i < array2.Length; i++)
{
    for (int j = 0; j < array2[i].Length; j++)
    {
        if (array2[i][j] < minValue2)
            minValue2 = array2[i][j];
        if (array2[i][j] > maxValue2)
            maxValue2 = array2[i][j];
    }
};
Console.WriteLine($"maxValue array2 = {maxValue2}, minValue array2 = {minValue2}");

Console.WriteLine(); 
Console.WriteLine("сортировка массива");
int[] arraySort = new int[] {10, 25, -15, 35, 69, 101};
for (int i = 0; i < arraySort.Length; i++)
{
    for (int j = 0; j < arraySort.Length; j++)
    {
        if (j < arraySort.Length - 1) 
        {
            if (arraySort[j] > arraySort[j+1])
            {
                int buffer;
                buffer = arraySort[j + 1];
                arraySort[j + 1] = arraySort[j];
                arraySort[j] = buffer;
            }
        }
    }
}
for (int i = 0; i < arraySort.Length; i++)
    Console.WriteLine(arraySort[i] + " ");
Array.Sort(arraySort);
Console.WriteLine();
for (int i = 0; i < arraySort.Length; i++)
    Console.WriteLine(arraySort[i] + " ");