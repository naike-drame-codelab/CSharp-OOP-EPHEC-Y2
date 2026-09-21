using TempConverter;

Temperature temperature = new Temperature(10, 'C');
Console.WriteLine("Température en Celsius : " + temperature.EnCel() + "° C.");
Console.WriteLine("Température en Fahrenheit : " + temperature.EnFar() + "° F.");

Temperature temperature2 = new Temperature(23, 'F');
Console.WriteLine("Température en Fahrenheit : " + temperature2.EnFar() + "° F.");
Console.WriteLine("Température en Celsius : " + temperature2.EnCel() + "° C.");
