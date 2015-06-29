using UnityEngine;
using System.Collections;

public class clock : MonoBehaviour 
{	
	public static int timeTotal = 100;
	
	
	void Update () 
	{ 	
		if (timeTotal <= Time.timeSinceLevelLoad) 
		{
			Application.LoadLevel("gameover");
			
		}
	} 
}
