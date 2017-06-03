using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour {

	[SerializeField]private Text scoreText;
	private int count = 0;
	private int score;

	// Use this for initialization
	void Start () {
		score = GameStatus.GetScore ();
		StartCoroutine ("ScoreCount");
	}

	IEnumerator ScoreCount(){
		while (true) {
			count++;
			scoreText.text = "Score : " + count;
			yield return new WaitForSeconds (0.01f);
			if (count >= score)	break;
		}
	}
}
