using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Level3Manager : MonoBehaviour {

	public static bool wanted;
	public static int numError;
	float ran;
	public Text Instruction;
	public Image head1;
	public Image head2;
	public Image head3;
	public Image ImageInstruction;
	float time;
	float inter = 2;
	public Sprite beer;
	public Sprite water;
	public GameObject gameover;
	float playerScore = 0;
	private GUIStyle guiStyle = new GUIStyle();

	// Use this for initialization
	void Start () {
		numError = 0;
		time = 0;
		wanted = true;
		GameManager.gamePhase = GamePhases.Playing;


	}

	// Update is called once per frame
	void Update () {
		if (GameManager.gamePhase == GamePhases.Playing) {
			time += Time.deltaTime;
			if (numError > 3) {
				head1.enabled = false;
				head2.enabled = false;
				head3.enabled = false;
			} else if (numError > 2) {
				head1.enabled = true;
				head2.enabled = false;
				head3.enabled = false;
			} else if (numError > 1) {
				head1.enabled = true;
				head2.enabled = true;
				head3.enabled = false;
			} else if (numError > 0) {
				head1.enabled = true;
				head2.enabled = true;
				head3.enabled = true;
			}
			ran = Random.Range (0, 10);
			if (time > inter) {
				time = 0;
				if (ran > 5) {
					ImageInstruction.sprite = beer;
					wanted = true;
					Instruction.text = "Stay Drunk";
				} else {
					ImageInstruction.sprite = water;
					wanted = false;
					Instruction.text = "Stay Sober";
				}
			}
		}
		if (numError > 3) {
			GameManager.gamePhase = GamePhases.GameOver;
			gameover.SetActive (true);
		} else {
			playerScore += Time.deltaTime;
		}


		PlayerPrefs.SetFloat ("Score", playerScore);

	}

	void OnGUI () 

	{

		// Load and set Font
		Font myFont = (Font)Resources.Load("Fonts/Playbill", typeof(Font));
		guiStyle.font = myFont;


		guiStyle.fontSize = 40;
		guiStyle.normal.textColor = Color.white;

		//change the font size
		GUI.Label (new Rect (470, 20, 70, 20),"score: " + (int)(playerScore * 2.5), guiStyle);

	}
}
