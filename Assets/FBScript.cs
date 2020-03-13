using UnityEngine;
using System.Collections;
using Facebook.Unity;
using System.Collections.Generic;
using UnityEngine.UI;

public class LoginFacebook : MonoBehaviour {

	public GameObject NotLoggedInUI;
	public GameObject LoggedInUI;

	void Update(){
		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.Quit(); 
	}
	void Awake(){

		if (!FB.IsInitialized) {
			FB.Init (InitCallBack);

		}
		ShowUI ();

	}
	void InitCallBack(){
		Debug.Log ("FB has been initialiased"); 


	}
	public void Login(){
		if(!FB.IsLoggedIn){
			FB.LogInWithReadPermissions(new List<string>{ "user_friends" }, LoginCallBack);	
		}
		ShowUI ();
	}
	void LoginCallBack(ILoginResult result){
		if (result.Error == null) {
			//Debug.Log ("FB has Logged in ... ");
			//Application.LoadLevel(1);
			ShowUI ();
		} else {
			Debug.Log ("Error During Login :" +result.Error);

		}

	}

	void ShowUI(){
		if (FB.IsLoggedIn) {
			LoggedInUI.SetActive (true);
			NotLoggedInUI.SetActive (false);
			FB.API ("me/picture?width=100&height=100",HttpMethod.GET,PictureCallBack);
			FB.API ("me?fields=first_name",HttpMethod.GET,NameCallBack);
		} else {
			LoggedInUI.SetActive (false);
			NotLoggedInUI.SetActive (true);

		}
	}

	void PictureCallBack(IGraphResult result){
		Texture2D image = result.Texture;
		LoggedInUI.transform.FindChild ("profilepicture").GetComponent<Image>().sprite=Sprite.Create(image,new Rect(0,0,100,100),new Vector2(0.5f,0.5f));
	}
	void NameCallBack(IGraphResult result){
		Debug.Log (result.RawResult);
		IDictionary<string,object> profile = result.ResultDictionary;
		LoggedInUI.transform.FindChild("Name").GetComponent<Text>().text="Hello "+profile ["first_name"];
	}

	public void LogOut(){
		FB.LogOut ();

	}



}