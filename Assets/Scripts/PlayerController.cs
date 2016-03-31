﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int life;
	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey ("space")) {
			rb.AddForce (Vector2.up * 100);
		}
		rb.velocity = new Vector2 (10, rb.velocity.y);
	}
}
