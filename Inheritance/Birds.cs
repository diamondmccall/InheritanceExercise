using System;
namespace Inheritance
{
	public class Birds : Animals
	{
		public Birds()
		{
			IsAlive = true;
			LandSeaAir = "Air";
			LegCount = 2;
			Age = 0;

		}
		public string WingColor { get; set; }
		public bool CanFly { get; set; }
		public bool WillMigrate { get; set; }
		public double BeakLength { get; set; }

		
		
		
	

	}
}

