using UnityEngine;
using System.Collections;

public class BeerGenerator : MonoBehaviour {

	public GameObject Beer;
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
				Instantiate (Beer, new Vector3 (Random.Range (-6, 6), transform.position.y), Quaternion.identity);
				time = 0;
				randInterval = Random.Range (instInterval - 1, instInterval + 1);
			}
		}
	}
}
