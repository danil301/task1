using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Calc_Square
    {
        public CheckNums CheckNums { get; set; }
        public bool Isrectangular { get; set; }


        public float Circle(float radius)
        {
            CheckNums = new CheckNums();
            if (CheckNums.CheckCircle(radius))
            {
                return (float)(Math.PI * Math.Pow(radius, 2));
            }
            else
            {
                Console.WriteLine("Enter correct numbers.");
                return 0;
            }
            
        }

        public float Triangle(float a, float b, float c)
        {
            CheckNums = new CheckNums();
            if (CheckNums.CheckTriangle(a, b, c))
            {
                CheckNums = new CheckNums();
                Isrectangular = CheckNums.CheckRectangular(a, b, c);
                if (Isrectangular) Console.WriteLine("Triangle is Rectangular");
                double p = (a + b + c) / 2;
                return (float)(Math.Pow(p * (p - a) * (p - b) * (p - c), 0.5));
            }
            else
            {
                Console.WriteLine("Enter correct numbers.");
                return 0;
            }
            
        }

        public float Sqare_CompileTime(float[] nums)
        {
            switch (nums.Length)
            {
                case 1: return this.Circle(nums[0]);
                case 3:
                    {
                        CheckNums = new CheckNums();
                        Isrectangular = CheckNums.CheckRectangular(nums[0], nums[1], nums[2]);
                        return this.Triangle(nums[0], nums[1], nums[2]);
                    }
            }
            Console.WriteLine("Enter correct numbers.");
            return 0;
        }

    }
}
