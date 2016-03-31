using UnityEngine;
using System.Collections;

public class SceneryScroller : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D otherElement){
		print (otherElement.tag);

		if (otherElement.tag == "Ground" || otherElement.tag == "Sky") {
			Vector2 position = otherElement.transform.position;

			position.x += 2*48.0f;

			otherElement.transform.position = position;
		}

	}
}
