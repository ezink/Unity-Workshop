using UnityEngine;
using System.Collections;

public class Shoot_mecanim : MonoBehaviour
{
	public Rigidbody bulletprefab; 
	public GameObject spawningpoint;
	public int shootforce = 20;
	public AudioClip shootclip;
	
	
	protected Animator avatar;
	
	void Start () 
	{
		avatar = GetComponent<Animator>();
	}

	void Update () 
	{	
		if (Input.GetButtonDown("Fire1"))
			
		{
			var Bullet = (Rigidbody)Instantiate(bulletprefab, spawningpoint.transform.position , spawningpoint.transform.rotation);
			Bullet.velocity = spawningpoint.transform.TransformDirection(new Vector3 (0,0,shootforce));
			GetComponent<AudioSource>().PlayOneShot(shootclip); 
			avatar.SetBool("Shoot", true);	
		} 
		else  
			avatar.SetBool("Shoot", false);	
		
		
	}
}
