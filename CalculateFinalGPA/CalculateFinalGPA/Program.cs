using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFinalGPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = "Sophia Johnson";
            string course1Name = "English 101";
            string course2Name = "Algebra 101";
            string course3Name = "Biology 101";
            string course4Name = "Computer Science I";
            string course5Name = "Psychology 101";

            int course1Credit = 3;
            int course2Credit = 3;
            int course3Credit = 4;
            int course4Credit = 4;
            int course5Credit = 3;

            int gradeA = 4;
            int gradeB = 3;

            int course1Grade = gradeA;
            int course2Grade = gradeB;
            int course3Grade = gradeB;
            int course4Grade = gradeB;
            int course5Grade = gradeA;

            int totalCredits = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

            int totalGradePoints = course1Grade * course1Credit;
            totalGradePoints += course2Grade * course2Credit;
            totalGradePoints += course3Grade * course3Credit;
            totalGradePoints += course4Grade * course4Credit;
            totalGradePoints += course5Grade * course5Credit;

            decimal gradePointAverage = (decimal)totalGradePoints / totalCredits;

            int leadingDigit = (int)gradePointAverage;
            int trailingDigits = (int)(gradePointAverage * 100) - leadingDigit * 100;

            Console.WriteLine($"Student: {studentName}\n");
            Console.WriteLine("Course\t\t\tGrade\tCredit Hours");
            Console.WriteLine($"{course1Name}\t\t{course1Grade}\t{course1Credit}");
            Console.WriteLine($"{course2Name}\t\t{course2Grade}\t{course2Credit}");
            Console.WriteLine($"{course3Name}\t\t{course3Grade}\t{course3Credit}");
            Console.WriteLine($"{course4Name}\t{course4Grade}\t{course4Credit}");
            Console.WriteLine($"{course5Name}\t\t{course5Grade}\t{course5Credit}\n");

            Console.WriteLine($"Final GPA:\t\t{leadingDigit}.{trailingDigits}");
        }
    }
}
