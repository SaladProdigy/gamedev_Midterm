using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Brings Boyfriend closer to Player
//If Boyfriend is too far away, he gets Nervous
//If Nervous is at 100, game Ends 
//ADD: Text, Score, Boyf Drag
public class PlayerArmController : MonoBehaviour
{
	public float nervousScore = 50f;
	public Text nervousText;
	
	public float thrust;
	public Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void Update()
	{
		nervousText.text = "Boyfriend Meter";
		nervousText.text += "\nNervous Level: " + nervousScore.ToString();

		nervousScore += .01f;

		if (nervousScore > 100f)
		{
			nervousText.text = "You Lose!";

			Time.timeScale = 0;
		}

		if (nervousScore < 0)
		{
			nervousScore = 0;;
		}


	}

	void OnTriggerStay(Collider collision)
	{
		if (collision.gameObject.CompareTag("Boyf_Arm"))
		{
			Debug.Log("Being Touched");

			if (Input.GetMouseButton(0))
			{
				Debug.Log("Being Held");

				nervousScore -= 0.5f;

				Debug.Log("Score Going Down");

			}

		}
	}

	private void OnCollisionStay(Collision collision)
	{
		
		float force = 3;
		Vector3 direction = new Vector3(-10 ,20, 0);
		
		if  (collision.gameObject.tag == "NPC")
		{
			
			Debug.Log("Touching Humans");

			if (Input.GetMouseButton(0))
			{
				
				Debug.Log("Pushing");
				rb.AddForce(direction * thrust);
				//rb.AddForce(transform.forward * thrust);
			}
		}
	}
}

