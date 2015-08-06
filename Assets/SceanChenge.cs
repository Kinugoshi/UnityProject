using UnityEngine;
using System.Collections;
using UnityEngine;

public class FadeManager : MonoBehaviour {
	void Start () {

	}
    float timer;    //タイマー変数
    double sceanTime = 2.5; //切り替わり時間
    void Update()
    {
        timer += Time.deltaTime;    //経過時間を取得

        //経過時間が切り替わり時間を上回る。
        if (timer > sceanTime)
        {
           Application.LoadLevel("Campas"); //次のシーンに移動
           timer = 0;   //タイマーをリセット
        }
    }
}