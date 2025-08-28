using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIMain : MonoBehaviour
{
    [SerializeField] private Player Player;
    [SerializeField] private Button IInventory;
    [SerializeField] private Button IStatus;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI LevelText;
    [SerializeField] private Image EXPBar;
    [SerializeField] private TextMeshProUGUI GoldText;

    private float currentExp; // ���� ����ġ
    private float MaxExp = 100f; // �ִ� ����ġ

    private void Start()
    {
        IInventory.onClick.AddListener(OnClickIInventory);
        IStatus.onClick.AddListener(OnClickIStatus);
    }

    public void SetPlayerData(Player player)
    {
        nameText.text = Player.PlayerName;
        LevelText.text = Player.PlayerLevel.ToString();
        GoldText.text = Player.PlayerGold.ToString();
    }
    private void OnClickIInventory()
    {
        UIManager.Instance.UIinventory.gameObject.SetActive(true);
    }

    private void OnClickIStatus()
    {
        UIManager.Instance.UIstatus.gameObject.SetActive(true);
    }

    public void AddExperience(float exp)
    {
        currentExp = exp;
        float fillValue = Mathf.Clamp01(currentExp / MaxExp); // 0~1 ���� ������ ��ȯ
        EXPBar.fillAmount = fillValue; // �� ä���
    }
}
