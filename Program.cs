namespace ClassLab
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var worker = new Worker("Иванов", 20000, "1972-12-26");

            Console.WriteLine(worker.GetAge());
            Console.WriteLine(worker.GetDaysTo50Year());
        }
    }
}