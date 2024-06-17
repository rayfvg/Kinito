using UnityEngine;
using UnityEngine.UI;

public class VirusManager : MonoBehaviour
{
    public Button[] buttons; // ������ ������

    public AudioSource _AudioSource;
    private int currentButtonIndex; // ������� ������ ������, ������� ����� �������
    public int Count = 0;

    public GameObject CloseScene;
    public GameObject OpenScene;

    public int Health;

    public Slider slider;
    void Start()
    {
        currentButtonIndex = 0; // �������� � ������ ������

        // �������� ��� ������ �� �������� ��������
        buttons = GetComponentsInChildren<Button>();

        // ������������� �� ������� ������� ������ ��� ������ ������
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => ButtonClicked(button));
        }
    }

    void ButtonClicked(Button clickedButton)
    {
        // ���������, ��� ������� ������ ��������� � ������� ������� � �������
        _AudioSource.Play();
            // ������� ������
            Destroy(clickedButton.gameObject);

            // ����������� ������� ������
            currentButtonIndex++;
            Count += 1;
        SetHpVirus(Count);

            // ���������, ���� ������� ������ ����� �� ������� ������� ������
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
