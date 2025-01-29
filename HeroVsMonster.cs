Random random = new Random();
int damage = random.Next(1,11);

int hero = 10;
int monster = 10;

do{
    damage = random.Next(1,11);
        monster -=damage;
        Console.WriteLine($"Monster lost {damage} health! Remaining health: {monster}");
        if (monster > 0){
            damage = random.Next(1,11);
            hero -=damage;
            Console.WriteLine($"Hero lost {damage} health! Remaining health: {hero}");
        }    
}while ((monster > 0)&&(hero > 0));

if (monster <= 0 ){
    Console.WriteLine("Monster is dead!");
}
else 
{
    Console.WriteLine("Hero is dead!");
}
