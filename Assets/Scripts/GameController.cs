using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GUIText scoreText;
	public GUIText lifeText;

	public static GameController current;
	public int life = 100;

	public int score = 0;

	void Awake()
	{
		if (current == null)
			current = this;
		else if(current != this)
			Destroy (gameObject);
	}

	void Start () {
	
	}

	void Update() {
		if (life <= 0) {
			GameController.current.GameOver();
		}
	}
	
	public void Scored() {
		score++;
		scoreText.text = "Score: " + score;
	}

	public void Hit() {
		life -= 20;
		lifeText.text = "Life: " + life;
	}

	public void GameOver() {
		//logic for gameover state
	}
}
