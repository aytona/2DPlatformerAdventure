using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {

	[SerializeField] private GameObject T1 = null;
	[SerializeField] private GameObject T2 = null;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Player") {
			T1.collider2D.enabled = true;
			T1.renderer.enabled = true;
			T2.collider2D.enabled = true;
			T2.collider2D.enabled = true;
		}
	}
}
