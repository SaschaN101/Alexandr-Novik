namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Определите переменные всех возможных примитивных типов С#


            int x;
             Console.WriteLine("Введите число типа int");
            x = Int32.Parse(Console.ReadLine());           
            Console.WriteLine(x);

            long xxxx;
             Console.WriteLine("Введите число типа long");
            xxxx = Convert.ToInt64(Console.ReadLine());           
            Console.WriteLine(xxxx);

             float fla;
             Console.WriteLine("Введите число типа float");
             fla = float.Parse(Console.ReadLine());
             Console.WriteLine(fla);

            ushort ush;
            Console.WriteLine("Введите число типа ushort");
            ush = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine(ush);

           
             Console.WriteLine("Введите bool");
            bool boolStr = Boolean.Parse(Console.ReadLine());      
            Console.WriteLine(boolStr);




        }

            

    }   
}