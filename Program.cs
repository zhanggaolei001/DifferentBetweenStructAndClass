using System;

namespace DifferentBetweenStructAndClass
{
    //https://bbs.csdn.net/topics/399055308?page=1#post-414144690
    class Program
    {
        static void Main(string[] args)
        {

            //第一种,如果使用类.
            PointClass p1 =new PointClass(){X = 0,Y=0};
            PointClass p2 = p1;
            p1.X = 1;
            p1.Y = 1;
            Console.WriteLine($"p1.X:{p1.X},p1.Y:{p1.Y}");
            Console.WriteLine($"p2.X:{p2.X},p2.Y:{p2.Y}");

            //第二种,如果使用结构体.
            PointStruct p3 = new PointStruct() { X = 0, Y = 0 };
            PointStruct p4 = p3;
            p3.X = 1;
            p3.Y = 1;
            Console.WriteLine($"p3.X:{p3.X},p3.Y:{p3.Y}");
            Console.WriteLine($"p4.X:{p4.X},p4.Y:{p4.Y}");
            Console.ReadKey();
        }
    }

    public class PointClass
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    public struct PointStruct
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
