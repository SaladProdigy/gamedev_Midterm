using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroying : MonoBehaviour
{

	public GameObject peoplePrefab;
	


	private void OnTriggerEnter(Collider collision)
	{
		Destroy(peoplePrefab);
	}
}
