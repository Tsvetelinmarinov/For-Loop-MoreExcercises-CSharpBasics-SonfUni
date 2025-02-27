/**
 * 01. Back To The Past
 */

//•	Наследените пари – реално число в интервала [1.00 ... 1 000 000.00]
//•	Годината, до която трябва да живее (включително) – цяло число в интервала [1801 ... 1900]

double legacy = double.Parse(Console.ReadLine());
int year = int.Parse(Console.ReadLine());

int age = 17;

//Като приемем, че за всяка четна (1800, 1802 и т.н.) година ще харчи 12 000 лева.
//За всяка нечетна (1801,1803  и т.н.) ще харчи 12 000 + 50 * [годините, които е навършил през дадената година].

for (int i = 1800; i <= year; i++)
{
    if (i % 2 == 0) 
    { 
        legacy -= 12000; 
        age++; 
    }
    else 
    { 
        legacy -= 12000 + 50 * ++age;
    }
}

//•	Ако парите са достатъчно:
//o   "Yes! He will live a carefree life and will have {N} dollars left." – където N са парите, които ще му останат.
//•	Ако парите НЕ са достатъчно:
//o   "He will need {М} dollars to survive." – където M е сумата, която НЕ достига

if (legacy > 0)
{
    Console.WriteLine($"Yes! He will live a carefree life and will have {legacy:F2} dollars left.");
}
else
{
    Console.WriteLine($"He will need {Math.Abs(legacy):F2} dollars to survive.");
}