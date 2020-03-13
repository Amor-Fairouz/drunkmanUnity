using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuJauge : MonoBehaviour {

	public Image jauge;
	public Text txt;
	float time;
	// Use this for initialization
	void Start () {
		time = 0;
	}
	
	// Update is called once per frame
	void Update () {

		jauge.fillAmount = GameManager.DrunkoMeter /40;
		if (GameManager.DrunkoMeter <= 0 || GameManager.DrunkoMeter >= 40) {
			GameManager.gameState = GameState.GameOver;
		}
		time += Time.deltaTime;
		if (time > 5) {
			GameManager.DrunkoMeter++;
			time = 0;
		}

	
	}
}
