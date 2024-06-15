using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHolder : MonoBehaviour
{
    public CanvasGroup CanvasGroup;
    public GameObject NextScene;
  public void SetName(string name)
    {
        PlayerPrefs.SetString("Name", name);
        CanvasGroup.alpha = 0f;
        NextScene.SetActive(true);
    }
}
