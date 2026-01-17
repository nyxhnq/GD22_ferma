using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;
    [SerializeField] UIManager uiManager;
    [SerializeField] TextMeshProUGUI healthText;

    void Start()
    {
        healthText.text = "" + health;  
    }

    public void DecreaseHealth()
    {
        Debug.Log("PlayerHealth: DecreaseHealth called");
        health--; //health = health - 1
        healthText.text = "" + health;
        //Обновить UI здесь, если нужно
        if (health <= 0) 
        {
            uiManager.ShowGameOverScreen();
        }
    }
}

