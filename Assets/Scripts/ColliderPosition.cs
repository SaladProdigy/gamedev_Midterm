using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPosition : MonoBehaviour {

	public GameObject playerObj;    //name player object
	Vector3 cameraOffSet;   //offsets the camera

	public float x, y, z;
	
	// Use this for initialization
	void Start () {
		
		playerObj = GameObject.Find("Player");  //locate player
		cameraOffSet = new Vector3(x, y, z);  //offset camera for 3rd person view
	}

	void Update()
	{
		transform.position = playerObj.transform.position + cameraOffSet;
	}
}
