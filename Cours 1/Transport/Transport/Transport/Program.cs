using Transport;

Personne Proprietaire = new Personne("Dupont", "Max", 1990);
//Proprietaire?.Nom = "Dupont";
//Proprietaire?.Prenom = "Max";
Voiture VoitureDeMax = new Voiture("Peugeot", "308", 123456, 25000);
Proprietaire?.Voiture = VoitureDeMax;
//VoitureDeMax.Marque = "Peugeot";
//VoitureDeMax.Modele = "308";
//VoitureDeMax.NumSerie = 123456;
//VoitureDeMax.PrixCatalogue = 25000;
VoitureDeMax.CalculerPrixVente(10);
VoitureDeMax.Afficher();
Proprietaire?.Afficher();


// Camion CamionDeMax = new Camion("Camion de Max", 2000, "Charleroi");
// Camion CamionDeNaïké = new Camion("Camion de Naïké", 1000, "Bruxelles");
//Marchandise Pommes = new Marchandise("Pommes", 500, "Charleroi");
//Marchandise Poires = new Marchandise("Poires", 300, "Wavre");

//Console.WriteLine("Il y a " + Pommes.Poids + "kg de " + Pommes.Description + " stockées à " + Pommes.Localisation);
//// Console.WriteLine("Il y a " + Poires.Poids + "kg de " + Poires.Description + " stockées à " + Poires.Localisation);

//Console.WriteLine(CamionDeMax.Description + " contient " + CamionDeMax.Charge + "kg de marchandises (reste " + CamionDeMax.GetChargeDisponible() + "kg de charge disponible)");
//// Console.WriteLine(CamionDeNaïké.Description + " contient " + CamionDeNaïké.Charge + "kg de marchandises (reste " + CamionDeNaïké.GetChargeDisponible() + "kg de charge disponible)");
//Console.WriteLine("Il se trouve à " + CamionDeMax.Localisation);

//if (CamionDeMax.Charger(Pommes))
//    Console.WriteLine("Chargement OK");
//else
//    Console.WriteLine("Chargement non OK");

////if (CamionDeMax.Charger(Poires))
////    Console.WriteLine("Chargement OK");
////else
////    Console.WriteLine("Chargement non OK");

//Console.WriteLine("Le camion contient " + CamionDeMax.GetCharge() + "kg de marchandises (reste " + CamionDeMax.GetChargeDisponible() + "kg de charge disponible)");

//CamionDeMax.RoulerVers("Bruxelles");
//CamionDeMax.DechargerTout();

//Console.WriteLine("Il y a " + Pommes.Poids + "kg de " + Pommes.Description + " stockées à " + Pommes.Localisation);
//Console.WriteLine(CamionDeMax.Description + " contient " + CamionDeMax.Charge + "kg de marchandises (reste " + CamionDeMax.GetChargeDisponible() + "kg de charge disponible)");
//Console.WriteLine("Il se trouve à " + CamionDeMax.Localisation);

//CamionDeMax.Decrire();
//Pommes.Decrire();
