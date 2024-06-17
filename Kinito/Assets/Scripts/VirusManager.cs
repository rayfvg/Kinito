using UnityEngine;
using UnityEngine.UI;

public class VirusManager : MonoBehaviour
{
    public Button[] buttons; // Массив кнопок

    private int currentButtonIndex; // Текущий индекс кнопки, которую нужно удалить
    public int Count = 0;

    public GameObject CloseScene;
    public GameObject OpenScene;

    public int Health;

    public Slider slider;
    void Start()
    {
        currentButtonIndex = 0; // Начинаем с первой кнопки

        // Получаем все кнопки из дочерних объектов
        buttons = GetComponentsInChildren<Button>();

        // Подписываемся на событие нажатия кнопки для каждой кнопки
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => ButtonClicked(button));
        }
    }

    void ButtonClicked(Button clickedButton)
    {
        // Проверяем, что нажатая кнопка совпадает с текущей кнопкой в массиве
        
            // Удаляем кнопку
            Destroy(clickedButton.gameObject);

            // Увеличиваем текущий индекс
            currentButtonIndex++;
            Count += 1;
        SetHpVirus(Count);

            // Проверяем, если текущий индекс вышел за пределы массива кнопок
            if (currentButtonIndex >= buttons.Length)
            {
                OpenScene.SetActive(true);
            CloseScene.SetActive(false);
            }
        
    }

    public void SetHpVirus(int hp)
    {
        slider.value = hp;
    }
}
