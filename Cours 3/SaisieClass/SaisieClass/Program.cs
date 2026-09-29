using SaisieClass;

int entier =  Saisie.LireInt("Entrez un entier : ");
double doubleValue = Saisie.LireDouble("Entrez un double : ");
bool boolValue = Saisie.LireBool("Entrez un booléen (true/false) : ");

Console.WriteLine("Valeurs saisies :");
Console.WriteLine($"Entier : {entier}");
Console.WriteLine($"Double : {doubleValue}");
Console.WriteLine($"Booléen : {boolValue}");