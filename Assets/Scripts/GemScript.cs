using UnityEngine;
using System.Collections;

public class GemScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D otherElement)
	{
		// logic that takes care of increasing score
		Destroy(gameObject);
		GameController.current.Scored ();
	}
}
