internal class Program
{
    /*3. Згенерувати масив із 20 випадкових цілих чисел у діапазоні від 1
до 50 і відсортувати його методом обміну. Знайти min і max елементи
масиву.*/
    private static void Main(string[] args)
    {
    int[] mas = new int[20];
    Random random = new Random();
    for(int i = 0; i < mas.Length; i++)
        mas[i] = random.Next(1, 50);
        int temp;
    for (int i = 1; i < mas.Length; i++)
        for (int j = 0; j < mas.Length - i; j++)
            if (mas[j] > mas[j + 1])
            {
            temp = mas[j];
            mas[j] = mas[j + 1];
            mas[j + 1] = temp;
            }
    int min = mas[0];
        for (int i = 1; i < mas.Length; i++)
            if (mas[i] < min)
                min = mas[i];
        Console.WriteLine("min = " + min);

    int max = mas[0];
        for (int i = 1; i < mas.Length; i++)
            max = mas[i];
        Console.WriteLine("max = " + max);
    }
}