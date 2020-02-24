using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book tt = new Book();


            tt.InsertMarks(10);
            tt.InsertMarks(5);
            tt.InsertMarks(2);
            tt.InsertMarks(3);
            tt.InsertMarks(4);

            tt.ShowStatistics();








        }
    }
}
