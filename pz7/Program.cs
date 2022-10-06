namespace pz7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 10 чисел");
            char[] numbers = new char[10];

        //    
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToChar(Console.ReadLine());
            }
            Array.Sort(numbers);
            foreach(char c in numbers)
            {
                Console.Write(c);
            }
            Console.WriteLine($" {numbers[9]}");
        }
    }
}