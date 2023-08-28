namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Abhay";
            Console.WriteLine("Hey "+name);
            // String Interpolation
            Console.WriteLine($"Hey {name} has {name.Length} letters");
            // Replace
            name = name.Replace("Abhay","Bhandari");
            Console.WriteLine(name);
            // UpperCase
            name = name.ToUpper();
            Console.WriteLine(name);
            // Searching
            Console.WriteLine(name.Contains("Bhandari"));
        }
    }
}