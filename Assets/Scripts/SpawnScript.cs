using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject rockPrefab;		//the rock prefab
	public GameObject gemPrefab;		//the gem prefab
	public int poolSize = 5;		//how many objects to keep on standby
	public float spawnRate = 3f;		//how quickly objects spawn
	public float scaleMax = 0.5f;
	public float scaleMin = 1.0f;
	GameObject[] rockObjects;				//collection of pooled objects
	GameObject[] gemObjects;	
	int currentObject = 0;				//index of the current column in the collection

	void Start()
	{
		//initialize the objects collection
		rockObjects = new GameObject[poolSize];
		gemObjects = new GameObject[poolSize];
		//loop through the collection and create the individual objects
		for(int i = 0; i < poolSize; i++)
		{
			//note that objects will have the exact position and rotation of the prefab asset.
			//this is because we did not specify the position and rotation in the 
			//Instantiate() method call
			rockObjects[i] = (GameObject)Instantiate(rockPrefab);
			gemObjects[i] = (GameObject)Instantiate(gemPrefab);
		}
		//starts our function in charge of spawning the objects in the playable area
		StartCoroutine ("SpawnLoop");
	}

	public void StopSpawn()
	{
		//stops our spawning function
		StopCoroutine("SpawnLoop");
	}

	//this is a coroutine which manages when objects are spawned
	IEnumerator SpawnLoop()
	{
		//infinite loop: use with caution
		while (true) 
		{	
			//To spawn new object, get the current spawner position...
			Vector3 rockPos = transform.position;
			GameObject rockObject = rockObjects[currentObject];
			rockObject.transform.position = rockPos;

			Vector3 gemPos = transform.position;
			GameObject gemObject = gemObjects[currentObject];
			gemPos.x -= Random.Range(-4f, 4f);
			gemPos.y += 5.0f;
			gemObject.transform.position = gemPos;

			//increase the value of currentObject. If the new size is too big, set it back to zero
			if(++currentObject >= poolSize)
				currentObject = 0;
			//leave this coroutine until the proper amount of time has passed
			yield return new WaitForSeconds(Random.Range(spawnRate-2f, spawnRate+4f));
		}
	}
}
