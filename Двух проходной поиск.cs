using System.Text;
class Program
{
    public static int max = 0;
    public static int min = 10000;
    public static int count = 0;
    public static int sum = 0;
    public static int sumMin = 20000;
    public static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines("17-342.txt");
        int[] array = Array.ConvertAll(lines, s => int.Parse(s));
        //Console.WriteLine("[{0}]", string.Join(", ", array)); Вывод массива
        for (int a = 0; a < array.Length; a++)
        {
            if (array[a] < min && array[a] % 37 == 0)
            {
                min = array[a]; // найден больший элемент
            }
            if (array[a] > max && array[a] % 73 == 0)
            {
                max = array[a]; 
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 37 == 0 && array[i + 1] % 73 == 0)
            {
                count++;
                sum = array[i] + array[i + 1];
                if (sum < sumMin)
                { sumMin = sum; }
                else if (sum > sumMin)
                { sumMin = sumMin; }
                 //Вывод пары
            }
            else
            { sumMin = 0; }
            continue;
        }
        Console.WriteLine("Количество пар: " + count);
        Console.WriteLine("Минимальная сумма пар: " + sumMin);
        Console.WriteLine("Минимальное число кратное 37: " + min);
        Console.WriteLine("Максимальное число кратное 73: " + max);
    }