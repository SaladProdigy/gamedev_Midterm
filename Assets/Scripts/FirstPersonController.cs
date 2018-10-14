using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Allows movement of player
//BACKUP: Camera is controlled based on where the Player is
public class FirstPersonController : MonoBehaviour {

    public float moveSpeed = 10f;
	public float cameraSpeed;
	private Vector3 inputVector; //pass data from Update to FixedUpdate
	public float upDownRotation;
	
	
	// Update is called once per frame
	void Update () {
		//mouse look 
		
		float mouseX = Input.GetAxis("Mouse X") * cameraSpeed * Time.deltaTime; //mouseX= horizontal mouseDelta
		float mouseY = Input.GetAxis("Mouse Y") * cameraSpeed * Time.deltaTime; //mouseY = vertical mouseDelta
		
		
		transform.Rotate(0f, mouseX, 0f);
		upDownRotation -= mouseY;
		upDownRotation = Mathf.Clamp(upDownRotation, -80, 80);
		Camera.main.transform.localEulerAngles = new Vector3(
			upDownRotation,
			0f,
			0f
		);
		
		//FIRST PERSON PLAYER MOVEMENT

		float v = Input.GetAxis("Vertical");
		float h = Input.GetAxis("Horizontal");
		
		
		//a better method: move using RigidBody forces in FixedUpdate()
		
		inputVector = transform.forward * v * moveSpeed;
		inputVector += transform.right * h * moveSpeed;
		
		if (Input.GetMouseButtonDown(0))
		{
			Cursor.lockState = CursorLockMode.Locked; //lock cursor in center of screen
			Cursor.visible = false; //hide the cursor too, just to be safe
		}
		
		//Rotation w/ steady camera
		/*if (Input.GetKey(KeyCode.A))
		{

			transform.eulerAngles += new Vector3(0f, -5f, 0f);

		}
		//if we hold down D, rotate right
		if (Input.GetKey(KeyCode.D))
		{
	
			transform.eulerAngles += new Vector3(0f, 5f, 0f);
		}*/
	}

	//runs all the time every physics frame
	void FixedUpdate() //all physics code should go in here
	{

		//apply our forces
		GetComponent<Rigidbody>().velocity = inputVector;

	}

}
