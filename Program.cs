using System;

namespace midexam009 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Please fill in Number");
            Console.Write("Input Number :  ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());
            int num6 = int.Parse(Console.ReadLine());
            int num7 = int.Parse(Console.ReadLine());
            int num8 = int.Parse(Console.ReadLine());

            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int y2= int.Parse(Console.ReadLine());
            int h1 = int.Parse(Console.ReadLine());
            int h2 = int.Parse(Console.ReadLine());
            int w1 = int.Parse(Console.ReadLine());
            int w2 = int.Parse(Console.ReadLine());
            
            
            if (num1 > 0 && num2 > 0 && num3 > 0 && num4 > 0 && num5 > 0 && num6 > 0 && num7 > 0 && num8 > 0 ) {

            





            
            if (!(x % 9 == 0)) {
            Console.WriteLine("not divisible");

       
            if (x % 2 == 0 && x < 0) {
            Console.WriteLine("both even and negative");
       } else if (x % 2 == 0 && x >= 0) {
            Console.WriteLine("even");
       } else if (x < 0 && x % 2 != 0) {
            Console.WriteLine("Negative");
       } else {
            Console.WriteLine("don't care");
       }
    }
}
}