using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Panel : MonoBehaviour {

	public void loadScene (int sceneNum){
		SceneManager.LoadScene (sceneNum);
	}

	void Update () {
		/*if (GameManager.gamePhase == GamePhases.Playing) {
			gameObject.SetActive (false);
		}else if(GameManager.gamePhase == GamePhases.GameOver) {
			gameObject.SetActive (true);
		}*/
	}
}
