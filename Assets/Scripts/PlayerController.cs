using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int life;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (5, 5);
		} else {
			GetComponent<Rigidbody2D>().velocity = new Vector2 (15, 0);
		}
	}
}
