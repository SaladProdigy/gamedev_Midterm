using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ADD Cheering Audio
public class WinState : MonoBehaviour
{

	public GameObject winText;


	void Start()
	{
		winText.SetActive(false);
	}
	
	private void OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.tag == "Boyfriend")
		{
			Time.timeScale = 0;
			winText.SetActive(true);
		}
	}
}
