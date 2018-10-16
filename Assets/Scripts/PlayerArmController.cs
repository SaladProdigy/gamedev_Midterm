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

	void Update()
	{
		nervousText.text = "Boyfriend Meter";
		nervousText.text += "\nNervous Level: " + nervousScore.ToString();

		nervousScore += Time.deltaTime;

		if (nervousScore > 100f)
		{
			nervousText.text = "You Lose!";

			Time.timeScale = 0;
		}


	}

	void OnTriggerStay(Collider collision)
	{
		if (collision.gameObject.CompareTag("Boyf_Arm"))
		{
			Debug.Log("Being Touched");

			if (Input.GetMouseButtonDown(0))
			{
				Debug.Log("Being Held");

				nervousScore = 10f;

				Debug.Log("Score Going Down");

			}

		}
	}

	private void OnCollisionStay(Collision collision)
	{
		if  (collision.gameObject.tag == "NPC")
		{
			
			Debug.Log("Touching Humans");

			if (Input.GetMouseButtonDown(0))
			{
				Destroy(collision.gameObject);
			}
		}
	}
}

