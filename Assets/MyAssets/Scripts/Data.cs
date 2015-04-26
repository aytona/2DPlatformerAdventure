using UnityEngine;
using System.Collections;

public class Data
{
	private static Data instance = null;
	
	public static Data Instance
	{
		get {
			if (instance == null)
			{
				instance = new Data();
			}
			return instance;
		}
	}
	
	private Data(){}
	
	private int bomb = 0;
	public int Bomb
	{
		get {
			return this.bomb;
		}
		set {
			bomb = value;
		}
	}

	private int lives = 5;
	public int Lives
	{
		get {
			return this.lives;
		}
		set {
			lives = value;
		}
	}
}
