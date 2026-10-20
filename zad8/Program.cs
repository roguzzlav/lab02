using System.Runtime.CompilerServices;

Console.WriteLine("Podaj ilość punktów życia: ");
string hp = Console.ReadLine();
int.TryParse(hp, out int hpNum);

Console.WriteLine("Czy bohater posiada klucz?");
string key = Console.ReadLine();
bool.TryParse(key, out bool keyBool);

Console.WriteLine("Czy bohater zna hasło?");
string pass = Console.ReadLine();
bool.TryParse(pass, out bool passBool);

if(hpNum<=0)
    Console.WriteLine("Bohater nie może wejść do lochu - nie żyje");
else if(hpNum > 0 && keyBool == true || hpNum > 0 && passBool == true)
    Console.WriteLine("Bohater może wejść do lochu");
else
    Console.WriteLine("Bohater nie może wejść do lochu - nie ma sposobu na otwarcie drzwi");