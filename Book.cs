using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    class Book
    {

        public List<double> grades;


        public void InsertMarks(double t)
        {

            grades.Add(t);
        }



        public void ShowStatistics()
        {
            double average = 0;
            double high = 0;
            double low = 0;
            double sum = 0;


            foreach(var number in  grades)
            {
                low = Math.Min(number, low);
                high = Math.Max(number, high);
                sum += number;
                


                


                
            }
            average = sum / grades.Count;
            Console.WriteLine($"The highehst mark is {high}");
            Console.WriteLine($"The lowest mark is {low}");
            Console.WriteLine($"The Avergae mark is {average}");
            

        }



    }
}
