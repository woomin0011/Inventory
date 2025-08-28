using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI AttackText;
    [SerializeField] private TextMeshProUGUI DefenseText;
    [SerializeField] private TextMeshProUGUI CriticalText;
    [SerializeField] private Button CloseButton;

    public void SetPlayerData(Player player)
    {
        hpText.text = player.PlayerHealth.ToString();
        AttackText.text = player.PlayerAttack.ToString();
        DefenseText.text = player.PlayerDefense.ToString();
        CriticalText.text = player.PlayerCritical.ToString();
    }

    public void OnBack()
    {
        UIManager.Instance.UIstatus.gameObject.SetActive(false);
    }
}
