using UnityEngine;
using System.Collections;

public class Shop : MonoBehaviour {

	public static int beerCount;
	int beercoef =1;
	Animator anim;
	// Use this for initialization
	void Start () {
		beerCount = 0;
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (anim.GetInteger("state"));
		if (beerCount >= 1 * beercoef) {
			anim.SetInteger ("state", 2);
		}
		if (beerCount >= 2 * beercoef) {
			anim.SetInteger ("state", 3);
		}
		if (beerCount >= 3 * beercoef) {
			anim.SetInteger ("state", 4);
		}
		if (beerCount >= 4 * beercoef) {
			anim.SetInteger ("state", 5);
			GameManager.gamePhase = GamePhases.GameOver;
		}
	}
}
