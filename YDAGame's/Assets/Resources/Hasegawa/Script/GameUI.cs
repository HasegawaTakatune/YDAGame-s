using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour {

	private Text Score;
	private Image[] Hp = new Image[5];
	public int num;

	// Use this for initialization
	void Start () {
		Score = GameObject.Find ("Score").GetComponent<Text> ();
		Hp = GameObject.Find ("Hp").GetComponentsInChildren<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		SetHp (num);
	}

	public void SetScore(){
		Score.text = GameStatus.GetScore ().ToString();
	}
	public void SetHp(int input){
		for (int i = 0; i < 5; i++) {
			if (i < input) {
				Hp [i].enabled = true;
			} else {
				Hp [i].enabled = false;
			}
		}
	}
}