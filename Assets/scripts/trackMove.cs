using UnityEngine;
using System.Collections;

public class trackMove : MonoBehaviour {

	public float speed = 0.2f;
	Vector2 offset;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.gamePhase == GamePhases.Playing) {
			offset = new Vector2 (0, Time.time * speed);

			GetComponent<Renderer> ().material.mainTextureOffset = -offset;
		}
	}
}
