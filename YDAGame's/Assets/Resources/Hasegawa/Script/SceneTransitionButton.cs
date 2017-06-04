using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransitionButton : myButton {

	[SerializeField] private string loadSceneName;

	protected override void myOnClickButton (){
		SceneManager.LoadScene (loadSceneName);
	}

}
