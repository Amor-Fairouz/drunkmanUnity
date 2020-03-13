using UnityEngine;
using System.Collections;

public class rasController : MonoBehaviour {

	public Canvas mycanvas;
	public float speed = 0.1F;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//ken fam nazla 3al ecran
		if (Input.touchCount > 0) {

			//te5ou l position mte3 inazla
			Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

			//t7arik il gameobject lil position hethika b distance max 0.2
			//transform.position = Vector2.MoveTowards(transform.position,new Vector2(-touchDeltaPosition.x,-touchDeltaPosition.y),0.2f);
			transform.Translate(-touchDeltaPosition.x * speed, -touchDeltaPosition.y * speed, 0);


		}

	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Cars") {
			GameManager.gameState = GameState.GameOver;
			mycanvas.gameObject.SetActive(true);
		}else if (coll.gameObject.tag == "Boisson") {
			Shop.beerCount++;
			GameManager.DrunkoMeter += coll.gameObject.GetComponent<Drunk> ().DrunkValue;
			GenerateObjects.posOccupee [coll.gameObject.GetComponent<Drunk> ().position] = false;
			Destroy (coll.gameObject);
		}
		else if (coll.gameObject.tag == "beer") {
			Shop.beerCount--;
			GameManager.DrunkoMeter += coll.gameObject.GetComponent<Drunk> ().DrunkValue;
			GenerateObjects.posOccupee [coll.gameObject.GetComponent<Drunk> ().position] = false;
			Destroy (coll.gameObject);
		}

	}
}
