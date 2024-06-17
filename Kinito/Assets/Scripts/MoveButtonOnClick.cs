using UnityEngine;
using UnityEngine.UI;

public class MoveButtonOnClick : MonoBehaviour
{
    // Переменные для хранения границ перемещения кнопки
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public int Health;
    public int MaxHealth;

    public Slider slider;

    public GameObject CloseScene;
    public GameObject OpenScene;

    private Button button; // Ссылка на компонент кнопки

    void Start()
    {
        // Получаем компонент кнопки
        button = GetComponent<Button>();

        // Подписываемся на событие нажатия кнопки
        button.onClick.AddListener(MoveButton);
    }

    void MoveButton()
    {
        // Генерируем случайные координаты в заданных границах
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        // Получаем текущие позицию и сохраняем в новой позиции
        Vector3 newPosition = new Vector3(randomX, randomY, button.transform.position.z);

        // Перемещаем кнопку в новую позицию
        button.transform.position = newPosition;

        Health -= 1;
        SetHealth(Health);
        if(Health <= 0)
        {
            OpenScene.SetActive(true);
            CloseScene.SetActive(false);
        }
    }

    public void SetHealth(int Health)
    {
        slider.value = Health; // Установка текущего значения слайдера
    }
}
