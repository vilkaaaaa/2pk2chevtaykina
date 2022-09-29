namespace pz6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double m = 1;
            int i = 1;
            while(m<n)
            {
                m = Math.Pow(2, i);
                i++;
               if(m<n)
                Console.WriteLine(m);
            }
        }
    }
}