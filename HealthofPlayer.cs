using System;
namespace PlayerHealth;
class Player
{ 
	private int _amount;

	public int Health
	{
		get { return _amount; }
	}

	public Player(int startingHealth = 100)
	{
		if (startingHealth < 0)
		{
			_amount = 0;
		}
		else if (startingHealth > 100)
		{
			_amount = 100;
		}
		else
		{
			_amount = startingHealth;
		}
	}
	public void Heal(int amount)
    {
        Console.WriteLine("Player gulps Baja Blast...");

        if (_amount >= 100)
        {
            Console.WriteLine("Player is already at max health. Baja Strength Boost activated ");
            Console.WriteLine($"Health: {_amount}");
            return;
        }

        if (amount < 0)
        {
            amount = 0;
        }

        _amount += amount;
        if (_amount > 100)
        {
            Console.WriteLine("Player is already at max health. Baja Strength Boost activated ");
            _amount = 100;
            Console.WriteLine($"Player Health: {_amount} points");
		}
        else 
		{
            Console.WriteLine($"Player heals: {amount} points");
        	Console.WriteLine($"Player Health: {_amount} points");
        }

        //Console.WriteLine($"Player heals: {amount} points");
       // Console.WriteLine($"Player Health: {_amount} points");
    }


	public void TakeDamage(int amount)
	{
		if (amount < 0)
		{
			amount = 0;
		}

		_amount -= amount;//this line: take the damage passed in from porgram cs and math it onto the real prvivate variable
		if (_amount < 0)
		{
			_amount = 0;
		}

		Console.WriteLine($"Player takes {amount} damage.");
		Console.WriteLine($"Health: {_amount}");
		if (_amount == 0)
		{
			Console.WriteLine("Player defeated");
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

}//end of Player class