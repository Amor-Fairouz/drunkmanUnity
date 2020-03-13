using UnityEngine;
using System.Collections;

public class GenerateCars : MonoBehaviour {

	public Transform[] pos;
	public GameObject[] cars;
	public float rotation;
	public float timeMin;
	public float timeMax;
	float timeDifference;
	float time;
	// Use this for initialization
	void Start () {
		time = 0;
		GameManager.gameState = GameState.Playing;
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.gameState == GameState.Playing) {
			time += Time.deltaTime;

			if (time >= timeDifference) {
				int currentPos = Random.Range (0, pos.Length);
				switch (currentPos) {
				case 0:
					rotation = 90;
					break;
				case 1:
					rotation = 0;
					break;
				case 2:
					rotation = -90;
					break;
				case 3:
					rotation = 180;
					break;

				}
				Instantiate (cars [Random.Range (0, cars.Length)], pos [currentPos].position, Quaternion.Euler (new Vector3 (0, 0, rotation)));
				time = 0;
				timeDifference = Random.Range (timeMin, timeMax);
			}
		}
	}
}
