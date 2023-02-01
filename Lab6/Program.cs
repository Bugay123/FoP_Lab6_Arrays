class Program
{
    /*1. Реалізувати функцію знаходження всіх простих чисел від 1 до 100.
    Згенеровані числа зберегти в масиві.Елементи масиву вивести на
    консоль.При реалізації використати алгоритм Ератосфена.*/

    private static void Main(string[] args)
    {
        bool[] table = new bool[100];
        int i, j;
        int count = 0;
        
        for (i = 0; i < table.Length; i++)
            table[i] = true;
        
        for (i = 2; i * i < table.Length; i++)
                if (table[i])
                    for (j = 2 * i; j < table.Length; j += i)
                        table[j] = false; 
        for (i = 2; i < table.Length; i++)
        {
            if (table[i]) 
                count++; 
        }

        int[] simpleNumbers = new int[count];
        int k = 0; 
        for (i = 2; i < table.Length; i++)
        {
            if (table[i]) 
            {
                simpleNumbers[k] = i; 
                Console.WriteLine(simpleNumbers[k]); 
                k++;

            }
        }
    }
}
