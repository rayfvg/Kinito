using UnityEngine;
using YG;

public class ADSforButton : MonoBehaviour
{
    public GameObject OpenSceneFIG;
    public GameObject CloseSceneFIG;
    public GameObject CloseSceneVIR;
    public GameObject OpenSceneVIR;

// ������������� �� ������� �������� ������� � OnEnable
private void OnEnable() => YandexGame.RewardVideoEvent += Rewarded;

// ������������ �� ������� �������� ������� � OnDisable
private void OnDisable() => YandexGame.RewardVideoEvent -= Rewarded;

// ����������� ����� ��������� �������
void Rewarded(int id)
{
        // ���� ID = 1, �� ����� "+100 �����"
        if (id == 1)
        {
            OpenSceneFIG.SetActive(true);
            CloseSceneFIG.SetActive(false);
        }
        else if (id == 2)
        {
            OpenSceneVIR.SetActive(true);
            CloseSceneVIR.SetActive(false);
        }
    }

// ����� ��� ������ ����� �������
public void ExampleOpenRewardAd(int id)
{
    // �������� ����� �������� ����� �������
    YandexGame.RewVideoShow(id);
}
}
