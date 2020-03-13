using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using System.Linq;
using System.Collections.Generic;

public class menu2 : MonoBehaviour {

	int[] validLevelNumbers = new int [3] {2, 3, 6}; 
	public static int i;
	int randomIndex;

	List<int> list3;

	// Use this for initialization
	void Start () {

		list3 = new List<int>(validLevelNumbers);
	}

	// Update is called once per frame
	void Update () {
		if (GameManager.gameState == GameState.GameOver) {

			this.enabled = true;

		}

		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.Quit(); 

	}


	public void Navigate(){

		if (validLevelNumbers.Length > 0) {
			randomIndex = UnityEngine.Random.Range (0, validLevelNumbers.Length);
			SceneManager.LoadScene (list3.ElementAt(randomIndex));
			list3.RemoveAt (randomIndex+1);
		} 
		else 
		{
			//validLevelNumbers = new int [3] {2, 3, 6}; 
			list3 = new List<int>(validLevelNumbers);
		}


		/*
		randomIndex = Random.Range (0, validLevelNumbers.Length);


		if (i == randomIndex) {
			randomIndex = Random.Range (0, validLevelNumbers.Length);
			i = randomIndex;
		}
			*/

	}

	public void Navigate2City(){
		SceneManager.LoadScene (2);
	}

	public void Navigate2Forest(){
		SceneManager.LoadScene (6);
	}

	public void Navigate2Main(){
		SceneManager.LoadScene (0);
	}

	public void Navigate2About(){
		SceneManager.LoadScene (5);
	}
	public void Navigate2LevelChoice(){
		SceneManager.LoadScene (4);
	}

	public void Navigate2LevelCity2(){
		SceneManager.LoadScene (3);
	}

	public void Navigate2MyScore1(){
		
		SceneManager.LoadScene (7);

	}


	/*IEnumerator LoadAfterDelay(string levelName){
		yield return new WaitForSeconds(3f); // wait 1 seconds
		SceneManager.LoadScene (levelName);

	}*/
}
