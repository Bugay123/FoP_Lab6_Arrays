internal class Program
{
    /*2. Згенерувати масив 30 випадкових цілих чисел в діапазоні від 10 до
100. Обчислити середнє арифметичне елементів масиву і добуток
перших трьох чисел Результати вивести на консоль.*/
    private static void Main(string[] args)
    {
        int[] mas = new int[30];
        Random random = new Random();
        int sum = 0, avg = 0, mult = 0;

        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = random.Next(10, 100);
            sum += mas[i];
        }
        avg = sum / mas.Length;
        Console.WriteLine(avg);

        mult = mas[0] * mas[1] * mas[3];
        Console.WriteLine(mult);
    }
}