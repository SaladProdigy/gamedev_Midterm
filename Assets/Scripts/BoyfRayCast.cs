using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//USAGE: Put this on boyfriend NPC so that he follows Player w/o need of spring joint
//Script should allow boyfriend to try to locate player and freeze once they get to a certain point.
//Put a timer on Freeze so that after a while boyfriend starts going crazy
public class BoyfRayCast : MonoBehaviour
{

	
	// Update is called once per frame
	void Update () {
		
		//STEP 1: Define Ray

		Ray boyfRay = new Ray(transform.position, transform.forward); //the ray belongs to NPC boyfriend
		
		//STEP 2: Define max distance
		float maxVisibility = 10f; //ray needs to be long to see player from a distance
		
		//STEP 2b: Add a Raycast Hit to see what it hit
		RaycastHit hit;
		
		//STEP 3: Draw out ray
		Debug.DrawRay(boyfRay.origin, boyfRay.direction * maxVisibility, Color.magenta);
		
		//STEP 4: Cast ray

		//If Raycast does not hit player, boyf freezes
		if (Physics.Raycast(boyfRay, out hit, maxVisibility))
		{
			int randomNumber = Random.Range(0,1);
			
			if (hit.transform.tag == "Player")
			{
				Debug.Log("Hitting Player");
				
				transform.Translate(0f, 0f, 0.02f);
			}
			else
			{
				//if less than 50, turn left else turn right
				if (randomNumber < 1)
				{
					transform.Rotate(0f, -3f, 0f);
				}
				else
				{
					transform.Rotate(0f, 3f, 0f);
				}
			}
			
		}
		
	}
}
