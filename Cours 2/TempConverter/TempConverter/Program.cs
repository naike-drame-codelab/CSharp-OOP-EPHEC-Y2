using TempConverter;

Temperature temperature = new Temperature(10, 'C');
Console.WriteLine("Température en Celsius : " + temperature.temp + "° " + temperature.unite);
temperature.Convertir();
Console.WriteLine("Température en Fahrenheit : " + temperature.temp + "° " + temperature.unite);
