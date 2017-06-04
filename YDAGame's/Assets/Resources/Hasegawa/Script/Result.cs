using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour {

	private Text Score;
	private Text Rank;
	private Text HitRate;
	private int count = 0;
	private int score;

	// Use this for initialization
	void Start () {
		Score = GameObject.Find ("Score").GetComponent<Text> ();
		Rank = GameObject.Find ("Rank").GetComponent<Text> ();
		HitRate = GameObject.Find ("HitRate").GetComponent<Text> ();
		score = GameStatus.GetScore ();
		StartCoroutine ("ScoreCount");
	}

	IEnumerator ScoreCount(){
		while (true) {
			count++;
			Score.text = count.ToString ();
			yield return new WaitForSeconds (0.01f);
			if (count >= score)	break;
		}

		if (score >= 1000) {
			Rank.text = "S";
		} else if (score < 1000 && score >= 900) {
			Rank.text = "A";
		} else if (score < 900 && score >= 800) {
			Rank.text = "B";
		} else if (score < 800 && score >= 700) {
			Rank.text = "C";
		} else if (score <= 700) {
			Rank.text = "D";
		}

		int hitRate = GameStatus.GetHitRate ();
		HitRate.text = hitRate.ToString () + "%";

	}
}
