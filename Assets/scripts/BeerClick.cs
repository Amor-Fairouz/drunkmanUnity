using UnityEngine;
using System.Collections;

public class BeerClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		if (!Level3Manager.wanted) {
			Level3Manager.numError++;
		}
		Destroy (gameObject);
	}

	void OnTriggerEnter(Collider other) {
		if (other.name == "Sol") {
			if (Level3Manager.wanted) {
				Level3Manager.numError++;
			}
		}
	}
}
