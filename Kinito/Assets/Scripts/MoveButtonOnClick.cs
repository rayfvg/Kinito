using UnityEngine;
using UnityEngine.UI;

public class MoveButtonOnClick : MonoBehaviour
{
    // ���������� ��� �������� ������ ����������� ������
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public int Health;
    public int MaxHealth;

    public Slider slider;

    public GameObject CloseScene;
    public GameObject OpenScene;

    private Button button; // ������ �� ��������� ������

    void Start()
    {
        // �������� ��������� ������
        button = GetComponent<Button>();

        // ������������� �� ������� ������� ������
        button.onClick.AddListener(MoveButton);
    }

    void MoveButton()
    {
        // ���������� ��������� ���������� � �������� ��������
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        // �������� ������� ������� � ��������� � ����� �������
        Vector3 newPosition = new Vector3(randomX, randomY, button.transform.position.z);

        // ���������� ������ � ����� �������
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
        slider.value = Health; // ��������� �������� �������� ��������
    }
}
