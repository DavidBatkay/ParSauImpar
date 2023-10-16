namespace ParSauImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Introduceti un numar intreg: ");
            a = int.Parse(Console.ReadLine());
            if (a%2==0)
            Console.WriteLine("Numarul este par");
            else
            Console.WriteLine("Numarul este impar");
        }
    }
}