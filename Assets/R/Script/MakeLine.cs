using UnityEngine;
using System.Collections;

public class MakeLine : MonoBehaviour {

	//Pointオブジェクトを探す
	public GameObject Point;

	//プレファブ
	//public GameObject Prefab;

	//Pointオブジェクトを探す
	private GameObject cursor;

	//マウスの相対座標
	public Vector3 screenPos;
    //マウスの絶対座標
	public Vector3 worldPos;
    //前回のフレームのマウスの絶対座標
	public Vector3 old_worldPos;
    //表示非表示用スイッチ
    public GameObject _switch;
    public SwitchScript SW;

	//座標を返す
	public Vector3 GetPoint(){
		return worldPos;
	}

	//描画フラグ
	bool DrawFlag;
	
	void Start () {
		worldPos = new Vector3 (0, 0, 0);
		old_worldPos = new Vector3 (0, 0, 0);
		cursor = GameObject.Find ("cursor");
		DrawFlag = false;
        //SWをSwitchに関連付け
        _switch = GameObject.Find("Switch");
        SW = _switch.AddComponent<SwitchScript>();
	}

	void Update () {
		//前回の座標の記憶
		old_worldPos = worldPos;
		//マウスの絶対座標を求める
		screenPos = Input.mousePosition;
		worldPos = Camera.main.ScreenToWorldPoint(screenPos);
		//マウスの座標のZ軸の位置を修正（デフォルトで-10）
		worldPos.z = 0.00f;

		//Pointオブジェクトの座標をマウスの座標に変更
		cursor.transform.position = worldPos ;

		//マウスクリックのイベント
        if(SW.PaintFlag){
		    if (Input.GetMouseButtonDown (0)) {
			    DrawFlag = true;
		    }
		    if (Input.GetMouseButtonUp (0)) {
			    DrawFlag = false;
		    }
		    if (DrawFlag) {
			    Instantiate (Point, new Vector2 (worldPos.x, worldPos.y),new Quaternion());
		    }
        }

		if (Input.GetKeyDown(KeyCode.H)) {
			// Screenshot を撮る
			Application.CaptureScreenshot("screenshot.png");
		}

	}
}