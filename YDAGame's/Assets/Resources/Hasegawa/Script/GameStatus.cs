using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour {

	private static int Score = 100;
	public static int GetScore(){return Score;}
	public static void AddScore(int input){Score += input;}

	private static bool Stop = true;
	public static void SetStopStatus(bool input){Stop = input;}

	private static int NumberOfShots;
	public static int GetNumberOfShots(){return NumberOfShots;}
	public static void AddNumberOfShots(){NumberOfShots++;}

	private static int NumberOfHits;
	public static int GetNumberOfHits(){return NumberOfHits;}
	public static void AddNumberOfHits(){NumberOfHits++;}

	public static int GetHitRate(){return 100 / (NumberOfShots / NumberOfHits);}

	public static void Initialization(){
		Score = 0;
		Stop = true;
		NumberOfShots = 0;
		NumberOfHits = 0;
	}
}