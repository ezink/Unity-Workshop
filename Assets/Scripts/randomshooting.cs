using UnityEngine;
using System.Collections;

public class randomshooting : StateMachineBehaviour {
	
	override public void OnStateMachineEnter(Animator animator, int pathHash) 
	{
        
		animator.SetInteger("ShootIndex", (int)Random.Range(0.0f, 2.99f));

	}
	
}
