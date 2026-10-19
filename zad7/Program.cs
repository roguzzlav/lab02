Console.WriteLine("Podaj wiek:");
string age = Console.ReadLine();
int.TryParse(age, out int ageConv);

if(ageConv >= 0 && ageConv <= 12)
    Console.WriteLine("Dziecko");
else if (ageConv >= 13 && ageConv <= 17)
    Console.WriteLine("Nastolatek");
else if (ageConv >= 18 && ageConv <= 64)
    Console.WriteLine("Osoba dorosła");
else if (ageConv >= 65)
    Console.WriteLine("Senior");
else
    Console.WriteLine("Niepoprawny wiek");

