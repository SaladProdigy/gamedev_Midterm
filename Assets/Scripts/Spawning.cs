using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{

	public GameObject peoplePrefab;
	float timeUntilSpawn;
	float spawnDelay;
	public GameObject player;
	
	// Update is called once per frame
	void Update () {
		
		/*timeUntilSpawn -= Time.deltaTime;
		if (timeUntilSpawn <= 0f)
		{

			//instantiate a new block
			GameObject newBlock = Instantiate(peoplePrefab, new Vector3(player.transform.position.x, player.transform.position.y, 0f), Quaternion.identity) as GameObject;
			//newBlock.transform.parent = transform;
			spawnDelay = .05f;
			timeUntilSpawn = Random.Range(-0.1f, 0.1f) + spawnDelay;//slightly randomize the delay until the next block

		}*/
		
	}
}
