using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UnityChanControl : MonoBehaviour {

    public float Speed;
    public bool flg;
    public GameObject Prefab;
    float intervaltime;

	// Use this for initialization
	void Start () {
        flg = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Enter");
            flg = true;
        }

        if (flg)
        {
                transform.Translate(0, 0, 1 * Speed);
        }

        //transform.Rotate(new Vector3(90, 90, 90) * Time.deltaTime);

            Instantiate(Prefab, new Vector3(0, 0, 0), Quaternion.identity);

	}
}
