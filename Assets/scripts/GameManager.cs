using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;
public class GameManager : MonoBehaviour {

	public static GamePhases gamePhase;
	public static GameState gameState;

	public static float DrunkoMeter;
	float playerScore = 0;
	private GUIStyle guiStyle = new GUIStyle();

	public GameObject panel;
	// Use this for initialization
	void Start () {
		DrunkoMeter = 10;

	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.gamePhase == GamePhases.GameOver) {
			ShowAd ();
			//Time.timeScale = 0;
			panel.SetActive (true);
		}else if (GameManager.gamePhase == GamePhases.Playing) {
			//Time.timeScale = 1;
			panel.SetActive (false);
			playerScore += Time.deltaTime;
		}

	}

	public void ShowAd()
	{
		if (Advertisement.IsReady())
		{
			Advertisement.Show();
		}
	}

	void OnGUI () 

	{

		// Load and set Font
		Font myFont = (Font)Resources.Load("Fonts/Playbill", typeof(Font));
		guiStyle.font = myFont;
	
	
		guiStyle.fontSize = 30;
		guiStyle.normal.textColor = Color.white;

		//change the font size
		GUI.Label (new Rect (230, 10, 70, 20),"score: " + (int)(playerScore * 2.5), guiStyle);


	}
}
