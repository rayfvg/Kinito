using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonWeather : MonoBehaviour
{
    public CanvasGroup CanvasGroup;
    public GameObject[] NextScenes;
    public GameObject CloseScene;
   

    public void NextSceneButton(int id)
    {
        NextScenes[id].SetActive(true);
        CanvasGroup.alpha = 0;
        CloseScene.SetActive(false);
    }
}
