/**
 * 02. Hospital
 */

//•	На първия ред – периода, за който трябва да направите изчисления. Цяло число в интервала [1 ... 1000]
//•	На следващите редове(равни на броят на дните) – броя пациенти, които пристигат за преглед за текущия ден. Цяло число в интервала [0…10 000]

int days = int.Parse(Console.ReadLine());

int acceptPacients = 0, sendedPacients = 0, doctors = 7;

//4
//7
//27
//9
//1

for (int i = 1; i <= days; i++)
{
    int pacients = int.Parse(Console.ReadLine());

    if (i == 3 || i == 6 || i == 9 || i == 12)
    {
        if (sendedPacients > acceptPacients) { doctors++; }
    }

    if (pacients <= doctors) 
    { 
        acceptPacients += pacients; 
    }
    else 
    { 
        acceptPacients += doctors;
        sendedPacients += pacients - doctors;
    }
}

//За даден период от време, всеки ден в болницата пристигат пациенти за преглед. Тя разполага първоначално със 7 лекари. 
//Всеки лекар може да преглежда само по един пациент на ден, но понякога има недостиг на лекари,
//затова останалите пациенти се изпращат в други болници. Всеки трети ден, болницата прави изчисления и ако броят на непрегледаните пациенти е 
//по-голям от броя на прегледаните, се назначава още един лекар. Като назначаването става преди да започне приемът на пациенти за деня.

//•	На първия ред: "Treated patients: {брой прегледани пациенти}."
//•	На втория ред: "Untreated patients: {брой непрегледани пациенти}."

Console.WriteLine($"Treated patients: {acceptPacients}.");
Console.WriteLine($"Untreated patients: {sendedPacients}.");