using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamaManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GamaManager Instance { get; private set; }
    public Player Player { get; private set; }

    [SerializeField] private Player player;

    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            player.Initialize("Hero", 1, 100, 0, 1000, 35, 40, 25);

            Player = player;

            ItemData armor1 = Resources.Load<ItemData>("Data/Item_Armor1");
            if (armor1 != null)
            {
                Player.AddItem(armor1);
            }

            UIManager.Instance.UImain.SetPlayerData(Player);
            UIManager.Instance.UIstatus.SetPlayerData(Player);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
