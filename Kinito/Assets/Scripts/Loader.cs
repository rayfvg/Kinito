using UnityEngine;

public class Loader : MonoBehaviour
{
    private int _load;
    public GameObject[] loader;
    private void Start()
    {
       
        _load =  PlayerPrefs.GetInt("ThisScene");
        loader[_load].SetActive(true);
    }
}
