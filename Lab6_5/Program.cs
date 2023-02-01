internal class Program
{
    /*5. Створити у коді одновимірний масив з 25 цілих чисел від 1 до 24
Знайти кількість елементів у масиві, які діляться на 3.*/

    private static void Main(string[] args)
    {
        int[] a = new int[25];
        int count = 0;
        for(int i = 0; i < 25; i++)
        {
            a[i] = i + 1;
        }
        for(int i = 0; i < a.Length; i++)
        {
            if(i%3 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}