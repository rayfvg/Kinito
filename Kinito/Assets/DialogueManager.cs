using System.Collections;
using System.IO.Pipes;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;       // Ссылка на текстовый элемент
    public Button nextButton;       // Кнопка для перехода к следующему диалогу
    public float letterDelay = 0.1f; // Задержка между буквами

    public CanvasGroup CanvasGroup;
    public GameObject NextScene;

    private string Name;


    [SerializeField] string[] dialogues = new string[]
    {
        
    };

    private int currentDialogueIndex = 0;
    private bool isDisplaying = false; // Флаг, показывающий идет ли сейчас вывод текста

    void Start()
    {
        nextButton.onClick.AddListener(NextDialogue); // Добавляем слушатель для кнопки
        StartCoroutine(DisplayText(dialogues[currentDialogueIndex]));

        Name = PlayerPrefs.GetString("Name").ToString();
        
    }

    public void NextDialogue()
    {
        if (!isDisplaying)
        {
            currentDialogueIndex++;
            if (currentDialogueIndex < dialogues.Length)
            {
                StartCoroutine(DisplayText(dialogues[currentDialogueIndex]));
            }
            else
            {
                nextButton.interactable = false; // Отключаем кнопку, если диалоги закончились 
                CanvasGroup.alpha = 0;
                NextScene.SetActive(true);
            }
        }
    }

    IEnumerator DisplayText(string text)
    {
        isDisplaying = true;
        dialogueText.text = "";
        for (int i = 0; i < text.Length; i++)
        {
            dialogueText.text += text[i];
            yield return new WaitForSeconds(letterDelay);
        }
        isDisplaying = false;
    }
}

