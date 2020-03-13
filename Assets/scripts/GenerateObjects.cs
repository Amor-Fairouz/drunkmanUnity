using UnityEngine;
using System.Collections;

public class GenerateObjects : MonoBehaviour {

	public static bool[] posOccupee;
	public Transform[] pos;
	public GameObject[] objects;
	public float timeMin;
	public float timeMax;
	float timeDifference;
	float time;

	// Use this for initialization
	void Start () {
		posOccupee = new bool[100];
		for (int i = 0; i <= pos.Length; i++) {
			posOccupee [i] = false;
		}
	}

	// Update is called once per frame
	void Update () {
		if (GameManager.gameState == GameState.Playing) {
			time += Time.deltaTime;

			if (time >= timeDifference) {
				int currentPos = Random.Range (0, pos.Length);
				if (posOccupee [currentPos] == false) {
					GameObject temp = (GameObject) Instantiate (objects [Random.Range (0, objects.Length)], pos [currentPos].position, Quaternion.Euler (new Vector3 (0, 0, 0)));
					temp.GetComponent<Drunk> ().position = currentPos;
					posOccupee [currentPos] = true;
				}

				time = 0;
				timeDifference = Random.Range (timeMin, timeMax);
			}
		}
	
	}
}
