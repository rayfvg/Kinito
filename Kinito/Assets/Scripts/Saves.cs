using UnityEngine;

public class Saves : MonoBehaviour
{

    public int IndexScene;
    
    public GameObject[] Scenes;
    public void Awake()
    {  
       PlayerPrefs.SetInt("ThisScene", IndexScene);
    }
    public void Start()
    {

        for (int i = 0; i < Scenes.Length; i++)
        {
            if (IndexScene != PlayerPrefs.GetInt("ThisScene"))
            {
                Scenes[i].SetActive(false);
            }
        }

    }

    private void OnDisable()
    {
        
    }
    public void ResetAll()
    {
        PlayerPrefs.DeleteAll();
    }
}
