using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

	public float speed = 8f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.gamePhase == GamePhases.Playing) {
			transform.Translate (new Vector3 (0, 1, 0) * speed * Time.deltaTime);
			if (transform.position.y > 30) {
				Destroy (gameObject);
			}
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		Destroy (gameObject);
	}
}
