using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour {
	const int bulnum = 20;
	const int ennum = 20;
	public GameObject cam;
	public GameObject tamap;
	Bullet[] bul = new Bullet[bulnum];

	public GameObject enp;
	Enemy[] ene = new Enemy[ennum];

	bool shotf;
	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true;
		for (int i = 0; i < bulnum; i++) {
			bul [i] = new Bullet ();
		}
		for (int i = 0; i < ennum; i++) {
			ene [i] = new Enemy ();
			ene [0].init (enp, Mathf.Sin(i*18*3.14f/180)*10, 0, Mathf.Cos(i*18*3.14f/180)*10-10);
		}

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			cam.transform.Rotate (0, -1, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			cam.transform.Rotate (0, 1, 0);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			cam.transform.Rotate (1,0 , 0);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			cam.transform.Rotate (-1,0 , 0);
		}

		/*cam.transform.rotation =  Quaternion.AngleAxis (90.0f, Vector3.right) * 
			Input.gyro.attitude * Quaternion.AngleAxis (180.0f, Vector3.forward);
		*///cam2.transform.rotation = cam1.transform.rotation;

		if ((Input.touchCount > 0 || Input.GetMouseButtonDown (0) )&& shotf == false) {
			for (int i = 0; i < 20; i++) {
				if (bul [i].active == false) {
					bul [i].init (tamap, cam.transform.localEulerAngles.y,
						cam.transform.localEulerAngles.x);
					break;
				}
			}
			shotf = true;
		} else {
			shotf = false;
		}
		for (int i = 0; i < 20; i++) {
			bul[i].move ();

		}
		for (int i = 0; i < 20; i++) {
			ene[i].move ();

		}
		for (int i = 0; i < bulnum; i++) {
			for (int j = 0; j < ennum; j++) {
				if(hit(bul[i].pos,ene[j].pos,
					bul[i].sca,ene[j].sca)) {
					ene[i].destroy();
				}



			}
		}
	}
	bool hit(Vector3 p1,Vector3 p2,Vector3 s1,Vector3 s2) {
		bool ret = false;
		if (p1.x + s1.x / 2 > p2.x - s2.x / 2 &&
		   p1.x - s1.x / 2 < p2.x + s2.x / 2 &&
			p1.y + s1.y / 2 > p2.y - s2.y / 2 &&
			p1.y - s1.y / 2 < p2.y + s2.y / 2 &&
		   p1.z + s1.z / 2 > p2.z - s2.z / 2 &&
		   p1.z - s1.z / 2 < p2.z + s2.z / 2) {
			ret = true;
		}
		return ret;
	}
}
