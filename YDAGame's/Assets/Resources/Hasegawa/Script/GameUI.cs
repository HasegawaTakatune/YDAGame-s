using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {

	private Text Score;

	// Use this for initialization
	void Start () {
		Score = GameObject.Find ("Score").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetScore(){
		Score.text = GameStatus.GetScore ().ToString();
	}
}
