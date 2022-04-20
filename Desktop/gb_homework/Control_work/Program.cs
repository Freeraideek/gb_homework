//Программма для создания массива из строк, длинна которых меньше либо равна 3 символа.

namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Программист", "это", "не", "просто", "професия", "а", "призвание", "но", "им", "все", "равно", "может", "стать", "каждый" };
            var arrayOne = new string[array.Length];
            var size = 0;

            foreach (var value in array)
            {
                if (value.Length <= 3)
                {
                    arrayOne[size] = value;
                    size++;
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, arrayOne, 0, size));
        }
    }
}