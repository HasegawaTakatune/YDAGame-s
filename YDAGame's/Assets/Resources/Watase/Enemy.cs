using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public GameObject img;
	public Vector3 pos;
	public Vector3 rot;
	public Vector3 sca;
	public Vector3 vel;
	public bool active;
	public Vector3 mokuhyou;
	public Animator anim;
	public AnimatorStateInfo animInfo;

	public void init(GameObject p,float x,float y,float z) {
		img = Instantiate (p, new Vector3 (x, y, z), Quaternion.identity);
		pos = new Vector3 (0, 1, -10);
		active = true;
		anim = img.GetComponent<Animator> ();
		animInfo = anim.GetCurrentAnimatorStateInfo (0);
		anim.Play ("run_00",0);
		int deg = Random.Range (1, 20);
		mokuhyou_set (
			new Vector3 (Mathf.Sin (deg * 3.14f / 180) * deg,
				0,
				Mathf.Cos (deg * 3.14f / 180) * deg));
		sca = img.transform.localScale;
		Debug.Log (img.transform.position);
	}

	public void act() {

	}

	public void move() {
		if ((mokuhyou.x - pos.x) * (mokuhyou.x - pos.x) +
		    (mokuhyou.z - pos.z) * (mokuhyou.z - pos.z) > 36) {
			pos.x += pos.x - mokuhyou.x;
			pos.y += pos.y - mokuhyou.y;
			pos.z += pos.z - mokuhyou.z;
			img.transform.position = pos;
			int deg = Random.Range (0, 100);
			if (deg > 98) {
				deg = Random.Range (1, 20);
				mokuhyou_set (
					new Vector3 (Mathf.Sin (deg * 3.14f / 180) * deg,
						0,
						Mathf.Cos (deg * 3.14f / 180) * deg));
			}
		} else {
			int deg = Random.Range (0, 360);
			mokuhyou_set (
				new Vector3 (Mathf.Sin (deg * 3.14f / 180) * 20,
					0,
					Mathf.Cos (deg * 3.14f / 180) * 20));
		}
	}

	public void panti() {
		
	}
	public void mokuhyou_set(Vector3 p) {
		mokuhyou = p;
	}
	public void destroy() {
		Destroy (img);
		active = false;

	}
}
