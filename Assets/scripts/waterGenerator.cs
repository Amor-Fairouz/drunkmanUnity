using UnityEngine;
using System.Collections;

public class waterGenerator : MonoBehaviour {

	public GameObject water;
	public float instInterval;
	float randInterval;
	float time;
	// Use this for initialization
	void Start () {
		time = 0;
		randInterval = Random.Range (instInterval - 1, instInterval + 1);
	}

	// Update is called once per frame
	void Update () {
		if (GameManager.gamePhase == GamePhases.Playing) {
			time += Time.deltaTime;
			if (time > randInterval) {
				Instantiate (water, new Vector3 (Random.Range (-8, 8), transform.position.y), Quaternion.identity);
				time = 0;
				randInterval = Random.Range (instInterval - 1, instInterval + 1);
			}
		}
	}
}
