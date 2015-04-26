using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

	public Text bomb = null;
	public Text lives = null;
	
	// Reset bomb count to 0 when level 3 is loaded
	void OnLevelWasLoaded ()
	{
		if (Application.loadedLevelName == "Level"){
			Data.Instance.Bomb = 0;
		}
	}
	
	void Update()
	{
		this.lives.text = "Lives: " + Data.Instance.Lives.ToString ();
		this.bomb.text = Data.Instance.Bomb.ToString();
	}
}
