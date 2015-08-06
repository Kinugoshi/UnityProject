using UnityEngine;
using System.Collections;

public class EraserIcon : MonoBehaviour {
    //表示非表示用スイッチ
    public GameObject _switch;
    public SwitchScript SW;

	// Use this for initialization
	void Start () {
        //SWをSwitchに関連付け
        _switch = GameObject.Find("Switch");
        SW = _switch.AddComponent<SwitchScript>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
