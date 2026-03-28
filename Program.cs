using System;
using PlayerHealth;
/*
ºprivate fields
ºpublic methods
ºEncapsulation
ºBasic validation
 */					
public class Program
{
	public static void Main()
	{
		Player player = new Player();
		Console.WriteLine();
		player.TakeDamage(20);
		player.TakeDamage(20);
		player.Heal(35);
		player.Heal(35);
		player.TakeDamage(20);
		player.TakeDamage(20);
		player.TakeDamage(70);
		
		
	}
}