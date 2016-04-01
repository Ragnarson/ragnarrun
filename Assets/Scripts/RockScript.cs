using UnityEngine;
using System.Collections;

public class RockScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D otherElement)
	{
		// logic that kills Ragnar
		Rigidbody2D ragnar = otherElement.GetComponent<Rigidbody2D>();
		GameController.current.Hit ();
	}
}
