using UnityEngine;
using System.Collections;

/*
static class Constants
{
    public const float SW_SET_X = -4.4f;
    public const float SW_SET_Y = 7.6f;
    public const float SW_DEF_X = 9.1f;
    public const float SW_DEF_Y = 9.1f;
}
*/

public class IconMove : MonoBehaviour
{

    //表示非表示用スイッチ
    public GameObject _switch;
    public SwitchScript SW;

    // Use this for initialization
    void Start()
    {
        //SWをSwitchに関連付け
        _switch = GameObject.Find("Switch");
        SW = _switch.AddComponent<SwitchScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SW.getSwitchFlag())
        {
            if (transform.position.x < -4.4f)
            {
                transform.Translate(transform.right * 0.4f, 0);
            }
        }
        else
        {
            if (transform.position.x > -6.4f)
            {
                transform.Translate(transform.right * -0.4f, 0);
            }
        }
    }
}
