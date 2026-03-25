using System;
namespace CoolTreasure;
class TreasureChest
{ 
	private int _treasureAmount;

	
	private int TreasureAmount
	{
		get {return _treasureAmount;}
		set {_treasureAmount = value;}
	}
	public int AddGold()
	{
		TreasureAmount = TreasureAmount +1000;
		return TreasureAmount;
	}

	public string RemoveGold()
	{
		if (TreasureAmount < 1000)
		{
			Console.WriteLine("Cannot remove more Gold than is here in the chest");
			return "0";
		}
		else
		{
			TreasureAmount = TreasureAmount - 1000;
			if (TreasureAmount == 0)
			{
				TreasureAmount++;
				Console.WriteLine("Agh pesky BUG get out of here! Darn I dropped a coin in there, I'll just leave it");
			}
		}	
		
		return TreasureAmount.ToString();
	}

	public string DisplayGold()
	{
		return $"Current gold in chest: {TreasureAmount}";
	}
}



/*
 public string Model;
        public int Speed;

        public Car(string model)
        {
            this.Model = model;
            this.Speed = 0;
 */