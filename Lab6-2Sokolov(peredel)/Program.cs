using ClassLibrary1;
try
{
    double[,] matrix = new double[6, 4];

    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"Введите элемент [{i}, {j}]: ");
            matrix[i, j] = double.Parse(Console.ReadLine()!);
        }
    }

    double[] maxElements = ClassLibrary1.Class1.abs(matrix);
    Console.WriteLine("максимальные элементы строк матрицы");
    for (int i = 0; i < 6; i++)
    {
        Console.Write(maxElements[i] + " ");
    }
}
catch (Exception ex)
{ Console.WriteLine(ex.Message); }