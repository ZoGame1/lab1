using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


	public class Mapslab1
	{
	string ID;
	string Name;

	private static string InGame = "Lien Minh Huyen Thoai";

	public Mapslab1(string iD, string name)
	{
		ID = iD;
		Name = name;
	}
	public string showData()
	{
		return "ID: "+ID + " | Name: " + Name + " | IN Game" + InGame;
	}
}

