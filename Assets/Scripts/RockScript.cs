using UnityEngine;
using System.Collections;

public class RockScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D otherElement)
	{
		print ("hit " + otherElement);
		// logic that kills Ragnar
	}
}
