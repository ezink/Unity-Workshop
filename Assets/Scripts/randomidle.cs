using UnityEngine;
using System.Collections;

public class randomidle : StateMachineBehaviour {
	
	override public void OnStateMachineEnter(Animator animator, int pathHash) 
	{
      
		animator.SetInteger("IndleIndex", (int)Random.Range(0.0f, 2.99f));
		// instantica here the bullet but location and physics.

	}
	
}
