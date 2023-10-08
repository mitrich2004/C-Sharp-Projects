using System;

namespace GradeStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examAssigments = 5;

            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            int[] studentScores = new int[10];

            Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

            foreach (string name in studentNames)
            {
                string currentStudent = name;

                if (currentStudent == "Sophia")
                    studentScores = sophiaScores;

                else if (currentStudent == "Andrew")              
                    studentScores = andrewScores;
                
                else if (currentStudent == "Emma")
                    studentScores = emmaScores;

                else if (currentStudent == "Logan")
                    studentScores = loganScores;

                else
                    continue;

                int sumExamScores = 0;
                int sumExtraCredits = 0;

                decimal currentStudentExamScore;
                decimal currentStudentExtraCredits;
                decimal currentStudentExtraPoints;
                decimal currentStudentGrade;
                string currentStudentLetterGrade;

                int gradedAssigments = 0;
                foreach (int score in studentScores)
                {
                    gradedAssigments += 1;

                    if (gradedAssigments <= examAssigments)
                        sumExamScores += score;

                    else
                        sumExtraCredits += score;
                }

                currentStudentExamScore = (decimal)sumExamScores / examAssigments;
                currentStudentExtraCredits = (decimal)sumExtraCredits / (gradedAssigments - examAssigments);
                currentStudentExtraPoints = (decimal)sumExtraCredits / examAssigments / 10;
                currentStudentGrade = currentStudentExamScore + currentStudentExtraPoints;

                if (currentStudentGrade >= 97)
                    currentStudentLetterGrade = "A+";

                else if (currentStudentGrade >= 93)
                    currentStudentLetterGrade = "A";

                else if (currentStudentGrade >= 90)
                    currentStudentLetterGrade = "A-";

                else if (currentStudentGrade >= 87)
                    currentStudentLetterGrade = "B+";

                else if (currentStudentGrade >= 83)
                    currentStudentLetterGrade = "B";

                else if (currentStudentGrade >= 80)
                    currentStudentLetterGrade = "B-";

                else if (currentStudentGrade >= 77)
                    currentStudentLetterGrade = "C+";

                else if (currentStudentGrade >= 73)
                    currentStudentLetterGrade = "C";

                else if (currentStudentGrade >= 70)
                    currentStudentLetterGrade = "C-";

                else if (currentStudentGrade >= 67)
                    currentStudentLetterGrade = "D+";

                else if (currentStudentGrade >= 63)
                    currentStudentLetterGrade = "D";

                else if (currentStudentGrade >= 60)
                    currentStudentLetterGrade = "D-";

                else
                    currentStudentLetterGrade = "F";
                

                Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCredits} ({currentStudentExtraPoints} pts)");
            }

            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();
        }
    }
}
