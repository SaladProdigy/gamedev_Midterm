﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartState : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {


		if (Input.GetMouseButton(0))
		{
			SceneManager.LoadScene("TestScene", LoadSceneMode.Single);
		}
	}
}