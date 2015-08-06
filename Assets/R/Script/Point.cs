using UnityEngine;
using System.Collections;

public class Point : MonoBehaviour {

	public bool DestroyFlag;
	public GameObject C;
	
	// Use this for initialization
	void Start () {
		DestroyFlag = false;
		C = GameObject.Find ("cursor");
		transform.LookAt (C.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		//消しゴム処置
		if (Input.GetMouseButtonDown (0) ) {
			DestroyFlag = true;
		}
		if (Input.GetMouseButtonUp (0)) {
			DestroyFlag = false;
		}
	}
	void OnTriggerEnter2D (Collider2D coll) {
		if (coll.gameObject.tag == "cursor") {
			if( DestroyFlag ) {
				Destroy(this.gameObject);
			}
		}
	}
}
