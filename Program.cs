using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

	public static class UserData
	{
		public static string ID;
		public static string UserName;
		public static float Health;
		public static int Point;

		static UserData()
		{
			ID = "2203311";
			UserName = "Quoc phan";
			Health = 110f;
			Point = 300;
		}
		public static void Main(string[] args)
		{
			System.Console.WriteLine("ID " + UserData.ID);
			System.Console.WriteLine("Name " + UserData.UserName);
			System.Console.WriteLine("Health " + UserData.Health);
			System.Console.WriteLine("Point " + UserData.Point);

		}
	}

