using UnityEngine;
using System.Collections;

public class BulletImpact : MonoBehaviour {

	public static int score = 0;
	public GameObject explosion;

	void OnCollisionEnter(Collision other)
	{
		score++;
		Destroy(gameObject);
		//Destroy(other.gameObject);
		Instantiate(explosion, transform.position, transform.rotation);
	}
}
