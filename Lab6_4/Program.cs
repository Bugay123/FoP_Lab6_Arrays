internal class Program
{
    /*4. Згенерувати одновимірний масив 120 випадкових цілих чисел.
Ввести з консолі шуканий елемент. Знайти перше входження
шуканого елементу у масиві. Потім в окремому циклі знайти останнє
входження елементу.*/
    private static void Main(string[] args)
    {
        // int[] mas = new int[120];
        int[] mas = {1,2,3,4,5,6,7,5,9,5,11,5 };
        /*Random random = new Random();
        for (int i = 0; i < mas.Length; i++)
            mas[i] = random.Next(10, 15);*/
        Console.WriteLine("Введіть елемент массиву ");
        int find = int.Parse(Console.ReadLine());

        for (int i = 0; i < mas.Length; i++)
            if (mas[i] == find)
            {
               Console.WriteLine("Перше місце елементу " + find + " знаходиться на " + (i + 1) + " місці");
               break;
             }
        int lastInd = 0;
        for (int i = mas.Length - 1; i >= 0; i--)
            if (mas[i] == find)
            {
                lastInd = i; //mas[i]
                break;
            }
        Console.WriteLine("Останне місце елементу " + find + " знаходиться на " + lastInd + " місці");
        Console.ReadLine();
    }
}
    