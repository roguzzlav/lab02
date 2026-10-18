Console.WriteLine("Podaj liczbę racji żywnościowych: ");
string rationsInput = Console.ReadLine();

Console.WriteLine("Podaj liczbę członków: ");
string membersInput = Console.ReadLine();

Console.WriteLine("Podaj liczbę dni: ");
string daysInput = Console.ReadLine();

int rationsInt = int.Parse(rationsInput);
int membersInt = int.Parse(membersInput);
int daysInt = int.Parse(daysInput);

int fullRations = rationsInt / membersInt;
Console.WriteLine($"Każdy członek drużyny otrzyma {fullRations} pełnych racji.");

int rationsRest = rationsInt % membersInt;
Console.WriteLine($"Po podziale pozostanie {rationsRest} racji.");

double rationsPerDay = (double)rationsInt / daysInt;
Console.WriteLine($"Na drużynę przypadnie {Math.Round(rationsPerDay, 2)} racji dziennie.");

double rationsPerPerson = rationsPerDay / (double)membersInt;
Console.WriteLine($"Średnio na jedną osobę przypadnie {rationsPerPerson} racji dziennie.");