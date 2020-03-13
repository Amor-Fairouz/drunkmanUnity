using UnityEngine;
using System.Collections;

public class WaterClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		if (Level3Manager.wanted) {
			Level3Manager.numError++;
		}
		Destroy (gameObject);
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.name == "Sol") {
			if (!Level3Manager.wanted) {
				Level3Manager.numError++;
			}
		}
	}
}
