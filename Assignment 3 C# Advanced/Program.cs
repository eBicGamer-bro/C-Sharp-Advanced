namespace Assignment_3_C__Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = Enumerable.Range(2, 19).Where(n => n % 2 == 0);
            foreach(var number in num)
            {
                Console.WriteLine(number);
            }
            var welcome = Enumerable.Repeat("Hello", 5);
            foreach (var wel in welcome)
            {
                Console.WriteLine(wel);
            }
        }
    }
}
