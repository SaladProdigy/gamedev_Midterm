using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ADD Cheering Audio
public class WinState : MonoBehaviour
{

	public GameObject winText;


	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Boyfriend")
		{
			Time.timeScale = 0;
			winText.SetActive(true);
		}
	}
}
