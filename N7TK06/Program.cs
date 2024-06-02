//Kirjutage programm, mis teisendab Fahrenheiti kraadi Celsiuse järgi ja vastupidi.
//* Programm võimaldab kasutajal valida, kas teisendada väärtuse Celciusesse või Farenheiti.
//* Kui kasutaja on oma valiku teinud, programm küsib sisendit, teostab arvutusi ja kuvab tulemuse.
//* fahrenheit = (celsius * 9) / 5 + 32;
//* celsius = (fahrenheit - 32) * 5 / 9;

//NB! Programmis peab olema kaks funktsiooni:

//static void ConverToCelsius(argument) { }
//static void ConvertToFahrenheit(argument) { }

Console.WriteLine($"Make a choice whether convert the temperature to Celsius or to Fahrenheit degrees? (C/F):");
char userChoice = char.Parse(Console.ReadLine());

switch (userChoice)
{
    case 'c' or 'C':
        Console.WriteLine($"Enter the temperature to convert:");
        int userInputF = Int32.Parse(Console.ReadLine());
        ConvertToCelsius(userInputF);
        break;
    case 'f' or 'F':
        Console.WriteLine($"Enter the temperature to convert:");
        int userInputC = Int32.Parse(Console.ReadLine());
        ConvertToFahrenheit(userInputC);
        break;
    default:
        Console.WriteLine($"You did an unacceptable choice!");
        break;
}

//functions
static void ConvertToCelsius(int userInputF)
{
    Console.WriteLine($"The temperature you entered is {(userInputF-32)*5/9} degrees by Celsius.");
}

static void ConvertToFahrenheit(int userInputC)
{
    Console.WriteLine($"The temperature you entered is {userInputC*9/5+32} degrees by Fahrenheit.");
}