using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {
	
	public int startingHealth = 100; 
//	public int currentHealth;  
	public Slider healthSlider;                                 // Reference to the UI's health bar.
//	public Image damageImage; 	



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter(Collision collision){

		startingHealth--;
		healthSlider.value = startingHealth;
		if (startingHealth == 0 )
		{
			Application.LoadLevel("youwon");
		}

	
	}
}




//var healthSlider : Slider;                                 // Reference to the UI's health bar.

