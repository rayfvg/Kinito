using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    
    public void RestartGames()
    {
        PlayerPrefs.SetInt("ThisScene", 0);
        SceneManager.LoadScene(0);
        this.gameObject.SetActive(false);
        
    }
}
