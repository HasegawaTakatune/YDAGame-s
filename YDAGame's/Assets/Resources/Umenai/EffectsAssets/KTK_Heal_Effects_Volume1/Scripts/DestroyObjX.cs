﻿ using UnityEngine;
using System.Collections;

public class DestroyObjX: MonoBehaviour {
	
	public float timer = 0.5f;

	void Start () {
		
	}

	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0){
			Object.Destroy(gameObject);
		}
	}
}
