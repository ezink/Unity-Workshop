using UnityEngine;
using System.Collections;

public class findtarget : MonoBehaviour 
{
	public float navDistance = 3f;
	public Rigidbody bulletprefab; 
	public GameObject spawningpoint;
	public int shootforce = 20;
	public GameObject navTarget;
	public float timeBetweenShots = 2f;
	
	NavMeshAgent navAgent;
	float ellapsedTime;


	void Start ()
	{	 




		navAgent = GetComponent<NavMeshAgent>();
		navTarget = GameObject.FindGameObjectWithTag("Player");

		ellapsedTime = 0f;



	}
	
	void Update ()
	{	
		ellapsedTime += Time.deltaTime;

		navAgent.SetDestination(navTarget.transform.position);
		transform.LookAt (navTarget.transform.position);

		if (navAgent.remainingDistance < navDistance && ellapsedTime >= timeBetweenShots)
		{
			navAgent.destination = transform.position;
			Rigidbody Bullet = Instantiate(bulletprefab, spawningpoint.transform.position , spawningpoint.transform.rotation) as Rigidbody;
			Bullet.velocity = spawningpoint.transform.TransformDirection(new Vector3 (0,0,shootforce));

			ellapsedTime = 0f;
		}

	}
}
