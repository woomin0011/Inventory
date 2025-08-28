using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; set; }
    [SerializeField] private UIMain UIMain;
    [SerializeField] private UIInventory UIInventory;
    [SerializeField] private UIStatus UIStatus;

    public UIMain UImain => UIMain;
    public UIInventory UIinventory => UIInventory;
    public UIStatus UIstatus => UIStatus;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
