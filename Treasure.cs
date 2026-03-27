using System;
namespace PlayerHealth;
class Player
{ 
	private int _amount;
	
	private int _Amount
	{
		get {return _Amount;}
		set {_Amount = _amount;}
	}
	public int Heal(int _Amount)
	{
		if (_Amount >= 100)
		{
			_Amount = 100;
			Console.WriteLine("Player cannot heal more, Strength Boost activated");
		}
		else
		{
			_Amount += 50;
			Console.WriteLine($"Player gulps Baja Blast... " 
			+ $"\nPlayer Health: {_Amount}");
			
		}
		return _amount;
	}

	public int TakeDamage( int _Amount)
	{
		if (_Amount < 0)
		{
			Console.WriteLine("Player defeated");
			_Amount=0;
			return _amount;
		}
		else
		{
			_Amount = _Amount - 20;
			if (_Amount <= 0)
			{
				_Amount = 0;
			}
		}	
		
		return _amount;
	}

}//end of Player class


/*
 public string Model;
        public int Speed;

        public Car(string model)
        {
            this.Model = model;
            this.Speed = 0;




 */