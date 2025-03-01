/**
 * 05. Game Of Intervals
 */

//•	Първи ред - колко хода ще има по време на играта – цяло число в интервала [1...100]
//•	За всеки ход – числата, които се проверяват в кой интервал са – цели числа в интервала [-100...100]

int iterations = int.Parse(Console.ReadLine());

double scores = 0.0, numsBetween0And9 = 0.0, numsBetween10and19 = 0.0, numsBetween20And29 = 0.0, numsBetween30And39 = 0.0, 
numsBetween40And50 = 0.0, invalidNumbers = 0.0;

//•	От 0 до 9  20 % от числото
//•	От 10 до 19  30 % от числото
//•	От 20 до 29  40 % от числото
//•	От 30 до 39  50 точки
//•	От 40 до 50  100 точки
//•	Невалидно число  резултата се дели на 2
//Освен резултата програмата трябва да изкарва статистика за проценти числа в дадените интервали.

for (int i = 0; i < iterations; i++)
{
    int inputNumber = int.Parse(Console.ReadLine()); //входящия номер

    if (inputNumber >= 0 && inputNumber <= 9)
    {
        numsBetween0And9++;
        scores += inputNumber * 0.2;
    }
    else if (inputNumber >= 10 && inputNumber <= 19)
    {
        numsBetween10and19++;
        scores += inputNumber * 0.3;
    }
    else if (inputNumber >= 20 && inputNumber <= 29)
    {
        numsBetween20And29++;
        scores += inputNumber * 0.4;
    }
    else if (inputNumber >= 30 && inputNumber <= 39)
    {
        numsBetween30And39++;
        scores += 50;
    }
    else if (inputNumber >= 40 && inputNumber <= 50)
    {
        numsBetween40And50++;
        scores += 100;
    }
    else 
    { 
        scores /= 2;
        invalidNumbers++;
    }
}

//•	1ви ред: "{Краен резултат}"
//•	2ри ред: "From 0 to 9: {процент в интервала}%"
//•	3ти ред: "From 10 to 19: {процент в интервала}%"
//•	4ти ред: "From 20 to 29: {процент в интервала}%"
//•	5ти ред: "From 30 to 39: {процент в интервала}%"
//•	6ти ред: "From 40 to 50: {процент в интервала}%"
//•	7ми ред: "Invalid numbers: {процент в интервала}%"

Console.WriteLine($"{scores:F2}");
Console.WriteLine($"From 0 to 9: {numsBetween0And9 / iterations * 100:F2}%");
Console.WriteLine($"From 10 to 19: {numsBetween10and19 / iterations * 100:F2}%");
Console.WriteLine("From 20 to 29: {0:F2}%", numsBetween20And29 / iterations * 100);
Console.WriteLine("From 30 to 39: {0:F2}%", numsBetween30And39 / iterations * 100);
Console.WriteLine("From 40 to 50: {0:F2}%", numsBetween40And50 / iterations * 100);
Console.WriteLine("Invalid numbers: {0:F2}%", invalidNumbers / iterations * 100);