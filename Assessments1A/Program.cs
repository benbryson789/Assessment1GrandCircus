using System;
using System.Net.NetworkInformation;

namespace Assessments1A
{
    class Program
    {
        static void Main(string[] args)
        {            
            var averageGrade = AverageGrade(50, 69, 70);
            Console.WriteLine(averageGrade);

            var result = IsPassing(averageGrade);
            Console.WriteLine(result);

            var fullResult = OddOrEvenAndPassing(averageGrade);
            Console.WriteLine(fullResult);

            Console.ReadKey();
        }
        static bool IsPassing(double grade)
        {
            if (grade > 65)
            {
                return true;
            }
            return false;
        }
        static double AverageGrade(double grade1, double grade2, double grade3)
        {
            return (grade1 + grade2 + grade3) / 3;
        }

        static string OddOrEvenAndPassing(double grade)
        {
            bool passing = IsPassing(grade);
            bool isEven = (grade % 2 == 0);     
            if(passing)
            {
                if (isEven)
                    return "Passing and Even";
                else
                    return "Passing and Odd";
            }
            else
            {
                if (isEven)
                    return "Failing and Even";
                else
                    return "Failing and Odd";
            }
        }
    }

}

