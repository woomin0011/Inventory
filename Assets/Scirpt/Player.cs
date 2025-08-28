using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private string playerName;
    [SerializeField] private int playerLevel;
    [SerializeField] private int playerHealth;
    [SerializeField] private int playerExperience;
    [SerializeField] private int playerGold;


    public Player(string playerName , int playerLevel , int playerHealth, int playerExperience, int playerGold)
    {
        this.playerName = playerName;
        this.playerLevel = playerLevel;
        this.playerHealth = playerHealth;
        this.playerExperience = playerExperience;
        this.playerGold = playerGold;
    }
}
