using System;
namespace Inheritance
{
	public class Reptile : Animals
	{
		public Reptile()
		{
            IsAlive = true;
            LandSeaAir = "Land";
            LegCount = 4;
            Age = 0;
        }
		public bool IsColdBlooded { get; set; }
		public bool IsScaly { get; set; }
		public string Habitat { get; set; }
		public bool CanGrowTail { get; set; }
	}
}

