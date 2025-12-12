// IST 1551, Lab #5, Tegan Herring, 10/22/2025
Console.Write("Enemy X: ");

int enemyX = Convert.ToInt32(Console.ReadLine());

Console.Write("Enemy Y: ");

int enemyY = Convert.ToInt32(Console.ReadLine());

if (enemyY > 0)
{
    if (enemyX < 0)
    {
        Console.WriteLine("The enemy is to the northwest!");
    } else if (enemyX == 0)
    {
        Console.WriteLine("The enemy is to the north!");
    } else if (enemyX > 0)
    {
        Console.WriteLine("The enemy is to the northeast!");
    }
} else if (enemyY == 0)
{
    if (enemyX < 0)
    {
        Console.WriteLine("The enemy is to the west!");
    } else if (enemyX == 0)
    {
        Console.WriteLine("The enemy is here!");
    } else if (enemyX > 0)
    {
        Console.WriteLine("The enemy is to the east!");
    }
} else if (enemyY < 0)
{
    if (enemyX < 0)
    {
        Console.WriteLine("The enemy is to the southwest!");
    } else if (enemyX == 0)
    {
        Console.WriteLine("The enemy is to the south!");
    } else if (enemyX > 0)
    {
        Console.WriteLine("The enemy is to the southeast!");
    }
}