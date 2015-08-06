using UnityEngine;
using System.Collections;

public class TPSControl : MonoBehaviour {

    float Z_Speed = 0.5f;
    float X_Speed = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //縦、横の取得
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, vertical * Z_Speed);

        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, vertical * Z_Speed);

        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(horizontal * X_Speed, 0, 0);

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(horizontal * X_Speed, 0, 0);

        }
	}
}
