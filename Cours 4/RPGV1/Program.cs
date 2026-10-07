using RPGV1;

Hero Hero1 = new Hero(20);
Hero Hero2 = new Hero(20);

Arena arena = new Arena(Hero1, Hero2);

arena.Combat(Hero1, Hero2);
