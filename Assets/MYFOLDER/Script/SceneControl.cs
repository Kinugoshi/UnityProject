using UnityEngine;
using System.Collections;

public class SceneControl : MonoBehaviour {

    public void CampusScene()
    {
        Application.LoadLevel("Template");
    }

    public void TemplateScene()
    {
        SetDisplay.Template = (float)Random.Range(0.0f, 360.0f);
        Application.LoadLevel("Draw");
    }

    public void TemplateScene2()
    {
        SetDisplay.Template = 1;
        Application.LoadLevel("Draw");
    }

    public void TemplateScene3()
    {
        SetDisplay.Template = 2;
        Application.LoadLevel("Draw");
    }
}
