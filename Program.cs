using System;
using CoolTreasure;
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
		TreasureChest CoolChest = new TreasureChest();
		Console.WriteLine("Ahoy matey, take a look in my special " +
		"treasure chest \nwhile i make a deposit");
		CoolChest.AddGold();
		Console.WriteLine($"Gold added! {CoolChest.DisplayGold()}");
		CoolChest.AddGold();
		Console.WriteLine($"Gold added! {CoolChest.DisplayGold()}");
		CoolChest.RemoveGold();
		Console.WriteLine($"Gold removed! {CoolChest.DisplayGold()}");
		CoolChest.RemoveGold();
		Console.WriteLine($"Gold removed! {CoolChest.DisplayGold()}");
		
	}
}