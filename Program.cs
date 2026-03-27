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
		Console.WriteLine("Ahoy matey, take a look in my special " +
		"treasure chest \nwhile i make a deposit");
		player.Heal();
		player.Heal();
		player.TakeDamage();
		player.TakeDamage();

		
	}
}