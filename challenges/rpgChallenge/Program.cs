int heroHealth = 10;
int monsterHealth = 10;

Random heroAttack = new Random();
Random monsterAttack = new Random();



do
{

    int heroAttackValue = heroAttack.Next(1, 11);
    int monsterAttackValue = monsterAttack.Next(1, 11);

    monsterHealth -= heroAttackValue;
    Console.WriteLine($"Monster was damaged and lost {heroAttackValue} health and now has {monsterHealth} health");
    
    if (monsterHealth <= 0) continue;

    heroHealth -= monsterAttackValue;
    Console.WriteLine($"Hero was damaged and lost {monsterAttackValue} health and now has {heroHealth} health");

    if (heroHealth <= 0) continue;


} while ((heroHealth > 0) && (monsterHealth > 0));

Console.WriteLine(heroHealth > monsterHealth ? "Hero slays Monster!" : "Monster slays Hero!");