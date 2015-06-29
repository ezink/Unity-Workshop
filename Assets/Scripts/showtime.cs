using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class showtime : MonoBehaviour {

	public float timeleft; 
	public Text Timertext;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		timeleft = 30 - Time.timeSinceLevelLoad;
		Timertext.text = ((int)timeleft).ToString();

		if (timeleft < 1)

		{
			Application.LoadLevel("youwon");
		}
	
	}
}
