using UnityEngine;
using System.Collections;

public class SwitchScript : MonoBehaviour {

    //スイッチの状態
    public bool SwitchFlag;
    public bool MouseButtonFlag;

    //ツールの状態
    public int ToolType;
    
    //ペイントを有効にするかしないか
    public bool PaintFlag;

    public bool getSwitchFlag(){
        return SwitchFlag;
    }

	// Use this for initialization
	void Start () {
        PaintFlag = true;
        SwitchFlag = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!PaintFlag)
        {
            if(Input.GetMouseButtonDown(0))
            {
                SwitchFlag = !SwitchFlag;
            }
        }
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
       
        if (coll.gameObject.tag == "cursor")
        { 
            PaintFlag = false;
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {

        if (coll.gameObject.tag == "cursor")
        {
            PaintFlag = true;
        }
    }
}
