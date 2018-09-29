using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroying : MonoBehaviour
{

	public GameObject playerObj;    //name player object
	Vector3 cameraOffSet;   //offsets the camera

	public float x, y, z;

	// Use this for initialization
	void Start () {

		playerObj = GameObject.Find("Player");  //locate player
		cameraOffSet = new Vector3(x, y, z);  //offset camera for 3rd person view

	}
	
	// Update is called once per frame
	void Update () {

		transform.position = playerObj.transform.position + cameraOffSet; //calculate position to fix camera with each update

	}
	
	private void OnTriggerEnter(Collider collision)
	{
		if(collision.gameObject.tag == "NPC")
		{
			Destroy(collision.gameObject);
		}
	}
}
