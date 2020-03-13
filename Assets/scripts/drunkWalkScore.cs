using UnityEngine;
using System.Collections;

public class drunkWalkScore : MonoBehaviour {

	public int cupLevel;
	public GameObject chopp;
	public Sprite s0,s1,s2,s3,s4;
	private Sprite[] sprts;
	// Use this for initialization
	void Start () {
		cupLevel = 2;

		sprts = new Sprite[5];
		sprts[0]=s0  ;
		sprts[1]=s1  ;
		sprts[2]=s2  ;
		sprts[3]=s3  ;
		sprts[4]=s4  ;
	}
	
	// Update is called once per frame
	void Update () {
		chopp.GetComponent<SpriteRenderer> ().sprite = sprts [cupLevel];
		GameObject.Find ("man").GetComponent<manController> ().speed = cupLevel * 5;

	}
}
