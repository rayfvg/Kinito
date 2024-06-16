using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WriteName : MonoBehaviour
{
    public TMP_Text Name;

    private void Start()
    {
        string namePlayer = PlayerPrefs.GetString("Name");
        Name.text = "Ýýýé " + namePlayer + " !!";
    }
}
