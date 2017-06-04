using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeButton : myButton {
	
	protected override void myOnClickButton (){
		GameStatus.SetStopStatus (false);
	}
}
