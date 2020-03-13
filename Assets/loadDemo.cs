using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;
using System.Linq;
using System.Collections.Generic;

public class loadDemo : MonoBehaviour {

	// Use this for initialization
	string name="Forest";
	int[] validLevelNumbers = new int [3] {2, 3, 6}; 
	public static int i;

	int randomIndex;

	List<int> list3;

		IEnumerator Start () 
	    {
		list3 = new List<int>(validLevelNumbers);

			yield return new WaitForSeconds (3f);
		//Application.LoadLevel (name);


		if (validLevelNumbers.Length > 0) {
			randomIndex = UnityEngine.Random.Range (0, validLevelNumbers.Length);
			Application.LoadLevel (list3.ElementAt(randomIndex));
			list3.RemoveAt (randomIndex+2);
		} 
		else 
		{
			//validLevelNumbers = new int [3] {2, 3, 6}; 
			list3 = new List<int>(validLevelNumbers);
		}

		}
	
	
	// Update is called once per frame
	void Update () {
	
	}
}
