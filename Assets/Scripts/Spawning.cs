using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//USAGE: Spawns people
//NEED TO DO: Spawner picks a random range spawn the person at (int randomNumber = Random.Range)
public class Spawning : MonoBehaviour
{

	public GameObject peoplePrefab;
	float timeUntilSpawn;
	float spawnDelay;
	public GameObject player;

	void Update()
	{
		
			timeUntilSpawn -= Time.deltaTime;

			if (timeUntilSpawn <= 0f)
			{

				//instantiate a new block
				GameObject newBlock = Instantiate(peoplePrefab,
					new Vector3(player.transform.position.x - 7f, player.transform.position.y, 0.5f),
					Quaternion.identity) as GameObject;
				//newBlock.transform.parent = transform;
				spawnDelay = 0.05f;
				timeUntilSpawn =
					Random.Range(-0.1f, 0.1f) + spawnDelay; //slightly randomize the delay until the next block

			}
		}
	}
	

