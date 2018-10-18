using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//USAGE: Put this on boyfriend NPC so that he follows Player w/o need of spring joint
//Script should allow boyfriend to try to locate player and freeze once they get to a certain point.
//Put a timer on Freeze so that after a while boyfriend starts going crazy
public class BoyfRayCast : MonoBehaviour
{

	public GameObject michaelText;

	
	// Update is called once per frame
	void Update () {
		
		//STEP 1: Define Ray

		//set to -transform.right since unity doesn't correctly recognize the position of Boyf so 
		//instead of forward, must be set to left
		Ray boyfRay = new Ray(transform.position, -transform.right); //the ray belongs to NPC boyfriend
		
		//STEP 2: Define max distance
		float maxVisibility = 16f; //ray needs to be long to see player from a distance
		
		//STEP 2b: Add a Raycast Hit to see what it hit
		RaycastHit hit;
		
		//STEP 3: Draw out ray
		Debug.DrawRay(boyfRay.origin, boyfRay.direction * maxVisibility, Color.magenta);
		
		//STEP 4: Cast ray

		//If Raycast does not hit player, boyf freezes
		if (Physics.Raycast(boyfRay, out hit, maxVisibility))
		{
			//int randomNumber = Random.Range(0, 1);

			if (hit.transform.tag == "Player")
			{
				Debug.Log("Hitting Player");

				transform.Translate(-0.02f, 0f, 0f);

				michaelText.SetActive(false);
			}
			else
			{
				transform.Rotate(0f, 10f, 0f);
				michaelText.SetActive(true);
				//Add Sound
			}

		}
		else
		{
			transform.Rotate(0f, 10, 0f);
			michaelText.SetActive(true);
			//Add Sound
		}

	}
}
