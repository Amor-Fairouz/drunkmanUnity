using UnityEngine;
using System.Collections;

public class MoveCars : MonoBehaviour {

	public float speed = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.gameState == GameState.Playing) {
			transform.Translate (Vector2.up * speed, Space.Self);
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.name == "Bounds") {
			Destroy (this.gameObject);
		}
	}
}
