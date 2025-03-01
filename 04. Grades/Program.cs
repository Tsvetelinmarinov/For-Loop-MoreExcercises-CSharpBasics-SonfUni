/**
 * 04. Grades
 */

int studentsCount = int.Parse(Console.ReadLine());

//В началото програмата получава броят на студентите явили се на изпита и за всеки студент неговата оценка.
//На края програмата трябва да изпечата процента на студенти с оценка между 2.00 и 2.99, между 3.00 и 3.99,
//между 4.00 и 4.99, 5.00 или повече. Също така и средният успех на изпита.

double badStudents = 0.0, middleStudents = 0.0, goodStudents = 0.0, excellentStudents = 0.0, arithmeticMean = 0.0, total = 0.0;

//10
//3.00
//2.99
//5.68
//3.01
//4
//4
//6.00
//4.50
//2.44
//5

for (int i = 0; i < studentsCount; i++)
{
    double grade = double.Parse(Console.ReadLine());

    if (grade > 0 && grade <= 2.99) { badStudents++; }
    else if (grade >= 3 && grade <= 3.99) { middleStudents++; }
    else if (grade >= 4 && grade <= 4.99) { goodStudents++; }
    else if (grade >= 5) { excellentStudents++; }
    else
    {
        Console.WriteLine("Invalid input!");
        Environment.Exit(0);
    }

    total += grade;
}

arithmeticMean = total / studentsCount;

//Ред 1 -	"Top students: {процент студенти с успех 5.00 или повече}%"
//Ред 2 -	"Between 4.00 and 4.99: {между 4.00 и 4.99 включително}%"
//Ред 3 -	"Between 3.00 and 3.99: {между 3.00 и 3.99 включително}%"
//Ред 4 -	"Fail: {по-малко от 3.00}%"
//Ред 5 -	"Average: {среден успех}"

Console.WriteLine($"Top students {excellentStudents / studentsCount * 100:F2}%");
Console.WriteLine($"Between 4 and 4.99: {goodStudents / studentsCount * 100:F2}%");
Console.WriteLine($"Between 3 and 3.99: {middleStudents / studentsCount * 100:F2}%");
Console.WriteLine($"Fail: {badStudents / studentsCount * 100:F2}%");
Console.WriteLine($"{arithmeticMean:F2}");