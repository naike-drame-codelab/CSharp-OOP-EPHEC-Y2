using RPGv2;

Arme a1 = new Arme("Excalibur", 5);
Arme a2 = new Arme("Arondight", 5);
Heros Arthur = new Heros("Arthur", 50, a1);
Heros Lancelot = new Heros("Lancelot", 50, a2);

Arthur.Duel(Lancelot);
