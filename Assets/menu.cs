using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NavigationScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Start");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Update"+Time.deltaTime);
	}


	void FixedUpdate(){
		Debug.Log ("Fixed Update"+Time.deltaTime);
	}


	public void Navigate(){
		SceneManager.LoadScene (1);
	}
}
