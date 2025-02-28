

//•	На първия ред – броя на товарите за превоз – цяло число в интервала [1...1000]
//•	За всеки един товар на отделен ред – тонажа на товара – цяло число в интервала [1...1000]

using System.Transactions;

/**
 * 03. Logistics
 */
int packs = int.Parse(Console.ReadLine());

double price = 0.0, bus = 0.0, truck = 0.0, train = 0.0, arithmeticMean = 0.0, totalWeight = 0.0;

//4
//1
//5
//16
//3

for (int i = 0; i < packs; i++)
{
    int weight = int.Parse(Console.ReadLine());

    if (weight > 0 && weight < 4) 
    { 
        bus += weight; 
    }
    else if (weight > 3 && weight < 13) 
    { 
        truck += weight; 
    }
    else if (weight > 11)
    {
        train += weight;
    }
    else
    {
        Console.WriteLine("Invalid input!");
        Environment.Exit(0);
    }
}

totalWeight = bus + truck + train;

arithmeticMean = ((bus * 200) + (truck * 175) + (train * 120)) / totalWeight;

//•	До 3 тона – микробус (200 лева на тон)
//•	От 4 до 11 тона – камион (175 лева на тон)
//•	12 и повече тона – влак (120 лева на тон)

Console.WriteLine($"{arithmeticMean:F2}");
Console.WriteLine($"{bus / totalWeight * 100:F2}%");
Console.WriteLine($"{truck / totalWeight * 100:F2}%");
Console.WriteLine($"{train / totalWeight * 100:F2}%");