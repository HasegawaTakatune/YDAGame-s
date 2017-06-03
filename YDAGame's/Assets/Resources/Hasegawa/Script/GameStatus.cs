using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour {

	private static int Score = 1000;
	public static int GetScore(){return Score;}
	public static void AddScore(int input){Score += input;}

	private static bool Stop = true;
	public static void SetStopStatus(bool input){Stop = input;}

	public static void Initialization(){
		Score = 0;
		Stop = true;
	}
}