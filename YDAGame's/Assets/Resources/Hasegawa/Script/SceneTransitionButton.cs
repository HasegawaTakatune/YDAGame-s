using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransitionButton : MonoBehaviour {

	[SerializeField] private string loadSceneName;
	private Button button;

	// Use this for initialization
	void Start () {
		button = GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {
		button.onClick.AddListener (OnClickButton);
	}

	private void OnClickButton(){
		SceneManager.LoadScene (loadSceneName);
	}
}
