using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject rockPrefab;		//the column game 
	public int rockPoolSize = 5;		//how many objects to keep on standby
	public float spawnRate = 3f;		//how quickly objects spawn

	GameObject[] objects;				//collection of pooled objects
	int currentObject = 0;				//index of the current column in the collection


	void Start()
	{
		//initialize the objects collection
		objects = new GameObject[rockPoolSize];
		//loop through the collection and create the individual objects
		for(int i = 0; i < rockPoolSize; i++)
		{
			//note that objects will have the exact position and rotation of the prefab asset.
			//this is because we did not specify the position and rotation in the 
			//Instantiate() method call
			objects[i] = (GameObject)Instantiate(rockPrefab);
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
			//To spawn a column, get the current spawner position...
			Vector3 pos = transform.position;

			// set that for new object
			objects[currentObject].transform.position = pos;

			//increase the value of currentObject. If the new size is too big, set it back to zero
			if(++currentObject >= rockPoolSize)
				currentObject = 0;
			//leave this coroutine until the proper amount of time has passed
			yield return new WaitForSeconds(Random.Range(spawnRate-2f, spawnRate+4f));
		}
	}
}
