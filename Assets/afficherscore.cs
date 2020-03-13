using UnityEngine;
using System.Collections;

public class afficherscore : MonoBehaviour {
	private GUIStyle guiStyle = new GUIStyle();


	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnGUI () 

	{

		// Load and set Font
		Font myFont = (Font)Resources.Load("Fonts/Playbill", typeof(Font));
		guiStyle.font = myFont;


		guiStyle.fontSize = 88;
		guiStyle.normal.textColor = Color.white;

		//change the font size
		GUI.Label (new Rect (470, 450, 70, 20),"score: " + (int)(PlayerPrefs.GetFloat ("Score")
			 * 2.5), guiStyle);

	}



}
