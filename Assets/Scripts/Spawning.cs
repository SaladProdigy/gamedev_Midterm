using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

//USAGE: Spawns people
//INTENT: Put on a spawning cube that follows the player forward
public class Spawning : MonoBehaviour
{

	public GameObject peoplePrefab;
	float timeUntilSpawn;
	float spawnDelay = 2f;
	public GameObject Spawner;


	void Update()
	{
		int randomNumberX = Random.Range(-1, -3);
		int randomNumberZ = Random.Range(-5, 5);

		timeUntilSpawn -= Time.deltaTime;

		if (timeUntilSpawn <= 0f)
		{


			//instantiate a new block
			GameObject newBlock = Instantiate(peoplePrefab,
				new Vector3(Spawner.transform.position.x + randomNumberX, Spawner.transform.position.y, randomNumberZ),
				Quaternion.identity) as GameObject;
			//newBlock.transform.parent = transform;
			spawnDelay = 0.0019f;
			timeUntilSpawn =
				Random.Range(-0.1f, 0.1f) + spawnDelay; //slightly randomize the delay until the next block

		}
	}
}
	
	

