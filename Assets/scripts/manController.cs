using UnityEngine;
using System.Collections;



public class manController : MonoBehaviour {


	AudioSource triggerAudio;

	public float speed = 20f;


	//public float manSpeed;
	public float maxPos = 5f;

	Vector3 position;
	//public uiManager ui;



	void Start () {
		//ui = GetComponent<uiManager> ();
		GameManager.gamePhase=GamePhases.Playing;
		position = transform.position;

		triggerAudio = GetComponent <AudioSource> ();


	}



	void Update () {

		if (GameManager.gamePhase == GamePhases.Playing) {
			Vector3 dir = Vector3.zero;
			dir.x = -Input.acceleration.x ;
			//dir.z = Input.acceleration.x;
			if (dir.sqrMagnitude > 1)
				dir.Normalize ();

			dir *= Time.deltaTime;
			//transform.rotation = Quaternion.Euler (Input.acceleration);
			position.x += dir.x * speed;


			//transform.Translate(dir * speed);
	


			//position.x += Input.GetAxis ("Horizontal") * manSpeed * Time.deltaTime;


			//position.x = Mathf.Clamp (position.x, -maxPos, maxPos);

			transform.position = position;
		}
	}


	void OnCollisionEnter2D(Collision2D col){
		// test if hit wall left or right : change animation ; cgange statu value
		if (col.gameObject.name == "wallLeft") {
			GetComponent<Animator> ().SetInteger ("state", 1);
			GameManager.gamePhase = GamePhases.GameOver;
		} else if (col.gameObject.name == "wallRight") {
			GetComponent<Animator> ().SetInteger ("state", 2);
			GameManager.gamePhase = GamePhases.GameOver;
		} else if (col.gameObject.tag == "beer") {
			Shop.beerCount++;
		}
		else if (col.gameObject.tag == "Boisson") {
			Shop.beerCount--;
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if ((other.gameObject.tag == "beer") || (other.gameObject.tag=="Boisson"))
		{
			triggerAudio.Play ();
		
		}
		if (other.gameObject.tag == "beer") {
			Shop.beerCount++;
		}
		else if (other.gameObject.tag == "Boisson") {
			Shop.beerCount--;
		}
		Destroy (other.gameObject);




	}


}
