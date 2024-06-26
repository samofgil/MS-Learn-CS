using System;
using System.Text;
//Use arrays and for-loops to determine & print students' names, scores, and grades.
    //supports extra credit (worth 10%) and the addition of students to the roster.

//TO ADD NEW STUDENTS:
    //1-define "int[] ___Scores" for new student
    //2-Add student name to string[] studentNames
    //3-Add else if condition for (else if (currentStudent == "___"))

// initialize variables - graded assignments
int examAssignments = 5;
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };


int[] studentScores = new int[10];

string currentStudentLetterGrade = "";
decimal studentScore;
string currentStudent = "";

Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");
foreach (string name in studentNames)
{
    int studentSum = 0;
    //determine current student & retrieve their scores
    currentStudent = name;
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else if (currentStudent == "Becky")
    studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;


   //Calculate student's final score
    //studentSum = studentScores.Sum();
    int gradedAssignments = 0;
    decimal examScore = 0;
    int extraCredit = 0;
    decimal extraCreditPoints = 0;
    int extraCreditCount = 0;
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;
        if (gradedAssignments <= examAssignments)
        {
            studentSum += score;
            examScore = studentSum;
        }
        else
        {
            studentSum += score / 10;
            extraCredit += score;
            extraCreditCount++;
        }
    }
    studentScore = (decimal)studentSum / examAssignments;
    examScore /= examAssignments;
    extraCreditPoints = (decimal)extraCredit/10/examAssignments;
    extraCredit /= extraCreditCount;


    //determine student's letter grade
    if (studentScore >= 97)
        currentStudentLetterGrade = "A+";
    else if (studentScore >= 93)
        currentStudentLetterGrade = "A";
    else if (studentScore >= 90)
        currentStudentLetterGrade = "A-";
    else if (studentScore >= 87)
        currentStudentLetterGrade = "B+";
    else if (studentScore >= 83)
        currentStudentLetterGrade = "B";
    else if (studentScore >= 80)
        currentStudentLetterGrade = "B-";
    else if (studentScore >= 77)
        currentStudentLetterGrade = "C+";
    else if (studentScore >= 73)
        currentStudentLetterGrade = "C";
    else if (studentScore >= 70)
        currentStudentLetterGrade = "C-";
    else if (studentScore >= 67)
        currentStudentLetterGrade = "D+";
    else if (studentScore >= 63)
        currentStudentLetterGrade = "D";
    else if (studentScore >= 60)
        currentStudentLetterGrade = "D-";

    Console.WriteLine($"{name}:\t\t{examScore}\t\t" + studentScore + $"\t{currentStudentLetterGrade}\t{extraCredit} ({extraCreditPoints} pts)");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
