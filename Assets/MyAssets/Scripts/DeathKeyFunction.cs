using UnityEngine;
using System.Collections;

public class DeathKeyFunction : MonoBehaviour {

	void Restart()
	{
		Application.LoadLevel ("Level 1");
		Data.Instance.Lives--;
	}
}
