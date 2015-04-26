using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {

	/// <summary>
	/// The speed of the bullet.
	/// </summary>
	[SerializeField] private float speed = 3f;
	
	/// <summary>
	/// The default lifespan of the bullet.
	/// </summary>
	[SerializeField] private float lifespan = 20f;
	
	/// <summary>
	/// Bullet's direction.
	/// </summary>
	[SerializeField] private Vector3 myDirection = Vector3.up;
	
	private bool isDestroyed = false;
	
	void Awake ()
	{
		StartCoroutine(LifespanCoroutine());
		StartCoroutine(MovementCoroutine());
		this.particleSystem.enableEmission = false;
	}
	
	void LateUpdate ()
	{
		if (this.isDestroyed)
		{
			this.particleSystem.enableEmission = true;
			this.renderer.enabled = false;
		}
	}
	
	private IEnumerator LifespanCoroutine ()
	{
		yield return new WaitForSeconds(this.lifespan);
		this.isDestroyed = true;
	}
	
	private IEnumerator MovementCoroutine ()
	{
		while (true)
		{
			// Move the projectile in the set direction, at the set speed, smoothly through time, for each frame.
			this.transform.Translate(this.myDirection * this.speed * Time.deltaTime);
			yield return new WaitForEndOfFrame();
		}
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "DWall")
		{
			this.isDestroyed = true;
		}
	}
}
