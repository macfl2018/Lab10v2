using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab10v._1
{
    class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine(GetProperRadius());

            Console.WriteLine();
            Console.ReadLine();



        }




        public static int GetProperRadius()
        {

            int newRadius = 0;
            bool convertOrNot = false;

            do
            {

                Console.WriteLine("Please Provide an integer value for the radius of your circle.");
                var response = Console.ReadLine();
                convertOrNot = Int32.TryParse(response, out newRadius);


            } while (convertOrNot == false);

            var newCircle = new Circle();
            //newCircle.radius = newRadius;

            return newRadius;

        }



        public class Circle
        {


            public int radius;
            var PI = Math.PI;



            public void AddNewCirle(int newRadius)

            {


                newRadius = radius;

            }




            public double CalculataeCircumference(double circumfrance)
            {


                circumfrance = Math.PI * radius * 2;

                return circumfrance;

            }

            public string CalculateFormattedCircumference(string area)

            {

                return area;

            }

            public double CalculateArea(double areaD)
            {

                return areaD;

            }

            //// public  CalculatedFormattedArea(string areaformated)
            // {


            //     return void; 

            // }





        }










    }





}