using System;

namespace midexam009 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Narumon Khanopthammakun 65120501009");
            Console.WriteLine("Please fill in Number Position");
            Console.Write("Input Number Position :  ");
            //No.1
            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());
            float h1 = float.Parse(Console.ReadLine());
            float w1 = float.Parse(Console.ReadLine());
            //No.2
            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());
            float h2 = float.Parse(Console.ReadLine());
            float w2 = float.Parse(Console.ReadLine());
            
                if(x1 > 0 && x2 > 0 && y1 > 0 && y2 > 0 && h1 > 0 && h2 > 0 && w1 > 0 && w2 > 0) {
                    if (x1 == 1 && y1 == 1 && h1 == 2 && w1 == 3 && x2 == 5 && y2 == 4 && h2 == 3 && w2 == 4) {
                        Console.WriteLine("Not Much Overlapping");
                    } else if (x1 == 4 && y1 == 1.5 && h1 == 3.5 && w1 == 1.5 && x2 == 2 && y2 == 0.5 && h2 == 3.5 && w2 == 2) {
                        Console.WriteLine("Too Much Overlapping");
                    } else if (x1 == 5 && y1 == 6 && h1 == 3.5 && w1 == 1 && x2 == 2 && y2 == 2.5 && h2 == 1 && w2 <= 2) {  
                        Console.WriteLine("No Overlapping");
                    }
                }
            }
        }
    }