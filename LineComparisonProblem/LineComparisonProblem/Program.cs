using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Display_Welcome_to_Line_Comparison
{
    public class Line
    {
        public void ComputeLength(Double x1, Double x2, Double y1, Double y2)
        {



            Double Length_of_line = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("Calculate of The Lines " + Length_of_line);
            Console.ReadKey();
        }
    }
    class program
    {

        static void Main(string[] args)
        {

            Double x1, x2, y1, y2;
            Console.WriteLine("Enter the Co-ordinates of frist Line");
            Console.WriteLine("Enter the Value of x1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Value of x2");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Value of y1:");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Value of y2:");
            y2 = Convert.ToDouble(Console.ReadLine());
            Line line = new Line();
            line.ComputeLength(x1, x2, y1, y2);

        }
    }
}