namespace Es21_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = "1,2";
            Calculator calculator = new Calculator();
            int result = calculator.Add(numbers);
            Console.WriteLine(result);
        }
    }
}
