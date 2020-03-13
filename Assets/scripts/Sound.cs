using UnityEngine;
using System.Collections;
using UnityEngine.UI ;

public class Sound : MonoBehaviour {

	int muted;

	public Sprite soundOn,soundOff;

	public bool condition;

	private Button button;

	public void mute()
	{
		if (PlayerPrefs.GetInt ("mute") == null) {
			PlayerPrefs.SetInt ("mute", 0);
		} else {
			muted = PlayerPrefs.GetInt ("mute");
		}
		if (muted == 0) {
			muted = 1;
			AudioListener.pause = true;
			PlayerPrefs.SetInt ("mute", 1);
			button.image.overrideSprite = soundOff;
		} else {
			muted = 0;
			AudioListener.pause = false;
			PlayerPrefs.SetInt ("mute", 0);
			button.image.overrideSprite = soundOn;
		}

	}

	void Start(){
		AudioListener.pause = false;
		button = GetComponent<Button>();
	}

	void Update(){
		Debug.Log ("muted  "+muted);
	}
}
