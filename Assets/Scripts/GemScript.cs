using UnityEngine;
using System.Collections;

public class GemScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D otherElement)
	{
		// logic that takes care of increasing score
		gameObject.GetComponent<Transform>().position = new Vector2(50,50);
		GameController.current.Scored ();
	}
}
