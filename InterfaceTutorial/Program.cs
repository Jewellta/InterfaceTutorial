using System;

namespace InterfaceTutorial
{
	class Program
	{
		static void Main(string[] args)
		{
			{
				var gs = new GermanShepherd();
				gs.SetName("Arlo");

				var p = new Pug();
				p.SetName("daisy");

				var bs = new BassetHound();
				bs.SetName("Charles");

				var dp = new DogParrot();
				dp.SetName("Flap");

				var dogs = new IBarkAble[]
				{
				gs,p,bs,dp
				};

				foreach (var dog in dogs)
				{
					Console.WriteLine($"The  dog {dog.GetName()} says {dog.Bark()}");

				}
			}
		}
	}
}
