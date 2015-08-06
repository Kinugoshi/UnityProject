using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Test : MonoBehaviour {

    public Text text;
    public string str = "Hello World";


    public void OnClick(){

        text.text = str;

    }

}
