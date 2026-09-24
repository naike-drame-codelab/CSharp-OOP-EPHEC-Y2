using TempConverter;

//Temperature temperature = new Temperature(10, 'C');
//Console.WriteLine("Température en Celsius : " + temperature.EnCel() + "° C.");
//Console.WriteLine("Température en Fahrenheit : " + temperature.EnFar() + "° F.");

//Temperature temperature2 = new Temperature(23, 'F');
//Console.WriteLine("Température en Fahrenheit : " + temperature2.EnFar() + "° F.");
//Console.WriteLine("Température en Celsius : " + temperature2.EnCel() + "° C.");

Temperaturev2 temp = new Temperaturev2(20.0, 'C'); 
Console.WriteLine("=== Test 1 : Création initiale à 20°C ===");
Console.WriteLine($"Celsius    : {temp.GetCel()} °C");
Console.WriteLine($"Fahrenheit : {temp.GetFar()} °F");
Console.WriteLine($"Chauffage requis ? {temp.Chauffage()}"); // Doit afficher False

Console.WriteLine("\n----------------------------------------\n");

// 2. Modification de la température via le Setter Celsius
Console.WriteLine("=== Test 2 : Modification avec SetCel(10) ===");
temp.SetCel(10.0);

// La valeur en Fahrenheit doit s'être mise à jour automatiquement (10°C = 50°F)
Console.WriteLine($"Celsius    : {temp.GetCel()} °C");
Console.WriteLine($"Fahrenheit : {temp.GetFar()} °F");
Console.WriteLine($"Chauffage requis ? {temp.Chauffage()}"); // Doit afficher True (< 15°C)

Console.WriteLine("\n----------------------------------------\n");

// 3. Modification de la température via le Setter Fahrenheit
Console.WriteLine("=== Test 3 : Modification avec SetFar(86) ===");
temp.SetFar(86.0);

// La valeur en Celsius doit s'être mise à jour automatiquement (86°F = 30°C)
Console.WriteLine($"Celsius    : {temp.GetCel()} °C");
Console.WriteLine($"Fahrenheit : {temp.GetFar()} °F");
Console.WriteLine($"Chauffage requis ? {temp.Chauffage()}"); // Doit afficher False

// Empêche la console de se fermer immédiatement
Console.ReadLine();
