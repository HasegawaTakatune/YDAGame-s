using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public GameObject img;
	public Vector3 pos;
	public Vector3 rot;
	public Vector3 sca;
	public Vector3 vel;
	public bool active;

	public void init(GameObject p,float ydeg,float xdeg) {
		img = Instantiate (p, new Vector3 (0, 1, -10), Quaternion.identity);
		pos = new Vector3 (0, 1, -10);
		vel.x = Mathf.Sin (ydeg * 3.14f / 180);
		vel.y = -Mathf.Sin (xdeg * 3.14f / 180);
		vel.z = Mathf.Cos (ydeg * 3.14f / 180);
		Debug.Log (vel);
		active = true;
		sca = img.transform.localScale;
	}

	public void move() {
		if (active == true) {
			pos += vel*0.1f;
			if ((pos.x - 0) * (pos.x - 0) +
			   (pos.z - (-10)) * (pos.z - (-10)) > 400) {
				Debug.Log ("end");
				destroy ();
			}	
			img.transform.position = pos;
		}
	}
	public void destroy() {
		Destroy (img);
		active = false;

	}
}
